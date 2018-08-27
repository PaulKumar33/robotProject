//L293D
//Motor A
const int motorPin1  = 5;  // Pin 14 of L293
const int motorPin2  = 6;  // Pin 10 of L293
//Motor B
const int motorPin3  = 10; // Pin  7 of L293
const int motorPin4  = 9;  // Pin  2 of L293

//This will run only one time.

void Forward(){
  digitalWrite(motorPin1, HIGH)
  digitalWrite(motorPin2, LOW)
  digitalWrite(motorPin3, HIGH)
  digitalWrite(motorPin4, LOW)
}

void Reverse(){
  digitalWrite(motorPin1, LOW)
  digitalWrite(motorPin2, HIGH)
  digitalWrite(motorPin3, LOW)
  digitalWrite(motorPin4, HIGH)
}

void StopMotor(){
  digitalWrite(motorPin1, LOW)
  digitalWrite(motorPin2, LOW)
  digitalWrite(motorPin3, LOW)
  digitalWrite(motorPin4, LOW)
}


void setup(){
 
    //Set pins as outputs
    pinMode(motorPin1, OUTPUT);
    pinMode(motorPin2, OUTPUT);
    pinMode(motorPin3, OUTPUT);
    pinMode(motorPin4, OUTPUT);
}


void loop(){
  

}
