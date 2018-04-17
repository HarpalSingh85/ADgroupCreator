using System;

namespace DefaultNamingContext
{
    class Program
    {
        //OU=Groups,OU=India,DC=hps,DC=local
        public static string DNContext { get; set; }
        static void Main(string[] args)
        {
            DefaultNamingContext Obj = new DefaultNamingContext();
            DNContext = Obj.GetDefaultNamingContext();
            Console.WriteLine(DNContext);
            ADOperation OP = new ADOperation();
            OP.Create("OU=Groups,OU=India,DC=hps,DC=local", "DS_IT_TEST");
            Console.WriteLine(OP.Result);
        }
    }
    
 }
