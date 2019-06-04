using UnityEngine;
using System;
using System.Collections.Generic;
namespace DataComponents
{
    [Serializable]
    public class CategoryStruct
    {
        public CategoryEnum categoryName;
        public List<QuestionStruct> questions;
    }
}