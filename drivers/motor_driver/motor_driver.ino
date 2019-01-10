//L293D
//Motor A
const int motorPin1  = 52;  // Pin 14 of L293
const int motorPin2  = 50;  // Pin 10 of L293
//Motor B
const int motorPin3  = 51; // Pin  7 of L293
const int motorPin4  = 53;  // Pin  2 of L293

const int ultraEcho = 27;
const int ultraSense = 29;
const int ultraEchoR = 26;
const int ultraSenseR = 28;

const int detectLed = 22;

float distance1;
float distance2;
bool forward;


//This will run only one time.
float SendPulse(int loc){
  /*
   * sends a pulse to the specified sensor
   * 1: forward sensor
   * 2: reverse sensor
   */
  if(loc == 1){
    digitalWrite(ultraSense, LOW);
    delayMicroseconds(2);
    
    digitalWrite(ultraSense, HIGH);
    delayMicroseconds(10);
    digitalWrite(ultraSense, LOW);
    
    float pulse = pulseIn(ultraEcho, HIGH);
    pulse = pulse*0.034/2;
    return pulse;
  }

  else if(loc ==2){
    digitalWrite(ultraSenseR, LOW);
    delayMicroseconds(2);
    
    digitalWrite(ultraSenseR, HIGH);
    delayMicroseconds(10);
    digitalWrite(ultraSenseR, LOW);
    
    float pulse = pulseIn(ultraEchoR, HIGH);
    pulse = pulse*0.034/2;
    return pulse;
  }
}


void Forward(){
  digitalWrite(motorPin1, HIGH);
  digitalWrite(motorPin2, LOW);
  digitalWrite(motorPin3, HIGH);
  digitalWrite(motorPin4, LOW);
}

void Reverse(){
  digitalWrite(motorPin1, LOW);
  digitalWrite(motorPin2, HIGH);
  digitalWrite(motorPin3, LOW);
  digitalWrite(motorPin4, HIGH);
}

void StopMotor(){
  digitalWrite(motorPin1, LOW);
  digitalWrite(motorPin2, LOW);
  digitalWrite(motorPin3, LOW);
  digitalWrite(motorPin4, LOW);
}

void ActivateLED(){
  digitalWrite(detectLed, HIGH);
}

void DeactivateLED(){
  digitalWrite(detectLed, LOW);
}

bool CheckObject(float distance){
  
}


void setup(){
    Serial.begin(9600);
    
    //Set pins as outputs
    pinMode(motorPin1, OUTPUT);
    pinMode(motorPin2, OUTPUT);
    pinMode(motorPin3, OUTPUT);
    pinMode(motorPin4, OUTPUT);

    //set the ultrasound pins
    pinMode(ultraEcho, INPUT);
    pinMode(ultraSense, OUTPUT);

    pinMode(ultraEchoR, INPUT);
    pinMode(ultraSenseR, OUTPUT);

    pinMode(detectLed, OUTPUT);

    forward = true;
}


void loop(){
  if(forward){
    Forward();
    distance1 = SendPulse(1);
    Serial.println(distance1);
    if(distance1 <= 15.0){
      Serial.println("Reversing");
      forward = false;      
      StopMotor();
      ActivateLED();
      delay(2000);
      DeactivateLED();
    }
    
  }
  else if(!forward){
    Reverse();
    //Serial.println("REVERSE");
    distance2 = SendPulse(2);
    Serial.println(distance2);
    if(distance2 <= 15.00){
      forward = true;
      Serial.println("Going forward");
      StopMotor();
      ActivateLED();
      delay(2000);
      DeactivateLED();
    }
  }
  

}

