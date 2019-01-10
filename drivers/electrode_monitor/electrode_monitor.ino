#include "Servo.h"
const int servopin = 52;
const int pulse_width = 1500;

Servo myservo;

/*void setup() {
  myservo.attach(10);
  myservo.write(0);
  bool res = myservo.attached();
  Serial.begin(9600);
  Serial.println(res);
}

void loop() {
  bool res = myservo.attached();
  myservo.write(75);

}*/
int servo_digital_pin = 3;

void setup(){
  pinMode(servo_digital_pin, OUTPUT);
  
}

void loop(){
  analogWrite(3, 250);
  
  
}

