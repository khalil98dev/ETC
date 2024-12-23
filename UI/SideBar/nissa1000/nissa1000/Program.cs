using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nissa1000
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            using (StreamWriter File = new StreamWriter("nissa.txt",true))
            {
                for (int i = 0; i <= 1000; i++)
                {
                    File.WriteLine("NhabeQ nissa "); 
                }
               
            }
            
        }

        
    }
}
