using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Sekuriti
{
    class Voice
    {
        public SpeechSynthesizer sekuritiVoiceover;

        public Voice()
        {
            //Initialize new instance of speech synthesizer
            sekuritiVoiceover = new SpeechSynthesizer();
            //configure the audio output
            sekuritiVoiceover.SetOutputToDefaultAudioDevice();
            sekuritiVoiceover.SelectVoice("Microsoft Zira Desktop");
        }
        public void greet()
        {
            //Welcome the user
            sekuritiVoiceover.Speak("Hi there my name is security. your local cybersecurity chat bot. I'm here to help you stay sharp on Mzansi's digital streets. Ask me about scams, phishing, safe passwords, and more.");

        }

        public void speak(string speech)
        {
            sekuritiVoiceover.Speak(speech);
        }

    }
}
