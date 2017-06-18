using ek.Commands;

namespace ek.Factory
{
    public class SamplesCommandFactory
    {
        public static ISamplesCommand Get(string commandName)
        {
            switch (commandName)
            {
                case "base": return new BaseSample();
                case "service": return new ServiceSample();
                case "webapp": return new WebAppSample();
                default:
                    return new CommandNotRecognized("samples " + commandName);
            }
        }
    }
}
