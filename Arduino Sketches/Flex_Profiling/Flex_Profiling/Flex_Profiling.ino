#include <EEPROM.h>

/*
  Flex Profiling.ino

  Arduino sketches for "InvenGlove" wireless data glove, a wearable virtual assembling tools.
  Flex calibration (hand profiling) module
  Written by Arya Senna
  Finalised on 16 Jun 2014
  V1.0
  Licensed under GNU GPL License v3
  --
  Part of Joint Capstone Project - Mechanical Engineering Department of Universitas Indonesia
  Arya Senna and Albert Koto

  Beta version for latest prototypes. with buttons and RGB LED
*/

#include <Flexion.h>

#define DELIMETER ","
#define addrIndexMinOpen 100
#define addrIndexMaxOpen 102
#define addrThumbMinOpen 104
#define addrThumbMaxOpen 106
#define addrIndexMinHalf 108
#define addrIndexMaxHalf 110
#define addrThumbMinHalf 112
#define addrThumbMaxHalf 114
#define addrIndexMinClosed 116
#define addrIndexMaxClosed 118
#define addrThumbMinClosed 120
#define addrThumbMaxClosed 122
#define addrIndexMinTwist 124
#define addrIndexMaxTwist 126
#define addrThumbMinTwist 128
#define addrThumbMaxTwist 130


//Default threshold
//Min is Max, Max is min of analog value (10 bit adc)
int thresholdIndexMin = 1024;
int thresholdIndexMax = 0;
int thresholdThumbMin = 1024;
int thresholdThumbMax = 0;



int tolerance = 10;
int thresholdIndexMinCal = 1024;
int thresholdIndexMaxCal = 0;
int thresholdThumbMinCal = 1024;
int thresholdThumbMaxCal = 0;

boolean saved;



//Class Init.
Flexion flex;

void setup()
{

 
  
  
  Serial.begin(57600); //115200 is not reliable for mini pro
  Serial.println();
  Serial.println("InvenGlove Finger Flex Profiling");
  Serial.println("Type 's' to temporarily halt calibration process");
  Serial.println("Type 'r' to reset calibration process");
  Serial.println("Type 'c'/'h'/'o'/'t' to save the calibration result (e.g 'o' = save as open)");
  Serial.println("Typing repeatedly might be needed for Arduino to register your command.");
  


}

