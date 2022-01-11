#include <Servo.h>
/*------Brazo Chico---------------------------------------------------*/
Servo base;    // Rotacioón de el conjunto
Servo brazo1;  // Rotación del primer brazo
Servo brazo2;  // Rotación segundo brazo
Servo pinza;   // Pinza
/*------Brazo Grande--------------------------------------------------*/
Servo base1;
Servo brazo;
Servo antebrazo;
Servo rotacion;
int ventosa = 12;
int led = 13;
//int pos_bas=90,pos_br1=90,pos_br2=90,pos_pin=90;
 void setup()
 {
   Serial.begin(9600);
   /*--------------------brazo chico   --------------------------------*/
   base.attach(2);
   brazo1.attach(3);
   brazo2.attach(4);
   pinza.attach(5);
   /*------Brazo Grande--------------------------------------------------*/
   pinMode(ventosa,INPUT);
   pinMode(led,OUTPUT);
   base1.attach(11);
   brazo.attach(10);
   antebrazo.attach(9);
   rotacion.attach(8);
   /*--------------------brazo chico    -------------------------------*/
   base.write(90);  
   brazo1.write(90);
   brazo2.write(90);
   pinza.write(90);
   /*------Brazo Grande--------------------------------------------------*/
   base1.write(90);
   brazo.write(90);
   antebrazo.write(90);
   rotacion.write(90);
   pinMode(ventosa,INPUT);
   pinMode(led,OUTPUT);
}
int i=0;
void loop()
{
   if(Serial.available())// si el serial esta habilitado
  {
    int c=Serial.read();
   /*---------------------posicion origen brazo chico  --------------------*/
   if (c=='r')
  {
    pinza.write(100);
    base.write(90);
    brazo1.write(90);
    brazo2.write(90);
    pinza.write(100);
    delay(1000);
    base.write(30);
    brazo1.write(20);
    delay(1000);
    brazo2.write(110);
    delay(500);
    brazo1.write(15);
    brazo2.write(130);
    delay(500);
    brazo1.write(20);
    brazo2.write(130);
    delay(500);
    brazo1.write(22);
    brazo2.write(130);
    delay(500);
    brazo1.write(24);
    brazo2.write(130);
    delay(500);
    brazo1.write(26);
    brazo2.write(130);
    pinza.write(70);
    delay(500);
    brazo1.write(30);
    brazo2.write(120);
    delay(500);
    brazo1.write(45);
    brazo2.write(110);
    delay(500);
    brazo1.write(90);
    brazo2.write(90);
  }
  /*---------------------primera posicion brazo chico   --------------------*/
  if (c=='a')
  {
    base.write(160);
    delay(1000);
    brazo1.write(90);
    brazo2.write(180);
    delay(500);
    pinza.write(100);
    brazo1.write(60);
    delay(500);
    brazo2.write(90);
    delay(500);
  }
  /*---------------------Segudna posicion brazo chico   --------------------*/
  if (c=='b')
  {
    base.write(120);
    delay(1000);
    brazo1.write(50);
    brazo2.write(140);
    delay(500);
    pinza.write(100);
    brazo1.write(30);
    delay(500);
    brazo2.write(90);
    delay(500);
  }
  /*---------------------tercera posicion brazo chico   --------------------*/
  if (c=='c')
  {
    base.write(90);
    delay(1000);
    brazo1.write(80);
    brazo2.write(160);
    delay(500);
    pinza.write(100);
    brazo1.write(60);
    delay(500);
    brazo2.write(90);
    delay(500);
  }
  /*---------------------cuarta posicion brazo chico   --------------------*/
  if (c=='d')
  {
    base.write(180);
    delay(1000);
    brazo1.write(50);
    brazo2.write(140);
    delay(500);
    pinza.write(100);
    brazo1.write(20);
    delay(500);
    brazo2.write(90);
    delay(500);
  }
  /*---------------------quinta posicion brazo chico   --------------------*/
  if (c=='e')
  {
    base.write(120);
//    delay(500);
    brazo1.write(20);
    brazo2.write(115);
    delay(500);
    pinza.write(100);
    brazo1.write(10);
    delay(500);
    brazo2.write(90);
    delay(500);
  }
  /*---------------------posicion origen brazo grande   --------------------*/
  if (c=='R')
  {
      base1.write(24);
      brazo.write(65);
      antebrazo.write(155);
      i=0;
      delay(1000);
      do
      {
        i++;
        brazo.write(65-i);
        antebrazo.write(155+i);
        delay(500);
      }
      while (digitalRead(ventosa)!=HIGH);
      brazo.write(75);
      antebrazo.write(155);
  }
  }
}