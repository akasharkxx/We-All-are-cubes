using System;
using System.Collections.Generic;
using System.Text;

namespace OurWorld
{
    class ServerHandle
    {
        public static void WelcomeReceived(int _fromClient, Packet _packet)
        {
            int _clientCheck = _packet.ReadInt();
            string _username = _packet.ReadString();

            Console.WriteLine($"{Server.clients[_fromClient].tcp.socket.Client.RemoteEndPoint} connected successfully and now is player {_username}.");
            if(_fromClient != _clientCheck)
            {
                Console.WriteLine($"Player \"{_username}\" (ID: {_fromClient} has assumed wrong client ID ({_clientCheck})!");
            }
            Server.clients[_fromClient].SendIntoGame(_username);
        }
    }
}
