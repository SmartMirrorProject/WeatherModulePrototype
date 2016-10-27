using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.SpeechRecognition;

namespace WeatherModulePrototype.Models
{
    interface IVoiceControlModule
    {
        //Interface Properties
        bool IsVoiceControlLoaded { get; set; }
        bool IsVoiceControlEnabled { get; set; }
        string VoiceControlKey { get; }
        string GrammarFilePath { get; }
        SpeechRecognitionGrammarFileConstraint Grammar { get; set; }


        //Interface Methods
        void ProcessVoiceCommand(SpeechRecognitionResult command);
    }
}
