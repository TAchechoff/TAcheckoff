# TAcheckoff
Final project
  The project is building a system that inform TAs when students want help or need a check off  by ceating a queue on the TAs' computer.
On the student station side, there is Raspberry pi and sonar sensor which is connected to raspberry Pi and a C# code the TA side that recieve station number and display it on the console.

  The C# code listens, creates socket connection, gets the station number and displays on the console.
  
  On the Raspberry Pi side which is on student, there is a Python code which does two things together. The first one is a driver for the sonar sensor which is connected to GPIO of Raspberry Pi. The second part is a socket connection which is stablished when the hand position is between 2 to 10 cm.
 
 ===========================================
  Circuit connection of sonar sensor with PI
============================================  
 Raspberry PI	    |           CH-SR04       
===========================================
PIN 18	          |           TRIG
__________________________________________
PIN 24	          |           ECHO
_________________________________________
3.3V	            |            V+
 ________________________________________
GND	              |            GND
_________________________________________

  
  


