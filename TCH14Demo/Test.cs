using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TM200Demo
{
    class Test
    {
        public void DataCallBack(UIntPtr hDevs, ref OutputInfoStruct outputInfo) {
            Console.WriteLine("device 001 DataCallBack IP: " + outputInfo.host + " PORT: " + outputInfo.baud_rate_or_port);
        }

        public void DataCallBack2(UIntPtr hDevs, ref OutputInfoStruct outputInfo)
        {
            Console.WriteLine("device 002 DataCallBack IP: " + outputInfo.host + " PORT: " + outputInfo.baud_rate_or_port);
        }


        public void SocketCallBack2(ref SocketInfoStruct socketInfo)
        {
            try
            {
                string host = Encoding.Default.GetString(socketInfo.IP);//IP地址
                int baudrateOrPort = socketInfo.port; //端口号
                host = host.Replace("\0", "");
                Console.WriteLine("IP: " + host + " PORT: " + baudrateOrPort);
                UIntPtr hDev = UIntPtr.Zero;
                int result = TM200.TCPServerConnect(ref hDev, socketInfo.socket, new FUN_DATA_CB(new Test().DataCallBack), host, baudrateOrPort);//添加连接的对象;
            }
            catch (Exception e)
            {

            }
        }

        private void Listen() 
        {
            short port = 20058;
            short port2 = 20059;
            FUN_SOCKET_CB f2 = new FUN_SOCKET_CB(new Test().SocketCallBack2);
            FUN_SOCKET_CB f = new FUN_SOCKET_CB(new Test().SocketCallBack2);
            int result = TM200.StartListening(ref hServerSocket, f, port);
            if (result == 1)
            {
                result = TM200.StartListening(ref hServerSocket2, f2, port2);
                Console.WriteLine(result);
            }
            while (true) ;
        }
        
        static UIntPtr hServerSocket = UIntPtr.Zero;
        static UIntPtr hServerSocket2 = UIntPtr.Zero;

        static void Main()
        {
            UIntPtr hDev = UIntPtr.Zero;
            string host = "192.168.3.200";
            int baudrateOrPort = 20058;
            TM200.ConnectDev(ref hDev, new FUN_DATA_CB(new Test().DataCallBack), host, baudrateOrPort);

            string host2 = "192.168.3.202";
            int baudrateOrPort2 = 20059;
            TM200.ConnectDev(ref hDev, new FUN_DATA_CB(new Test().DataCallBack2), host2, baudrateOrPort2);
            while (true);
        }
    }
}
