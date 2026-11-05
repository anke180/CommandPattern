using CommandPattern.Classes.Commands;
using CommandPattern.Interfaces;
using System.Text;

namespace CommandPattern.Classes
{
    internal class RemoteControl
    {
        Command[] onCommands = new Command[7];
        Command[] offCommands = new Command[7];
        Command undoCommand;
        public RemoteControl()
        {
            Command noCommand = new NoCommand();
            for (int i = 0; i < onCommands.Length; i++)
            {
                onCommands[i] = new NoCommand();
                offCommands[i] = new NoCommand();
            }
            undoCommand = noCommand;
        }

        public void SetCommand(int slot, Command onCommand, Command offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            onCommands[slot].Execute();
        }

        public void OffButtonWasPushed(int slot)
        {
            offCommands[slot].Execute();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n----- Remote Control ----- \n");
            for (int i = 0; i < onCommands.Length; i++)
            {
                sb.Append("[slot " + i + "] " + onCommands[i] + " \t\t  " + offCommands[i] + "\n");
            }
            return sb.ToString();
        }
    }
}