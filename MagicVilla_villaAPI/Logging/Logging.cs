﻿namespace MagicVilla_villaAPI.Logging
{
    public class Logging : ILogging
    {
        public void Log(string message, string type)
        {
            if(type == "error")
            {
                Console.WriteLine("ERROR : " + message);
            }
            else
            {
                Console.WriteLine(message);
            }
        }

        public void Log(string v)
        {
            throw new NotImplementedException();
        }
    }
}
