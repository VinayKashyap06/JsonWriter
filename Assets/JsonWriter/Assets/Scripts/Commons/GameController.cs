
//Uncomment this to run at runtime and not in editor
//#define RUNTIME

using FileOperations;

namespace Commons
{
    
    public class GameController: SingletonController
    {
        public GameSettingsScriptableObject gameSettings;
        protected override void OnInitialize()
        {
            base.OnInitialize();
#if RUNTIME            
            JsonConverter.OnStart(gameSettings);
#endif

        }
    }
}
