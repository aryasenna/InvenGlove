/* $Id$
||
|| @file 		       Button.cpp
|| @author 		     Alexander Brevig              <alexanderbrevig@gmail.com>        
|| @url            http://alexanderbrevig.com
||
|| @description
|| | This is a Hardware Abstraction Library for Buttons
|| | It provides an easy way of handling buttons
|| #
||
|| @license LICENSE_REPLACE
||
*/

#include <Arduino.h>
#include "Button.h"

#define CURRENT 0
#define PREVIOUS 1
#define CHANGED 2

/*
|| @constructor
|| | Set the initial state of this button
|| #
|| 
|| @parameter buttonPin  sets the pin that this switch is connected to
|| @parameter buttonMode indicates BUTTON_PULLUP or BUTTON_PULLDOWN resistor
*/
Button::Button(uint8_t buttonPin, uint8_t buttonMode){
	pin=buttonPin;
  pinMode(pin,INPUT);
  
	buttonMode==BUTTON_PULLDOWN ? pulldown() : pullup(buttonMode);
  state = 0;
  bitWrite(state,CURRENT,!mode);
  
  cb_onPress = 0;
  cb_onRelease = 0;
  cb_onClick = 0;
  cb_onHold = 0;
  
  numberOfPresses = 0;
  triggeredHoldEvent = true;
}

/*
|| @description
|| | Prepare logic for a pullup button.
|| | If mode is internal set pin HIGH as default
|| #
*/
void Button::pullup(uint8_t buttonMode)
{
	mode=BUTTON_PULLUP;
  if (buttonMode == BUTTON_PULLUP_INTERNAL) 
  {
	  digitalWrite(pin,HIGH);
  }
}

/*
|| @description
|| | Set pin LOW as default
|| #
*/
void Button::pulldown(void)
{
	mode=BUTTON_PULLDOWN;
}

/*
|| @description
|| | Return the bitRead(state,CURRENT) of the switch
|| #
|| 
|| @return true if button is pressed
*/
bool Button::isPressed(void)
{  
  //save the previous value
  bitWrite(state,PREVIOUS,bitRead(state,CURRENT));
  
  //get the current status of the pin
  if (digitalRead(pin) == mode)
  {
    //currently the button is not pressed
    bitWrite(state,CURRENT,false);
  } 
  else 
  {
    //currently the button is pressed
    bitWrite(state,CURRENT,true);
  }
  
  //handle state changes
  if (bitRead(state,CURRENT) != bitRead(state,PREVIOUS))
  {
    //the state changed to PRESSED
    if (bitRead(state,CURRENT) == true) 
    {
      numberOfPresses++;
      if (cb_onPress) { cb_onPress(*this); }   //fire the onPress event
      pressedStartTime = millis();             //start timing
      triggeredHoldEvent = false;
    } 
    else //the state changed to RELEASED
    {
      if (cb_onRelease) { cb_onRelease(*this); } //fire the onRelease event
      if (cb_onClick) { cb_onClick(*this); }   //fire the onClick event AFTER the onRelease
      //reset states (for timing and for event triggering)
      pressedStartTime = -1;
    }
    //note that the state changed
    bitWrite(state,CHANGED,true);
  }
  else
  {
    //note that the state did not change
    bitWrite(state,CHANGED,false);
    //should we trigger a onHold event?
    if (pressedStartTime!=-1 && !triggeredHoldEvent) 
    {
      if (millis()-pressedStartTime > holdEventThreshold) 
      { 
        if (cb_onHold) 
        { 
          cb_onHold(*this); 
          triggeredHoldEvent = true;
        }
      }
    }
  }
	return bitRead(state,CURRENT);
}
