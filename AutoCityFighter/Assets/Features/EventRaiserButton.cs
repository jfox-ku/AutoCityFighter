using System;
using UnityEngine;
using UnityEngine.UI;

namespace Features
{
    public abstract class EventRaiserButton : MonoBehaviour
    {
        public Button Button;

        private void Awake()
        {
            Button.onClick.AddListener(RaiseEvent);
        }

        private void Reset()
        {
            Button = GetComponent<Button>();
        }
        
        public abstract void RaiseEvent();
        
        
    }
}