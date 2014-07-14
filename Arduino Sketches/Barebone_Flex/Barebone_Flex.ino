/*
  InvenGlove Flex Reading Barebone.ino
  
  Arduino sketches for "InvenGlove" wireless data glove, a wearable virtual assembling tools.
  InvenGlove Add-in for Autodesk Inventor is required.
  
  
  Jun 2014
  V0.1
  Licensed under GNU GPL License v3
  --
  Part of Joint Capstone Project - Mechanical Engineering Department of Universitas Indonesia
  Arya Senna and Albert Koto
  
 
*/

#include <Flexion.h>
#include <EEPROM.h>
//Configuration
#define DELIMETER ","


//Class Init.
Flexion flex;

//method, void and functions

void setup() {
Serial.begin(57600);
Serial.println("InvenGlove Calibration");



}

void loop() {
  
Serial.print(flex.getState());
Serial.print(DELIMETER);
Serial.print("V");
Serial.print(DELIMETER);
Serial.print(flex.indexReading);
Serial.print(DELIMETER);
Serial.println(flex.thumbReading);



  

}
