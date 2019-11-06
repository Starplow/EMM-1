int tasterWhite = 13;
int tasterBlue = 12;
int sensorWert = 0;
int tasterWhiteStatus = 0;
int tasterBlueStatus = 0;
int eingang = A0;

void setup()
{
  // Initalize the Serialport
  Serial.begin(9600);

  pinMode(tasterBlue, INPUT); 
  pinMode(tasterWhite, INPUT); 
 
}

void loop()
{


  delay(20);
  tasterBlueStatus=digitalRead(tasterBlue);
  
  if(tasterBlueStatus == HIGH){
    Serial.flush();
    Serial.println("jump");
  }

  
 
  tasterWhiteStatus=digitalRead(tasterWhite);

  if(tasterWhiteStatus == HIGH){
     Serial.flush(); 
     Serial.println("forward");
    
  }
        Serial.println(forward + jump +);
        Array[1|0 -> Jump ja nein , 1|0 Forward, ]
  /*
    sensorWert = analogRead(eingang);
     Serial.flush();
    Serial.println(sensorWert);
     if(sensorWert < 400){    
    */
}


 
