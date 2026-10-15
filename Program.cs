using CommandPattern.Classes;
using CommandPattern.Classes.Commands;
using CommandPattern.Interfaces;

namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();

            /* Define and instantiate the following Vendor classes
             * Kitchen Light : Light
             * Livingroom Light : Light
             * Livingroom ceiling fan : CeilingFan
             * Garage door: Garagedoor
             * Stereo : Stereo
             */
            Light kitchenLight = new Light("Kitchen");
            Light livingRoomLight = new Light("Living Room");
            CeilingFan livingRoomCeilingFan = new CeilingFan("Living Room");
            GarageDoor garageDoor = new GarageDoor(kitchenLight);
            Stereo stereo = new Stereo();

            // Define and instantiate an Off and On command for each Vendor class

            /* Set the On and Off commands to the appropriate slot:
             * 
             * 1: Living Room light
             * 2: Kitchen light
             * 3: Livingroom ceiling fan
             * 4: Garage door
             * 5: Stereo
             */

            Command livingroomLightOn = new LightOnCommand(livingRoomLight);
            Command livingroomLightOff = new LightOffCommand(livingRoomLight);

            Command kitchenLightOn = new LightOnCommand(kitchenLight);
            Command kitchenLightOff = new LightOffCommand(kitchenLight);

            Command livingroomCeilingFanHigh = new CeilingFanHighCommand(livingRoomCeilingFan);
            Command livingroomCeilingFanMedium = new CeilingFanMediumCommand(livingRoomCeilingFan);
            Command livingroomCeilingFanLow = new CeilingFanLowCommand(livingRoomCeilingFan);
            Command livingroomCeilingFanOff = new CeilingFanOffCommand(livingRoomCeilingFan);

            Command garageDoorUp = new GarageDoorUpCommand(garageDoor);
            Command garageDoorDown = new GarageDoorDownCommand(garageDoor);

            Command stereoOnWithCd = new StereoOnWithCdCommand(stereo);
            Command stereoOffWithCd = new StereoOffCommand(stereo);
            Command stereoOnWithDvd = new StereoOnWithDvdCommand(stereo);
            Command stereoOffWithDvd = new StereoOffCommand(stereo);
            Command stereoOnWithRadio = new StereoOnWithRadioCommand(stereo);
            Command stereoOffWithRadio = new StereoOffCommand(stereo);


            Console.WriteLine(remoteControl);

            // Test the pressing of Buttons here. Don't forget to test the Undo button


        }
    }
}