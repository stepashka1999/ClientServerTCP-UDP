﻿using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ClientServer
{
    class Program
    {
        static void Main(string[] args)
        {
            const string ip = "192.168.1.2";
            const int port = 8080;

            #region TCP

            //var tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);

            //var tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //tcpSocket.Bind(tcpEndPoint);
            //tcpSocket.Listen(5);

            //while(true)
            //{
            //    var listener = tcpSocket.Accept();
            //    var buffer = new byte[256];
            //    var size = 0;
            //    var data = new StringBuilder();

            //    do
            //    {
            //        size = listener.Receive(buffer);
            //        data.Append(Encoding.UTF8.GetString(buffer, 0, size));
            //    }
            //    while (listener.Available > 0);

            //    Console.WriteLine(data);

            //    listener.Send(Encoding.UTF8.GetBytes(data.ToString()));

            //    listener.Shutdown(SocketShutdown.Both);
            //    listener.Close();
            //}

            #endregion

            #region UDP

            var udpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);

            var udpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            udpSocket.Bind(udpEndPoint);

            var buffer = new byte[256];
            var size = 0;
            var data = new StringBuilder();

            var listenerEndPoint = new IPEndPoint(IPAddress.Any, 0);


            #endregion
        }
    }
}