using System;
using System.Net;

namespace Indexer.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ip = new IP(34, 56, 77, 155); 
            Console.WriteLine(ip.GetAddress());
            var firstpart =  ip[0]; 
            Console.WriteLine(firstpart.ToString());
        }
    }
    public class IP
    {
        private int[] ipAddress = new int[4];
        
        public int this[int idx]
        {
            get { return ipAddress[idx];}
            set { ipAddress[idx] = value;  }
        }
       public IP (string strip)
        {
            var seg =strip.Split('.');
            for (int i = 0;i < seg.Length; i++)
            {
                int ipToInt = Convert.ToInt32(seg[i]);
            }
        }
        public IP(int part1, int part2, int part3, int part4)
        {
            ipAddress[0] = part1;
            ipAddress[1] = part2;
            ipAddress[2] = part3;
            ipAddress[3] = part4;
        }
        public string GetAddress() => string.Join('.', ipAddress); 
        
    }
}
