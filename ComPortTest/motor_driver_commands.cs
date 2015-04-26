/*
 * motor_driver_commands.h
 *
 * Created: 2014-03-28 11:40:14
 *  Author: innocent
 */ 

/*
#ifndef MOTOR_DRIVER_COMMANDS_H_
#define MOTOR_DRIVER_COMMANDS_H_

#define SMARTTECH_MOTOR_DRIVER 1
//#define POLICJA_DRIVER 1

// unsigned char buff[4] = {NAME, COMMAND, 0, VALUE} or  {NAME, COMMAND, HVALUE, LVALUE}

enum EMotorDriverDevicesNames
{
	#ifdef SMARTTECH_MOTOR_DRIVER
		MOTOR_1_CHANNEL_NAME = 3,
	#else
		MOTOR_1_CHANNEL_NAME = 0,
	#endif
	MOTOR_2_CHANNEL_NAME = 1
};
*/


enum EMotorDriverAdditionalDevicesNames
{
	LAMP_CHANNEL_NAME = 10
};

enum EMotorDriverCommands
{
	COMMAND_DEVICE_IDENTIFICATION = 'I',
	COMMAND_MOTOR_MOVE_LEFT = 'L',
	COMMAND_MOTOR_MOVE_RIGHT = 'R',
	COMMAND_MOTOR_ENABLE = 'E',
	COMMAND_MOTOR_PRECISE_STEP_TIME = 'P',
	COMMAND_MOTOR_STEP_TIME = 'T',
	COMMAND_MOTOR_LIMIT_SWITCH_TYPE = 'S',
	COMMAND_MOTOR_SWAP_LIMIT_SWITCH = 'W',
	COMMAND_MOTOR_USE_ACCELERATION = 'A'
};

enum EMotorDriverAdditionalCommands
{
	COMMAND_LAMP_ON_OFF = 'F'
};

enum EMotorDriverCommandsValues
{
	MOTOR_LIMIT_SWITCH_OFF = 0,
	MOTOR_LIMIT_SWITCH_SWITCH = 1,	// active high
	MOTOR_LIMIT_SWITCH_OPTO = 2,	// active low
	LAMP_NAME_ALL = 0,
	LAMP_1_NAME = 1,
	LAMP_2_NAME = 2,
	LAMP_3_NAME = 3,
	LAMP_4_NAME = 4,
	LAMP_5_NAME = 5,
	LAMP_ON_VALUE = 1,
	LAMP_OFF_VALUE = 0
};

/*
#endif /* MOTOR_DRIVER_COMMANDS_H_ */
