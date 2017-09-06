using System;
using System.IO;
using System.Net.Sockets;


namespace ClientSocket
{
    class MainProgramClient
    {
        static void Main(string[] args)
        {

            TcpClient server = new TcpClient("10.140.70.21", 20001);
            string messageFromServer;
            string messageToServer;
            bool isConnected;

            //Trying to connect to server and creating connection
            try
            {

                NetworkStream stream = server.GetStream();
                StreamReader reader = new StreamReader(stream);
                StreamWriter writer = new StreamWriter(stream);
                isConnected = true;
                

                while (isConnected)
                {
                    messageFromServer = reader.ReadLine();
                    Console.WriteLine(messageFromServer);
                    messageToServer = Console.ReadLine();
                    writer.WriteLine(messageToServer);
                    writer.Flush();
                    
                                
                }

            }
            catch(Exception)
            {
                Console.WriteLine("fuck");

            }

        }
    }
}
