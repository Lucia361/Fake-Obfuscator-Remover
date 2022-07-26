using System;

namespace Fake_Obf_Remover
{
    internal static class Logger
    {
        public enum Type
        {
            Info,
            Debug,
            Error,
            Success
        }

        public static void Write(string message, Type type = Type.Info)
        {
            switch (type)
            {
                case Type.Info:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine($"[INFO] {message}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                case Type.Debug:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"[DEBUG] {message}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                case Type.Error:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"[ERROR] {message}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                case Type.Success:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"[SUCCESS] {message}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }

        public static void Leave()
        {
            Console.WriteLine();
            Console.WriteLine("Press enter to leave...");
            Console.ReadLine();
            Environment.Exit(0);
        }

        public static void WriteTitle()
        {
            Console.SetWindowPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"  sSSs   .S_SSSs     .S    S.     sSSs          sSSs_sSSs     .S_SSSs      sSSs   .S       S.     sSSs    sSSs   .S_SSSs    sdSS_SSSSSSbs    sSSs_sSSs     .S_sSSs    ");
            Console.WriteLine(@" d%%SP  .SS~SSSSS   .SS    SS.   d%%SP         d%%SP~YS%%b   .SS~SSSSS    d%%SP  .SS       SS.   d%%SP   d%%SP  .SS~SSSSS   YSSS~S%SSSSSP   d%%SP~YS%%b   .SS~YS%%b   ");
            Console.WriteLine(@"d%S'    S%S   SSSS  S%S    S&S  d%S'          d%S'     `S%b  S%S   SSSS  d%S'    S%S       S%S  d%S'    d%S'    S%S   SSSS       S%S       d%S'     `S%b  S%S   `S%b  ");
            Console.WriteLine(@"S%S     S%S    S%S  S%S    d*S  S%S           S%S       S%S  S%S    S%S  S%S     S%S       S%S  S%|     S%S     S%S    S%S       S%S       S%S       S%S  S%S    S%S  ");
            Console.WriteLine(@"S&S     S%S SSSS%S  S&S   .S*S  S&S           S&S       S&S  S%S SSSS%P  S&S     S&S       S&S  S&S     S&S     S%S SSSS%S       S&S       S&S       S&S  S%S    d*S  ");
            Console.WriteLine(@"S&S_Ss  S&S  SSS%S  S&S_sdSSS   S&S_Ss        S&S       S&S  S&S  SSSY   S&S_Ss  S&S       S&S  Y&Ss    S&S     S&S  SSS%S       S&S       S&S       S&S  S&S   .S*S  ");
            Console.WriteLine(@"S&S~SP  S&S    S&S  S&S~YSSY%b  S&S~SP        S&S       S&S  S&S    S&S  S&S~SP  S&S       S&S  `S&&S   S&S     S&S    S&S       S&S       S&S       S&S  S&S_sdSSS   ");
            Console.WriteLine(@"S&S     S&S    S&S  S&S    `S%  S&S           S&S       S&S  S&S    S&S  S&S     S&S       S&S    `S*S  S&S     S&S    S&S       S&S       S&S       S&S  S&S~YSY%b   ");
            Console.WriteLine(@"S*b     S*S    S&S  S*S     S%  S*b           S*b       d*S  S*S    S&S  S*b     S*b       d*S     l*S  S*b     S*S    S&S       S*S       S*b       d*S  S*S   `S%b  ");
            Console.WriteLine(@"S*S     S*S    S*S  S*S     S&  S*S.          S*S.     .S*S  S*S    S*S  S*S     S*S.     .S*S    .S*P  S*S.    S*S    S*S       S*S       S*S.     .S*S  S*S    S%S  ");
            Console.WriteLine(@"S*S     S*S    S*S  S*S     S&   SSSbs         SSSbs_sdSSS   S*S SSSSP   S*S      SSSbs_sdSSS   sSS*S    SSSbs  S*S    S*S       S*S        SSSbs_sdSSS   S*S    S&S  ");
            Console.WriteLine(@"S*S     SSS    S*S  S*S     SS    YSSP          YSSP~YSSY    S*S  SSY    S*S       YSSP~YSSY    YSS'      YSSP  SSS    S*S       S*S         YSSP~YSSY    S*S    SSS  ");
            Console.WriteLine(@"SP             SP   SP                                       SP          SP                                            SP        SP                       SP          ");
            Console.WriteLine(@"Y              Y    Y                                        Y           Y                                             Y         Y                        Y           ");
            Console.WriteLine(@"Discord:https://discord.gg/QGwgPRxfER");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetWindowSize(165, 40); 
            //el primero es de izquierda a derecha y el segundo es de arriba abajo (anchura y altura)
        }
    }
}