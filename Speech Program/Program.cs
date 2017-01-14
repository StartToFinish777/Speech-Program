using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Speech_Program
{
    class Program
    {
        static void Main(string[] args)
        {

/*yet to tidy up code
 and yea this is my first comment
 yay!*/
            SpeechSynthesizer synth = new SpeechSynthesizer();


            Console.WriteLine(" ");
            Console.WriteLine(" hello world");
            synth.Speak("Hello world, Yes this is my first console program, give me a sec to have a look around");

            System.Threading.Thread.Sleep(2000);

            Console.WriteLine(" ");

            Console.WriteLine("     Wait a minute.........");

            System.Threading.Thread.Sleep(2500);
            synth.Speak("Not Cool at all in the least bit");


            Console.WriteLine(" ");

            Console.WriteLine("         This world sucks! - terminate!");
            System.Threading.Thread.Sleep(1000);

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("             terminate in.. ");

            synth.Speak("Terminating in");
            System.Threading.Thread.Sleep(2200);

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("                     3");
            synth.Speak("three");
            System.Threading.Thread.Sleep(1700);

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");


            Console.WriteLine("                              2");
            synth.Speak("two");
            System.Threading.Thread.Sleep(2500);

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("                                      1");
            synth.Speak("one");

            System.Threading.Thread.Sleep(1000);
        synth.Speak("about to start initializing");
            Console.Write("I");
            System.Threading.Thread.Sleep(100);
            Console.Write("n");
            System.Threading.Thread.Sleep(100);
            Console.Write("i");
            System.Threading.Thread.Sleep(100);
            Console.Write("t");
            System.Threading.Thread.Sleep(100);
            Console.Write("i");
            System.Threading.Thread.Sleep(100);
            Console.Write("a");
            System.Threading.Thread.Sleep(100);
            Console.Write("l");
            System.Threading.Thread.Sleep(100);
            Console.Write("i");
            System.Threading.Thread.Sleep(100);
            Console.Write("s");
            System.Threading.Thread.Sleep(100);
            Console.Write("i");
            System.Threading.Thread.Sleep(100);
            Console.Write("n");
            System.Threading.Thread.Sleep(100);
            Console.Write("g");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(3000);

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("                          ><><><><|><><|><><|><><><><");
            Console.WriteLine(" ");
            Console.WriteLine("                          <>>>>>>>{TERMINATE}<<<<<<<<");
            Console.WriteLine(" ");
            Console.WriteLine("                          ><><><><|><><|><><|><><><><");
            synth.Speak("Termination Complete");

            System.Threading.Thread.Sleep(1500);

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("                                 ");

            Console.WriteLine("            ______________________________________________________ ");
            Console.WriteLine("           |                                                      |");
            Console.WriteLine("           | >--   Yes this is my first console program :D  --<   |");
            Console.WriteLine("           |______________________________________________________|");

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            System.Threading.Thread.Sleep(16500);
        }
    }
}
