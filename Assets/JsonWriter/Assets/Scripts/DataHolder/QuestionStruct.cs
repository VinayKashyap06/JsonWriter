using UnityEngine;
using System;
using System.Collections.Generic;

namespace DataComponents
{
    [Serializable]
    public struct QuestionStruct
    {
        public DifficultyEnum difficultyLevel;
        public List<DifficultyStruct> questions;
    }
}