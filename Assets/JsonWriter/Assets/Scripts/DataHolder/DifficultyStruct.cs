using UnityEngine;
using System;
using System.Collections.Generic;

namespace DataComponents
{
    [Serializable]
    public struct DifficultyStruct
    {
        public string question;
        public List<OptionsStruct> options;
    }
}