using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
namespace assigment35
{
    public class UnityEventExample : MonoBehaviour
    {
        public UnityEvent onEventTriggered;
        void Start()
        {
            onEventTriggered = new UnityEvent();
            onEventTriggered.AddListener(Event);
        }

        // Update is called once per frame
        void Update()
        {
            onEventTriggered.Invoke();
        }
        public void Event()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("The event has been triggered");
            }
        }
    }
}