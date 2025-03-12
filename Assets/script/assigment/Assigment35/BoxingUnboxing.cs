using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assigment35
{
    public class BoxingUnboxing : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            int health = 100;
            object H = health;
            int unBoxing = (int)H;
            Debug.Log("the orginal is " + health);
            Debug.Log("the boxed is " + H);
            Debug.Log("the unboxed is " + unBoxing);

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
