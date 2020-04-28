using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

public class UdpClient
{
    public static void Main(string[] args)
    {
        IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("192.168.1.160"), 8888);
        Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "exit") break;
            server.SendTo(Encoding.UTF8.GetBytes(input), ipep);
        }
        Console.WriteLine("Stopping client");
        server.Close();
    }
}



