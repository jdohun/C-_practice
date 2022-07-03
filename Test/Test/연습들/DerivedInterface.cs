using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace Interface {

    interface ILogger {
        void WriteLog( string message );
    }

    interface IFormattableLogger : ILogger {
        void WriteLog( string format, params Object[] args );
    }

    class ConsoleLogger2 : IFormattableLogger {
        public void WriteLog( string message ) {
            WriteLine("{0}, {1}", DateTime.Now.ToLocalTime(), message);
        }

        public void WriteLog( string format, params Object[] args ) {
            String message = String.Format(format, args);
            WriteLine("{0}, {1}", DateTime.Now.ToLocalTime(), message);
        }
    }

    /*class ConsoleLogger : ILogger {
        public void WriteLog(string message ) {
            WriteLine("{0}, {1}", DateTime.Now.ToLocalTime(), message);
        }
    }*/

    class FileLogger : ILogger {
        public FileLogger(string path ) {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }
        
        private StreamWriter writer;
        
        public void WriteLog( string message ) {
            WriteLine("{0}, {1}", DateTime.Now.ToShortTimeString(), message);
        }
    }

    class ClimateMonitor {
        public ClimateMonitor(ILogger logger ) {
            this.logger = logger;
        }

        private ILogger logger;

        public void start() {
            while (true) {
                WriteLine("온도를 입력해주세요.: ");
                string temperature = Console.ReadLine();
                if (temperature == "")
                    break;

                logger.WriteLog("현재 온도 : " + temperature);
            }
        }
    }

    class MainApp {
        static void Main(string[] args ) {
            IFormattableLogger logger = new ConsoleLogger2();
            logger.WriteLog("The world is not flat");
            logger.WriteLog("{0} + {1} = {2}", 1, 1, 2);
            /*ClimateMonitor monitor = new ClimateMonitor(new FileLogger("MyLog.txt"));
            monitor.start();*/
        }
    }
}