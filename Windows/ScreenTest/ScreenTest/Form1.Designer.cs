namespace ScreenTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.settingsBox = new System.Windows.Forms.GroupBox();
            this.colorSelectOpen = new System.Windows.Forms.Button();
            this.killButton = new System.Windows.Forms.Button();
            this.hideButton = new System.Windows.Forms.Button();
            this.spectrumCyclingSpeed = new System.Windows.Forms.NumericUpDown();
            this.modeSolidColor = new System.Windows.Forms.RadioButton();
            this.modeSpectrumCycling = new System.Windows.Forms.RadioButton();
            this.modeScreen = new System.Windows.Forms.RadioButton();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.settingsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spectrumCyclingSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // settingsBox
            // 
            this.settingsBox.Controls.Add(this.colorSelectOpen);
            this.settingsBox.Controls.Add(this.killButton);
            this.settingsBox.Controls.Add(this.hideButton);
            this.settingsBox.Controls.Add(this.spectrumCyclingSpeed);
            this.settingsBox.Controls.Add(this.modeSolidColor);
            this.settingsBox.Controls.Add(this.modeSpectrumCycling);
            this.settingsBox.Controls.Add(this.modeScreen);
            this.settingsBox.Location = new System.Drawing.Point(12, 12);
            this.settingsBox.Name = "settingsBox";
            this.settingsBox.Size = new System.Drawing.Size(260, 180);
            this.settingsBox.TabIndex = 0;
            this.settingsBox.TabStop = false;
            this.settingsBox.Text = "Settings";
            this.settingsBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // colorSelectOpen
            // 
            this.colorSelectOpen.Enabled = false;
            this.colorSelectOpen.Location = new System.Drawing.Point(6, 115);
            this.colorSelectOpen.Name = "colorSelectOpen";
            this.colorSelectOpen.Size = new System.Drawing.Size(75, 23);
            this.colorSelectOpen.TabIndex = 6;
            this.colorSelectOpen.Text = "Select Color";
            this.colorSelectOpen.UseVisualStyleBackColor = true;
            this.colorSelectOpen.Click += new System.EventHandler(this.colorSelectOpen_Click);
            // 
            // killButton
            // 
            this.killButton.Location = new System.Drawing.Point(98, 151);
            this.killButton.Name = "killButton";
            this.killButton.Size = new System.Drawing.Size(75, 23);
            this.killButton.TabIndex = 5;
            this.killButton.Text = "Exit";
            this.killButton.UseVisualStyleBackColor = true;
            this.killButton.Click += new System.EventHandler(this.killButton_Click);
            // 
            // hideButton
            // 
            this.hideButton.Location = new System.Drawing.Point(179, 151);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(75, 23);
            this.hideButton.TabIndex = 2;
            this.hideButton.Text = "Hide";
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // spectrumCyclingSpeed
            // 
            this.spectrumCyclingSpeed.Enabled = false;
            this.spectrumCyclingSpeed.Location = new System.Drawing.Point(6, 66);
            this.spectrumCyclingSpeed.Name = "spectrumCyclingSpeed";
            this.spectrumCyclingSpeed.Size = new System.Drawing.Size(86, 20);
            this.spectrumCyclingSpeed.TabIndex = 3;
            this.spectrumCyclingSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spectrumCyclingSpeed.ValueChanged += new System.EventHandler(this.spectrumCyclingSpeed_ValueChanged);
            // 
            // modeSolidColor
            // 
            this.modeSolidColor.AutoSize = true;
            this.modeSolidColor.Location = new System.Drawing.Point(6, 92);
            this.modeSolidColor.Name = "modeSolidColor";
            this.modeSolidColor.Size = new System.Drawing.Size(75, 17);
            this.modeSolidColor.TabIndex = 2;
            this.modeSolidColor.Text = "Solid Color";
            this.modeSolidColor.UseVisualStyleBackColor = true;
            this.modeSolidColor.CheckedChanged += new System.EventHandler(this.modeSolidColor_CheckedChanged);
            // 
            // modeSpectrumCycling
            // 
            this.modeSpectrumCycling.AutoSize = true;
            this.modeSpectrumCycling.Location = new System.Drawing.Point(6, 42);
            this.modeSpectrumCycling.Name = "modeSpectrumCycling";
            this.modeSpectrumCycling.Size = new System.Drawing.Size(107, 17);
            this.modeSpectrumCycling.TabIndex = 1;
            this.modeSpectrumCycling.Text = "Spectrum Cycling";
            this.modeSpectrumCycling.UseVisualStyleBackColor = true;
            this.modeSpectrumCycling.CheckedChanged += new System.EventHandler(this.modeSpectrumCycling_CheckedChanged);
            // 
            // modeScreen
            // 
            this.modeScreen.AutoSize = true;
            this.modeScreen.Checked = true;
            this.modeScreen.Location = new System.Drawing.Point(6, 19);
            this.modeScreen.Name = "modeScreen";
            this.modeScreen.Size = new System.Drawing.Size(86, 17);
            this.modeScreen.TabIndex = 0;
            this.modeScreen.TabStop = true;
            this.modeScreen.Text = "Screen Color";
            this.modeScreen.UseVisualStyleBackColor = true;
            this.modeScreen.CheckedChanged += new System.EventHandler(this.modeScreen_CheckedChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM13";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Doin Stuff";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 204);
            this.Controls.Add(this.settingsBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ScreenTest UI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.settingsBox.ResumeLayout(false);
            this.settingsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spectrumCyclingSpeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox settingsBox;
        private System.Windows.Forms.RadioButton modeSpectrumCycling;
        private System.Windows.Forms.RadioButton modeScreen;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.RadioButton modeSolidColor;
        private System.Windows.Forms.NumericUpDown spectrumCyclingSpeed;
        private System.Windows.Forms.Button hideButton;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button killButton;
        private System.Windows.Forms.Button colorSelectOpen;
    }
}

