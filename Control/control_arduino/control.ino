int temp1=32;
int temp2=35;
int hum1=60;
int hum2=75;
int f1=0;
int f2=1;
int b1=25;
int b2=100;

void setup() {
  pinMode(13, OUTPUT);
  Serial.begin(9600);
}

void loop() {
  if (Serial.available()>0){
    int dato = Serial.read();
    if (dato==49){
      temp1 += 1;
      hum1 += 2;
    }
    if (dato==50){
      temp2 += 3;
      hum2 += 1;
    }
  }  
  Serial.print(temp1);
  Serial.print("*");
  Serial.print(hum1);
  Serial.print("*");
  Serial.print(temp2);
  Serial.print("*");
  Serial.print(hum2);
  Serial.print("*");
  Serial.print(f1);
  Serial.print("*");
  Serial.print(f2);
  Serial.print("*");
  Serial.print(b1);
  Serial.print("*");
  Serial.println(b2);

  
  digitalWrite(13, HIGH);
  delay(250);
  digitalWrite(13, LOW);
  delay(250);
}
