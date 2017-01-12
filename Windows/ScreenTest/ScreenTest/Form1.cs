using System;
using System.Drawing;
using System.Windows.Forms;

namespace ScreenTest
{
    public partial class Form1 : Form
    {
        // CONFIG
        private static string serialPort = "COM13";
        private static bool chromaIntegration = false;
        private static int refreshInterval = 50;


        // DECLARE VARIABLES
        private Rectangle bounds = Screen.GetBounds(Point.Empty);
        private int[] spectrumVals = { 255, 0, 0 };
        private int[] fadeVals = { 0, 1 };
        private int[] staticColor = { 0, 255, 0 };
        private int fadesRun = 0;
        private int fadeSpeed = 1;
        private ColorDialog staticSelect = new ColorDialog();

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (modeScreen.Checked)
            {
                // CREATE BITMAP WITH SCREEN DIMENSIONS
                using (Bitmap screen = new Bitmap(bounds.Width, bounds.Height))
                {
                    using (Graphics g = Graphics.FromImage(screen))
                    {
                        // TAKE SCREENSHOT TO BITMAP
                        g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
                    }

                    int red = 0;
                    int green = 0;
                    int blue = 0;
                    int loops = 0;

                    // AVERAGE PIXEL VALUES
                    for (int x = 0; x < screen.Width; x += 8)
                    {
                        for (int y = 0; y < screen.Height; y += 8)
                        {
                            Color pixelColor = screen.GetPixel(x, y);
                            red += pixelColor.R;
                            green += pixelColor.G;
                            blue += pixelColor.B;
                            loops++;
                        }
                    }
                    red = (red / (screen.Height * screen.Width / 64));
                    green = (green / (screen.Height * screen.Width / 64));
                    blue = (blue / (screen.Height * screen.Width / 64));

                    // WRITE COLORS TO SERIAL
                    serialPort1.Write(new byte[] { 0xff, (byte)red, (byte)green, (byte)blue }, 0, 4);

                    // WRITE COLORS TO RAZER CHROMA
                    if (chromaIntegration) { Corale.Colore.Core.Keyboard.Instance.SetAll(Corale.Colore.Core.Color.FromRgb((uint)((red << 16) | (green << 8) | (blue << 0)))); }
                }
            }
            else if (modeSpectrumCycling.Checked)
            {
                spectrumVals[fadeVals[0]] -= fadeSpeed;
                spectrumVals[fadeVals[1]] += fadeSpeed;
                fadesRun += fadeSpeed;

                if (fadesRun >= 255)
                {
                    fadesRun = 0;
                    fadeVals[0]++;
                    fadeVals[1]++;
                    if (fadeVals[0] == 3)
                    {
                        fadeVals[0] = 0;
                    }
                    if (fadeVals[1] == 3)
                    {
                        fadeVals[1] = 0;
                    }
                }

                serialPort1.Write(new byte[] { 0xff, (byte)spectrumVals[0], (byte)spectrumVals[1], (byte)spectrumVals[2] }, 0, 4);

                if (chromaIntegration) { Corale.Colore.Core.Keyboard.Instance.SetAll(Corale.Colore.Core.Color.FromRgb((uint)((spectrumVals[0] << 16) | (spectrumVals[1] << 8) | (spectrumVals[2] << 0)))); }
            }
            else if (modeSolidColor.Checked)
            {
                serialPort1.Write(new byte[] { 0xff, (byte)staticColor[0], (byte)staticColor[1], (byte)staticColor[2] }, 0, 4);

                if (chromaIntegration) { Corale.Colore.Core.Keyboard.Instance.SetAll(Corale.Colore.Core.Color.FromRgb((uint)((staticColor[0] << 16) | (staticColor[1] << 8) | (staticColor[2] << 0)))); }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = refreshInterval;
            timer1.Start();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            serialPort1.PortName = serialPort;
            serialPort1.BaudRate = 9600;
            serialPort1.Open();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void modeScreen_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void modeSpectrumCycling_CheckedChanged(object sender, EventArgs e)
        {
            spectrumCyclingSpeed.Enabled = modeSpectrumCycling.Checked;
        }

        private void modeSolidColor_CheckedChanged(object sender, EventArgs e)
        {
            colorSelectOpen.Enabled = modeSolidColor.Checked;
        }

        private void spectrumCyclingSpeed_ValueChanged(object sender, EventArgs e)
        {
            fadeSpeed = (int)Math.Round(spectrumCyclingSpeed.Value, 0);
            fadesRun = 0;
            fadeVals[0] = 0;
            fadeVals[1] = 1;
            spectrumVals[0] = 255;
            spectrumVals[1] = 0;
            spectrumVals[2] = 0;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyIcon1.Visible = false;
            this.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Write(new byte[] { 0xff, (byte)staticColor[0], (byte)staticColor[1], (byte)staticColor[2] }, 0, 4);
            serialPort1.Close();
        }

        private void killButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
            this.Hide();
        }

        private void colorSelectOpen_Click(object sender, EventArgs e)
        {
            if (staticSelect.ShowDialog() == DialogResult.OK)
            {
                staticColor[0] = staticSelect.Color.R;
                staticColor[1] = staticSelect.Color.G;
                staticColor[2] = staticSelect.Color.B;
            }
        }
    }
}