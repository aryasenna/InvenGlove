
/*
  InvenGlove.ino
  
  Arduino sketches for "InvenGlove" wireless data glove, a wearable virtual assembling tools.
  InvenGlove Add-in for Autodesk Inventor is required.
  Written by Arya Senna
  Finalised on 26 Jun 2014
  V1.5
  Licensed under GNU GPL License v3
  --
  Part of Joint Capstone Project - Mechanical Engineering Department of Universitas Indonesia
  Arya Senna and Albert Koto
  
  Beta version
*/



#include <Flexion.h>
#include <Button.h>
//MPU9150lib

#include <Wire.h>
#include "I2Cdev.h"
#include "MPU9150Lib.h"
#include "CalLib.h"
#include <dmpKey.h>
#include <dmpmap.h>
#include <inv_mpu.h>    
#include <inv_mpu_dmp_motion_driver.h>
#include <EEPROM.h>



//Configuration
#define PB1 4
#define PB2 3
#define TB 2
#define LRED 9
#define LGREEN 11
#define LBLUE 10


#define DELIMETER ","
#define VERBOSE
#define  DEVICE_TO_USE    0
#define MPU_UPDATE_RATE  (20)
#define MAG_UPDATE_RATE  (10)
#define  MPU_MAG_MIX_GYRO_ONLY          0                   // just use gyro yaw
#define  MPU_MAG_MIX_MAG_ONLY           1                   // just use magnetometer and no gyro yaw
#define  MPU_MAG_MIX_GYRO_AND_MAG       10                  // a good mix value 
#define  MPU_MAG_MIX_GYRO_AND_SOME_MAG  50                  // mainly gyros with a bit of mag correction 
#define MPU_LPF_RATE   100 //low pass filter
#define MPU_ACC_SFR   2 //accel sensitivity
#define  SERIAL_PORT_SPEED  57600


//Class Init.
Flexion flex;
MPU9150Lib MPU;
Button pushB1 = Button(PB1, BUTTON_PULLDOWN);
Button pushB2 = Button(PB2, BUTTON_PULLDOWN);
Button toggleB = Button(TB, BUTTON_PULLDOWN);

//method, void and functions

void setup() {
  pinMode(13, INPUT); 
  Serial.begin(SERIAL_PORT_SPEED);
  Wire.begin();
  MPU.selectDevice(DEVICE_TO_USE);                        // only really necessary if using device 1
  MPU.init(MPU_UPDATE_RATE, MPU_MAG_MIX_GYRO_AND_MAG, MAG_UPDATE_RATE, MPU_LPF_RATE, MPU_ACC_SFR);   // start the MPU

#ifdef VERBOSE
Serial.println("Inventor diagnostic (Verbose) mode");
Serial.println("Empty line indicates MPU is not ready to be used. Please check the connection");
Serial.println("Don't forget to switch the toggle to state T2");
#endif
}


void loop() {
  
  if ( MPU.read() && buttonState(toggleB) == 1 ){ //Prevent race conditiion between flex and IMU reading & use physical toggle button
  MPU.selectDevice(DEVICE_TO_USE);                         // only needed if device has changed since init but good form anyway
  #ifndef VERBOSE
  //push button led control and battery indicator
  if (buttonState(pushB1) == 1 ) { setColor(10,30,0); }
  else if (buttonState(pushB2) == 1 ) {  setColor(0,30,10);}
 
  else if (batteryisLow())  { setColor(0,10,0);}

  else {
 setColor(0,10,0);}
   #endif

   
#ifdef VERBOSE
Serial.print("V");
Serial.print(DELIMETER);
Serial.print(flex.indexReading);
Serial.print(DELIMETER);
Serial.print(flex.thumbReading);
Serial.print(DELIMETER);
#endif

#ifndef VERBOSE
  Serial.print(flex.getState()); 

 Serial.print(DELIMETER);
#endif

  MPU.printAnglesDelta(MPU.m_fusedEulerPose);  
    // print the output of the data fusion
  // Serial.print(DELIMETER);
  //MPU.printVectorDelta(MPU.m_calAccel);  
#ifndef VERBOSE
   Serial.print(DELIMETER);

   MPU.printOrientation(MPU.m_fusedEulerPose);
#endif
  
  
  //button serial output
  Serial.print(DELIMETER);
  Serial.print(buttonState(pushB1));
  Serial.print(DELIMETER);
  
    Serial.print(buttonState(pushB2));
  Serial.print(DELIMETER);
  
    Serial.println(buttonState(toggleB));
 
 

}  else if (buttonState(toggleB) == 0) { setColor(0,0,0); }

}
//RGB

void setColor(unsigned int red, unsigned int green,  unsigned int blue)
{
  analogWrite(LRED, 255 - red); 
  analogWrite(LGREEN, 255- green); 
  analogWrite(LBLUE, 255 -blue);  
}


int buttonState(Button button)
{
  
   if(button.isPressed()) {
	return 1;
  }else{
	return 0;
      
  }
  

}
#ifndef VERBOSE
//battery low check
boolean batteryisLow() {
 
  if (flex.readVcc() < 3390) {return true;  }
}
#endif
