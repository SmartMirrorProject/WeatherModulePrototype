using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.SpeechRecognition;

namespace WeatherModulePrototype.Models.Weather
{
    class WeatherVoiceController : IVoiceControlModule
    {
        public bool IsVoiceControlLoaded { get; set; }
        public bool IsVoiceControlEnabled { get; set; }
        public string VoiceControlKey { get; }
        public string GrammarFilePath { get; }
        public SpeechRecognitionGrammarFileConstraint Grammar { get; set; }

        public WeatherVoiceController(string grammarFilePath)
        {
            IsVoiceControlLoaded = false;
            IsVoiceControlEnabled = false;
            VoiceControlKey = "weather";
            GrammarFilePath = grammarFilePath;
        }

        /// <summary>
        /// Receive a voice recognition result and handle logic based on command.
        /// </summary>
        public void ProcessVoiceCommand(SpeechRecognitionResult command)
        {
            IReadOnlyDictionary<string, IReadOnlyList<string>> tags = command.SemanticInterpretation.Properties;
            string cmd = tags.ContainsKey(WeatherCommands.TAG_CMD) ? tags[WeatherCommands.TAG_CMD][0] : "";
            string timeFrame = tags.ContainsKey(WeatherCommands.TAG_TIME) ? tags[WeatherCommands.TAG_TIME][0] : "";
            //TODO this should be passed in somewhere as a singleton or injected.
            WeatherModel weatherModel = new WeatherModel();
            string city = "";
            weatherModel.HandleVoiceCommand(cmd, timeFrame, city);

        }
    }
}
