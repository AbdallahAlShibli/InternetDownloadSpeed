using System.Diagnostics;
using System.Net;

string ss = @"
                                                                                                                                                                

        ██╗███╗░░██╗████████╗███████╗██████╗░███╗░░██╗███████╗████████╗  ░██████╗██████╗░███████╗███████╗██████╗░
        ██║████╗░██║╚══██╔══╝██╔════╝██╔══██╗████╗░██║██╔════╝╚══██╔══╝  ██╔════╝██╔══██╗██╔════╝██╔════╝██╔══██╗
        ██║██╔██╗██║░░░██║░░░█████╗░░██████╔╝██╔██╗██║█████╗░░░░░██║░░░  ╚█████╗░██████╔╝█████╗░░█████╗░░██║░░██║
        ██║██║╚████║░░░██║░░░██╔══╝░░██╔══██╗██║╚████║██╔══╝░░░░░██║░░░  ░╚═══██╗██╔═══╝░██╔══╝░░██╔══╝░░██║░░██║
        ██║██║░╚███║░░░██║░░░███████╗██║░░██║██║░╚███║███████╗░░░██║░░░  ██████╔╝██║░░░░░███████╗███████╗██████╔╝
        ╚═╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝╚═╝░░╚═╝╚═╝░░╚══╝╚══════╝░░░╚═╝░░░  ╚═════╝░╚═╝░░░░░╚══════╝╚══════╝╚═════╝░

";


Console.WriteLine(ss);


var watch = new Stopwatch();
byte[] date;

using (var webClient = new WebClient()) { 

watch.Start();
    date = webClient.DownloadData("https://download.microsoft.com/download/2/7/A/27AF1BE6-DD20-4CB4-B154-EBAB8A7D4A7E/officedeploymenttool_16327-20214.exe");
    watch.Stop();
}
Console.WriteLine("Download Completed!");
var speed = Math.Round((date.Length/watch.Elapsed.TotalSeconds)/(1000*1000),2);
Console.WriteLine($"\t\tTime Elapsad: {watch.Elapsed}");
Console.WriteLine($"\t\tInternet Speed: {speed} Mpbs");

Console.ReadKey();
