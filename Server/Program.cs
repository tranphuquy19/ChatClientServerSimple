using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            IPEndPoint ip = new IPEndPoint(IPAddress.Any,16057);
            TcpListener tcpListener = new TcpListener(ip);

            tcpListener.Start();
            Console.WriteLine("Litening...");

            TcpClient tcpClient = tcpListener.AcceptTcpClient();
            Console.WriteLine("Conected to Client!");

            StreamReader streamReader = new StreamReader(tcpClient.GetStream());
            StreamWriter streamWriter = new StreamWriter(tcpClient.GetStream());

            while(true)
            {
                string receive = streamReader.ReadLine();
                Console.WriteLine("Client: " + receive);

                Console.WriteLine("Server: ");
                streamWriter.WriteLine(Console.ReadLine());
                streamWriter.Flush();
            }
            streamReader.Close();
            streamWriter.Close();
            tcpClient.Close();
        }
    }
}
