using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassGen
{
    public class Password
    {
        private int len;
        public string password()
        {
            var chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%?&*()+-";
            string p = "";

            Random rand = new Random();
            for (int i = 0; i < len; i++)
            {
                char ch = chars[rand.Next(0, 73)];
                p += ch;
            }
            return p;
        }
        public Password(int l)
        {
            Len = l;
        }
        public int Len
        {
            get
            {
                return len;
            }
            set
            {
                if(value >= 0)
                {
                    len = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
    }   
    class Program
    {
        static void Main(string[] args)
        {
            int length;
            Console.Write("Enter the password length: ");
            length = Convert.ToInt32(Console.ReadLine());

            try
            {
                Password p = new Password(length);
                Console.WriteLine("Generated password: {0}", p.password());
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Exception during execution: ");
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
