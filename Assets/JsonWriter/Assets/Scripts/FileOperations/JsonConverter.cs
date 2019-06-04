using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using DataComponents;
using Commons;
using UnityEngine;

namespace FileOperations
{
    public static class JsonConverter
    {        
        private static string path= "Assets/JsonWriter/Assets/StreamingAssets/";
        private static string jsonFile;
        public static string fileName = "NewJson.json";

        public static void OnStart(GameSettingsScriptableObject gameSettings)
        {
           // Debug.Log(gameSettings.categories.Count);
            jsonFile = JsonUtility.ToJson(gameSettings, true);

            //Debug.Log(jsonFile);
            FileStream fs = File.Create(path+fileName);
            byte[] byteFormat = GetByteFormat();
            fs.Write(byteFormat, 0, byteFormat.Length);

        }

        private static byte[] GetByteFormat()
        {
            return new UTF8Encoding(true).GetBytes(jsonFile);
        }
    }
}
