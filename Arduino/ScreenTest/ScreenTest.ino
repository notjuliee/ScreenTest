int r, g, b;
int RedPin = 9;
int GreenPin = 10;
int BluePin = 11;
void setup()
{
  Serial.begin(9600);
  int r = 0;
  int g = 0;
  int b = 0;
}

void loop()
{
  if (Serial.available()>=4) {
    if(Serial.read() == 0xff){
      r = 255 - Serial.read();
      g = 255 - Serial.read();
      b = 255 - Serial.read();
    }
  }
  r = constrain(r,0,255);
  g = constrain(g,0,255);
  b = constrain(b,0,255);
  analogWrite(RedPin, r);
  analogWrite(GreenPin, g);
  analogWrite(BluePin, b);
  delay(10);
}

