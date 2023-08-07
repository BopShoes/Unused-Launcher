using System;
using System.Diagnostics;
using System.Net;
using System.Threading;
using Mono.Web;

namespace UnusedLauncher
{
    internal class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Le Brobro, you might wanna hang yourself.");
                Console.ReadLine();
                return;
            }

            var queryString = HttpUtility.ParseQueryString(args[0].Substring(args[0].IndexOf("?") + 1));
            var client = queryString.Get("Player");
            var ip = queryString.Get("ip");
            var port = queryString.Get("port");
            var id = queryString.Get("playerid");
            var auth = queryString.Get("authcode");
            var place = queryString.Get("placeid");
            var wed = new WebClient();
            var ver = $"http://createserver.xyz/intversion";
            var versioncli = wed.DownloadString(ver);

            if (client == "2010L")
            {
                var web = new WebClient();
                var code = $"http://createserver.xyz/CheckAuthentication.aspx?code={auth}&id={id}";
                var responseString = web.DownloadString(code);
                if (responseString == "1") {
                    var user = $"http://createserver.xyz/CheckUsername.aspx?id={id}";
                    var playername = web.DownloadString(user);
                    ProcessStartInfo processStartInfo = new ProcessStartInfo();
                    processStartInfo.FileName = AppDomain.CurrentDomain.BaseDirectory + $@"2010\Client\{versioncli}\Auto10.exe";
                    processStartInfo.Arguments = $"-script \"wait(); dofile('http://cm3.ct8.pl/Game/join2010.php?username={playername}&server={ip}&port={port}&place={place}')\"";
                    Process.Start(processStartInfo);
                }
                else
                {
                    Console.WriteLine("Invalid Authentication Code.");
                    Thread.Sleep(50000);
                }
            } else
            {
                if(client == "2013L")
                {
                    var web = new WebClient();
                    var code = $"http://createserver.xyz/CheckAuthentication.aspx?code={auth}&id={id}";
                    var responseString = web.DownloadString(code);
                    if (responseString == "1")
                    {
                        var user = $"http://createserver.xyz/CheckUsername.aspx?id={id}";
                        var playername = web.DownloadString(user);
                        ProcessStartInfo processStartInfo = new ProcessStartInfo();
                        processStartInfo.FileName = AppDomain.CurrentDomain.BaseDirectory + $@"2013\Client\{versioncli}\Auto13.exe";
                        processStartInfo.Arguments = $"-a \"http://www.cm3.ct8.pl\" -j \"http://www.cm3.ct8.pl/Game/play.php?port={port}&ip={ip}&user={playername}&id={id}\" -t \"1\"";
                        Process.Start(processStartInfo);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Authentication Code.");
                        Thread.Sleep(50000);
                    }
                }
            }

            /*ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.FileName = AppDomain.CurrentDomain.BaseDirectory + "Auto11.exe";
            processStartInfo.Arguments = $@"-script ""wait(); dofile('http://cm3.ct8.pl/Game/join2011.php?username={playername}&server={ip}&port={port}&place={placeid}')""";
            Process.Start(processStartInfo);
            Console.WriteLine("Auto10 is Starting");*/
        }
        public class VersionInfo
        {
            public string version { get; set; }
        }
    }
}