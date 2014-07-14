/*
  Flexion.h
  Library for reading flex sensor readings and parsing them into finger flexion state (Open, Half Open, Closed).
  One sensor embedded on thumb, and the latter is embedded on Index finger. 
  Created by  Arya Senna, Finalised on 14 Dec 2013
  Licensed under MIT License
  --
  Part of Capstone Project - Mechanical Engineering Department of Universitas Indonesia
*/

#ifndef Flexion_h
#define Flexion_h

#include "Arduino.h"
#include <EEPROM.h>
class Flexion
{
  public:
    Flexion();
    int indexReading;
	int thumbReading;
	char getState();
	bool isOpen;
	bool isHalf;
	bool isClosed;
	bool isTwist;
	int ReadCal(int _address);
	void WriteCal(int _address, int _value);
	long readVcc();
   
   

  private:
	int _indexReading;
	int _thumbReading;
	bool _isOpen;
	bool _isHalf;
	bool _isClosed;
	bool _isTwist;
	
};

#endif

