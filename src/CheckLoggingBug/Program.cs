// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Hämmer Electronics">
//   Copyright (c) All rights reserved.
// </copyright>
// <summary>
//   The main program for the application.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CheckLoggingBug
{
    using System;

    using Serilog;
    using Serilog.Debugging;

    /// <summary>
    ///     The main program for the application.
    /// </summary>
    public static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        public static void Main()
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();

            SelfLog.Enable(Console.WriteLine);
            Log.Warning("whatever contains {}");
        }
    }
}