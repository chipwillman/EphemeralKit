using System;

namespace ek.Extensions
{
    internal class DataContractJsonSerializer
    {
        private Type type;

        public DataContractJsonSerializer(Type type)
        {
            this.type = type;
        }
    }
}