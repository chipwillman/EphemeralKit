using System;
using ek.Model;

namespace ek.Commands
{
    public class CommandNotRecognized : ISamplesCommand
    {
        public CommandNotRecognized(string message)
        {
            this.Message = message;
        }

        public string Message { get; set; }

        public int Execute(SamplesOptions options)
        {
            Console.WriteLine(Message);
            return 1;
        }
    }
}
