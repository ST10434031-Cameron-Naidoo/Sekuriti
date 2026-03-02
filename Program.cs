
using System.Globalization;
using System.Speech.Synthesis;

namespace Sekuriti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initialize new instance of speech synthesizer
            Voice voiceOver = new Voice();
            voiceOver.speak("Hi there my name is security. your local cybersecurity chat bot. I'm here to help you stay sharp on Mzansi's digital streets. Ask me about scams, phishing, safe passwords, and more.");

        }
    }
}
