using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO.Ports;
using System.Threading;

// This a code that is installed on the TA side or a server

namespace consolefrompi
{
    class Program
    {
        

        static void Main(string[] args)
        {
           
            // declaring the address

            var S_IP = "143.215.102.219";
            var P_NO = 5000;

            // connection stablishment
            IPAddress localAdd = IPAddress.Parse(S_IP);
            TcpListener listener = new TcpListener(IPAddress.Any, P_NO);
            Console.WriteLine("Connection to the student Device...");
            listener.Start();

            while (true)
            {

                TcpClient tcpclient = listener.AcceptTcpClient();

                // Threads for multple 

                Thread tcpclientThread;
                tcpclientThread = new Thread(() => clientConnection(tcpclient));
                tcpclientThread.Start();

            }

        }

        private static void clientConnection(TcpClient tcpclient)
        {
           
            NetworkStream NewStream = tcpclient.GetStream();
            byte[] buffer = new byte[tcpclient.ReceiveBufferSize];

            // Putting the data coming  on the buffer

             int bytesRead = NewStream.Read(buffer, 0, tcpclient.ReceiveBufferSize);
             string d_station = Encoding.ASCII.GetString(buffer, 0, bytesRead);

            // Displaying the data d_station which is the tring bcoming from station

            Console.WriteLine("connection stablished : " + d_station);
             Console.WriteLine("HELP NEEDED ON  : " + d_station);
            NewStream.Write(buffer, 0, bytesRead);
            Console.WriteLine("\n");

            // closing the socket 
            tcpclient.Close();
        }

    }           


        }
    

   

