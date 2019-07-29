﻿using CsvHelper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Linq;

namespace WMICollector
{
    class Program
    {
       

        static void Main(string[] args)
        {
            var plService = new PerformanceLoggingService();

            plService.ConsoleStart(args);

        }

        
    }
}
