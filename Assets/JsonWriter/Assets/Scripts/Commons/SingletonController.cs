using System;
using System.Collections.Generic;
using UnityEngine;

namespace Commons
{
    public class SingletonController: MonoBehaviour
    {
        private static SingletonController instance;

        public SingletonController Instance { get { return instance; } }
        private void Awake()
        {
            OnInitialize();
        }
        protected virtual void OnInitialize()
        {
            if (instance == null)
            {
                instance = FindObjectOfType<SingletonController>();
                DontDestroyOnLoad(instance);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
    }
}
