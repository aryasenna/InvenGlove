/*
  Flexion.cpp
  V1.3
  Library for reading flex sensor readings and parsing them into finger flexion state (Open, Half Open, Closed).
  One of the sensor is embedded on Thumb, while the latter is embedded on Index finger. 
  Created by  Arya Senna, Last updated on 14 Dec 2013
  Licensed under MIT License
  --
  Part of Capstone Project - Mechanical Engineering Department of Universitas Indonesia
*/
#include "Arduino.h"
#include "Flexion.h"
#include <EEPROM.h>
//CONFIGURATION

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
#define PIN_INDEX 0
#define PIN_THUMB 1
//#define VERBOSE_STATE

//SCALING
//#define USE_SCALING
#define SCALINGMIN 400
#define SCALINGMAX 600

//Calibration Voltage
#define CALIB_VOLT 3.3

Flexion::Flexion()

{

}



//This function will read a 2 byte integer from the eeprom at the specified address and address + 1
int Flexion::ReadCal(int _address)
{

  return  word( EEPROM.read(_address),EEPROM.read(_address + 1));
}

//This function will write a 2 byte integer to the eeprom at the specified address and address + 1
void Flexion::WriteCal(int _address, int _value)
{
 
  EEPROM.write(_address, highByte(_value));
  EEPROM.write(_address + 1, lowByte(_value));
}



//create new object
Flexion Flex;
 


//Flex sensor calibration
//Read from EEPROM
///Open 
unsigned int thresholdIndexMinOpen = Flex.ReadCal(addrIndexMinOpen);
unsigned int thresholdIndexMaxOpen = Flex.ReadCal(addrIndexMaxOpen);
unsigned int thresholdThumbMinOpen = Flex.ReadCal(addrThumbMinOpen);
unsigned int thresholdThumbMaxOpen  = Flex.ReadCal(addrThumbMaxOpen);

//Half-open 
unsigned int thresholdIndexMinHalf = Flex.ReadCal(addrIndexMinHalf); 
unsigned int thresholdIndexMaxHalf = Flex.ReadCal(addrIndexMaxHalf);
unsigned int thresholdThumbMinHalf = Flex.ReadCal(addrThumbMinHalf);
unsigned int thresholdThumbMaxHalf = Flex.ReadCal(addrThumbMaxHalf);

//Closed
unsigned int thresholdIndexMinClosed =Flex.ReadCal(addrIndexMinClosed);
unsigned int thresholdIndexMaxClosed =Flex.ReadCal(addrIndexMaxClosed);
unsigned int thresholdThumbMinClosed =Flex.ReadCal(addrThumbMinClosed);
unsigned int thresholdThumbMaxClosed =Flex.ReadCal(addrThumbMaxClosed);

//Twist
unsigned int thresholdIndexMinTwist =Flex.ReadCal(addrIndexMinTwist);
unsigned int thresholdIndexMaxTwist =Flex.ReadCal(addrIndexMaxTwist);
unsigned int thresholdThumbMinTwist =Flex.ReadCal(addrThumbMinTwist);
unsigned int thresholdThumbMaxTwist =Flex.ReadCal(addrThumbMaxTwist);



//Internal precision voltage
long Flexion::readVcc() {
  long result;
  // Read 1.1V reference against AVcc
  ADMUX = _BV(REFS0) | _BV(MUX3) | _BV(MUX2) | _BV(MUX1);
  delay(2); // Wait for Vref to settle
  ADCSRA |= _BV(ADSC); // Convert
  while (bit_is_set(ADCSRA,ADSC));
  result = ADCL;
  result |= ADCH<<8;
  result = 1125300L / result; // Back-calculate AVcc in mV
  return result;
}


unsigned int analogPrecisionRead(unsigned int pin) {
unsigned int ADCValue;
unsigned int result;
double Vcc;

Vcc = Flex.readVcc()/1000.0;
ADCValue = analogRead(pin);
result = (ADCValue * Vcc) / CALIB_VOLT;

return result;

 }

 
 
 


char Flexion::getState() {
//Flex nominal reading
//index
#ifndef USE_SCALING
_indexReading = analogPrecisionRead(PIN_INDEX);
#endif
#ifdef USE_SCALING
_indexReading = map(analogPrecisionRead(PIN_INDEX), SCALINGMIN, SCALINGMAX, 0, 100);
#endif
indexReading = _indexReading;


//thumb
#ifndef USE_SCALING
_thumbReading = analogPrecisionRead(PIN_THUMB);
#endif
#ifdef USE_SCALING
_thumbReading = map(analogPrecisionRead(PIN_THUMB), SCALINGMIN, SCALINGMAX, 0, 100);
#endif
thumbReading = _thumbReading;

//Open//Open
if ((_indexReading > thresholdIndexMinOpen) &&  (_indexReading < thresholdIndexMaxOpen) && (_thumbReading > thresholdThumbMinOpen) && (_thumbReading < thresholdThumbMaxOpen)) {
_isOpen = true;
isOpen = _isOpen;
return 'o';


}

//Half-open

else if ((_indexReading > thresholdIndexMinHalf) &&  (_indexReading < thresholdIndexMaxHalf) && (_thumbReading > thresholdThumbMinHalf) && (_thumbReading < thresholdThumbMaxHalf)) {

_isHalf = true;
isHalf = _isHalf;
return 'h'; 

}

//Closed

else if ((_indexReading > thresholdIndexMinClosed) &&  (_indexReading < thresholdIndexMaxClosed) && (_thumbReading > thresholdThumbMinClosed) && (_thumbReading < thresholdThumbMaxClosed)) {

_isClosed = true; 
isTwist = _isTwist;
return 'c';
}

//Twist

else if ((_indexReading > thresholdIndexMinTwist) &&  (_indexReading < thresholdIndexMaxTwist) && (_thumbReading > thresholdThumbMinTwist) && (_thumbReading < thresholdThumbMaxTwist)) {

_isTwist = true; 
isClosed = _isTwist;
return 't';
}


else {


return 'u';


}



}