void loop()
{

  flex.getState();


  if (!saved) 	{


    boolean changed;

    changed = false;
    if (flex.indexReading < thresholdIndexMin) {
      thresholdIndexMin = flex.indexReading;
      changed = true;
    }
    if (flex.indexReading > thresholdIndexMax) {
      thresholdIndexMax = flex.indexReading;
      changed = true;
    }
    if (flex.thumbReading < thresholdThumbMin) {
      thresholdThumbMin = flex.thumbReading;
      changed = true;
    }
    if (flex.thumbReading > thresholdThumbMax) {
      thresholdThumbMax = flex.thumbReading;
      changed = true;
    }

    //give and take threshold to give room for variations
    if (changed) {


      thresholdIndexMinCal = thresholdIndexMin - tolerance;
      thresholdIndexMaxCal = thresholdIndexMax + tolerance;
      thresholdThumbMinCal = thresholdThumbMin - tolerance;
      thresholdThumbMaxCal = thresholdThumbMax + tolerance;

      Serial.println("-------");
      Serial.print("Min. Index Threshold: "); Serial.print(thresholdIndexMinCal); Serial.println();
      Serial.print("Max. Index Threshold: "); Serial.print(thresholdIndexMaxCal); Serial.println();
      Serial.print("Min. Thumb Threshold: "); Serial.print(thresholdThumbMinCal); Serial.println();
      Serial.print("Max. Thumb Threshold: "); Serial.print(thresholdThumbMaxCal); Serial.println();
      Serial.print("Current Calibration:  "); Serial.println(flex.getState());
    }


    if (Serial.available()) {

      if (Serial.read() == 'r') {                  // reset
        Serial.println("RESET");
        thresholdIndexMin = 1024;
        thresholdIndexMax = 0;
        thresholdThumbMin = 1024;
        thresholdThumbMax = 0;
        delay(50);
        saved = false;
      }

      if (Serial.read() == 's') {                  //save none
        Serial.println("Stopped");
        saved = true;
        delay(100);
      }

      if (Serial.read() == 'o') {                  //save open

        
        Serial.println("Open State SAVED");
        flex.WriteCal(addrIndexMinOpen, thresholdIndexMinCal);
        flex.WriteCal(addrIndexMaxOpen, thresholdIndexMaxCal);
        flex.WriteCal(addrThumbMinOpen, thresholdThumbMinCal);
        flex.WriteCal(addrThumbMaxOpen, thresholdThumbMaxCal);
        saved = true;
        
      }


      if (Serial.read() == 'h') {                  //save half
        Serial.println("Half State SAVED");
        flex.WriteCal(addrIndexMinHalf, thresholdIndexMinCal);
        flex.WriteCal(addrIndexMaxHalf, thresholdIndexMaxCal);
        flex.WriteCal(addrThumbMinHalf, thresholdThumbMinCal);
        flex.WriteCal(addrThumbMaxHalf, thresholdThumbMaxCal);
        saved = true;
        
      }

      if (Serial.read() == 'c') {                  //save closed
        Serial.println("Closed state SAVED");
        flex.WriteCal(addrIndexMinClosed, thresholdIndexMinCal);
        flex.WriteCal(addrIndexMaxClosed, thresholdIndexMaxCal);
        flex.WriteCal(addrThumbMinClosed, thresholdThumbMinCal);
        flex.WriteCal(addrThumbMaxClosed, thresholdThumbMaxCal);
        saved = true;
        
      }

      if (Serial.read() == 't') {                  //save twist
        Serial.println("Twist state SAVED");
        flex.WriteCal(addrIndexMinTwist, thresholdIndexMinCal);
        flex.WriteCal(addrIndexMaxTwist, thresholdIndexMaxCal);
        flex.WriteCal(addrThumbMinTwist, thresholdThumbMinCal);
        flex.WriteCal(addrThumbMaxTwist, thresholdThumbMaxCal);
        saved = true;
       
      }

      if (Serial.read() == 'g') {                  //check calibration
        Serial.println("Get Calibration from EEPROM");
        Serial.println("==Open==");
        Serial.print("Min. Index Threshold: "); Serial.print(flex.ReadCal(addrIndexMinOpen)); Serial.println();
        Serial.print("Max. Index Threshold: "); Serial.print(flex.ReadCal(addrIndexMaxOpen)); Serial.println();
        Serial.print("Min. Thumb Threshold: "); Serial.print(flex.ReadCal(addrThumbMinOpen)); Serial.println();
        Serial.print("Max. Thumb Threshold: "); Serial.print(flex.ReadCal(addrThumbMaxOpen)); Serial.println();
        Serial.println();
        Serial.println("==Half==");
        Serial.print("Min. Index Threshold: "); Serial.print(flex.ReadCal(addrIndexMinHalf)); Serial.println();
        Serial.print("Max. Index Threshold: "); Serial.print(flex.ReadCal(addrIndexMaxHalf)); Serial.println();
        Serial.print("Min. Thumb Threshold: "); Serial.print(flex.ReadCal(addrThumbMinHalf)); Serial.println();
        Serial.print("Max. Thumb Threshold: "); Serial.print(flex.ReadCal(addrThumbMaxHalf)); Serial.println();
        Serial.println();
        Serial.println("==Closed==");
        Serial.print("Min. Index Threshold: "); Serial.print(flex.ReadCal(addrIndexMinClosed)); Serial.println();
        Serial.print("Max. Index Threshold: "); Serial.print(flex.ReadCal(addrIndexMaxClosed)); Serial.println();
        Serial.print("Min. Thumb Threshold: "); Serial.print(flex.ReadCal(addrThumbMinClosed)); Serial.println();
        Serial.print("Max. Thumb Threshold: "); Serial.print(flex.ReadCal(addrThumbMaxClosed)); Serial.println();
        Serial.println();
        Serial.println("==Twist==");
        Serial.print("Min. Index Threshold: "); Serial.print(flex.ReadCal(addrIndexMinTwist)); Serial.println();
        Serial.print("Max. Index Threshold: "); Serial.print(flex.ReadCal(addrIndexMaxTwist)); Serial.println();
        Serial.print("Min. Thumb Threshold: "); Serial.print(flex.ReadCal(addrThumbMinTwist)); Serial.println();
        Serial.print("Max. Thumb Threshold: "); Serial.print(flex.ReadCal(addrThumbMaxTwist)); Serial.println();
        Serial.println();
        delay(5000);
      }



    }

  }
}



