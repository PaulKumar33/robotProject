int motor1 = 47;
int motor2 = 49;
int motor3 = 51;
int motor4 = 53;
bool motorStatus;

int delayTime = 50;
void setup() {
  // put your setup code here, to run once:
  pinMode(motor1, OUTPUT);
  pinMode(motor2, OUTPUT);
  pinMode(motor3, OUTPUT);
  pinMode(motor4, OUTPUT);

  motorStatus = true;

}

void TurnMotor(int iterations){
  for(int i =0; i<=iterations; i++){
    digitalWrite(motor4, HIGH);
    digitalWrite(motor3, LOW);
    digitalWrite(motor2, LOW);
    digitalWrite(motor1, LOW);
    delay(50);
    digitalWrite(motor4, LOW);
    digitalWrite(motor3, HIGH);
    digitalWrite(motor2, LOW);
    digitalWrite(motor1, LOW);
    delay(50);
    digitalWrite(motor4, LOW);
    digitalWrite(motor3, LOW);
    digitalWrite(motor2, HIGH);
    digitalWrite(motor1, LOW);
    delay(50);
    digitalWrite(motor4, LOW);
    digitalWrite(motor3, LOW);
    digitalWrite(motor2, LOW);
    digitalWrite(motor1, HIGH);
    delay(50);
  }
}

void loop() {
  if(motorStatus){
    TurnMotor(16);
    motorStatus = false;
  }
}
