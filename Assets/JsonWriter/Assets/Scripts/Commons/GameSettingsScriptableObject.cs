//Uncomment this to run at runtime and not in editor
//#define RUNTIME

using UnityEngine;
using System.Collections.Generic;
using DataComponents;
using FileOperations;

namespace Commons
{
    [CreateAssetMenu(fileName ="Game Settings", menuName ="Custom Objects/ Game Config",order =0)]
    public class GameSettingsScriptableObject : ScriptableObject
    {
        [SerializeField]
        public List<CategoryStruct> categories;

        public void CreateJson()
        {
#if RUNTIME
            //Just in case anyone forgets to comment runtime in editor script
            return;
#endif
            JsonConverter.OnStart(this);
        }
    }
}