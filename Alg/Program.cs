using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Alg
{
    class Program
    {
        string text = "ss";

        void Run() 
        {
            var task = AsyncMethod(this);

            Console.WriteLine( "end" );
            task.Result;
            for (; ; ) ;
        }

        async Task<string> AsyncMethod(Program p) 
        {
            p.text = await new Task<string>( () => {
                Thread.Sleep(1000);
                return "test"; 
            });
            for (; ; )
                Console.WriteLine(text);
        } 

        static void Main(string[] args)
        {
            new Program().Run();
        }
    }
}
