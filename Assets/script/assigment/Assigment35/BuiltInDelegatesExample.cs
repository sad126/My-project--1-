using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assigment35
{
    public class BuiltInDelegatesExample : MonoBehaviour
    {
        Action action = () => Debug.Log("jdskvnj");
        Func<int, int> square = (int number) => number * number;
        Predicate<int> isEven = (int number) => number % 2 == 0;
        // Start is called before the first frame update
        void Start()
        {
            action.Invoke();
            Debug.Log("th square number to 5 is " + square.Invoke(5));
            Debug.Log("Is 4 even? " + isEven.Invoke(4));
        }

        // Update is called once per frame
        void Update()
        {

        }

    }
}