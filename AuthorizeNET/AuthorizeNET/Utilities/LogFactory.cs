namespace AuthorizeNet.Utilities
{
    using System;
    using System.Collections.Generic;
    using Microsoft.Extensions.Logging;

    public static class LogFactory
    {
        private static ILoggerFactory LoggerFactory => new LoggerFactory();

        public static ILogger getLog(Type classType)
        {
            return LoggerFactory.CreateLogger(classType.FullName);
        }
    }
}