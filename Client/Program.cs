using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 16057);
            TcpClient tcpClient = new TcpClient();
            tcpClient.Connect(iPEndPoint);
            Console.WriteLine("Conected to Server!");

            StreamReader streamReader = new StreamReader(tcpClient.GetStream());
            StreamWriter streamWriter = new StreamWriter(tcpClient.GetStream());
            while(true)
            {
                Console.WriteLine("Client: ");
                streamWriter.WriteLine(Console.ReadLine());//Allways use .WriteLine() to send data to streamReader in Server
                streamWriter.Flush();
                string recevice = streamReader.ReadLine();
                Console.WriteLine("Server: " + recevice);
            }
            streamReader.Close();
            streamWriter.Close();
            tcpClient.Close();
        }
    }
}
