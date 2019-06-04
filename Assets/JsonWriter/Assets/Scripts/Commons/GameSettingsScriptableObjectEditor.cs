//Uncomment this to run at runtime and not in editor
//#define RUNTIME

using UnityEngine;
using UnityEditor;

namespace Commons
{
    [CustomEditor(typeof(GameSettingsScriptableObject))]
    public class GameSettingsScriptableObjectEditor : Editor
    {
        public override void OnInspectorGUI()
        {
#if RUNTIME
            base.OnInspectorGUI();
            return;
#endif
            DrawDefaultInspector();
            GameSettingsScriptableObject gameSettings = (GameSettingsScriptableObject)target;
            if(GUILayout.Button("Create JSON"))
            {
                gameSettings.CreateJson();
            }
        }
    }
}