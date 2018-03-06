using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassGen
{
    public class Password
    {
        //Member variable(s)
        private int len;
        
        //Password function that returns the password string
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
        
        //Constructor
        public Password(int l)
        {
            Len = l;
        }
        
        //Verifies the length variable to determine if the length is greater than or equal to 0.
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
            //Try-catch block to catch invalid input
            try
            {
                //Variable(s)
                int length;
                
                //Prompts user for the password length
                Console.Write("Enter the password length: ");
                length = Convert.ToInt32(Console.ReadLine());
                
                //Creates Password object
                Password p = new Password(length);
               
                //Prints the generated password
                Console.WriteLine("Generated password: {0}", p.password());
            }
            
            //Catches the case where the length is negative
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Exception during execution: ");
                Console.WriteLine(ex.Message);
            }
            
            //Catches the case where the length is not an integer
            catch(FormatException fe)
            {
                Console.WriteLine("Exception during execution: ");
                Console.WriteLine(fe.Message);
            }
            
            Console.ReadLine();
        }
    }
}
