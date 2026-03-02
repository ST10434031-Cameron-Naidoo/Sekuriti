
using System.Speech.Synthesis;

namespace Sekuriti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initialize new instance of speech synthesizer
            Voice voiceOver = new Voice();
            voiceOver.greet();
        }
    }
}
