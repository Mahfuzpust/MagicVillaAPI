﻿namespace MagicVilla_villaAPI.Logging
{
    public interface ILogging
    {
        public void Log(string message, string type);
        void Log(string v);
    }
}
