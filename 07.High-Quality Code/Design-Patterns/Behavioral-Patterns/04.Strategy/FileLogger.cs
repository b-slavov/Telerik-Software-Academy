﻿namespace Strategy
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class FileLogger : ILogger
    {
        private readonly string filePath;

        public FileLogger(string filePath)
        {
            this.filePath = filePath;
        }

        public void Log(string message)
        {
            File.AppendAllLines(this.filePath, new List<string> { $"[{DateTime.Now}] {message}" });
        }
    }
}
