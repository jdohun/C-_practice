using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace DefaultImplementation {
    interface ILogger {
        void WriteLog( string message );

        void WriteError( string error ) {   // 새로운 메소드 추가
            WriteLine($"Error: {error}");
        }
    }

    interface IFormattableLogger : ILogger {
        void WriteLog( string format, params Object[] args );
    }

    class ConsoleLogger : ILogger {
        public void WriteLog( string message ) {
            WriteLine("{0}, {1}", DateTime.Now.ToLocalTime(), message);
        }
    }

    class FileLogger : ILogger {
        public FileLogger( string path ) {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }

        private StreamWriter writer;

        public void WriteLog( string message ) {
            WriteLine("{0}, {1}", DateTime.Now.ToShortTimeString(), message);
        }
    }

    class ClimateMonitor {
        public ClimateMonitor( ILogger logger ) {
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
        static void Main( string[] args ) {
            ILogger logger = new ConsoleLogger();
            logger.WriteLog("System Up");
            logger.WriteError("System Fail");

            ConsoleLogger clogger = new ConsoleLogger();
            clogger.WriteLog("System Up");
            // clogger.WriteError("System Fail"); // 컴파일 에러

        }
    }
}
