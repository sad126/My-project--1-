using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assigment35
{
    delegate void MathOperation(int number);
    public class MulticasDelegateExample : MonoBehaviour
    {

        MathOperation operation;
        // Start is called before the first frame update
        void Start()
        {
            operation += DoubleNumber;
            operation += SquareNumber;
            operation += CubeNumber;
            operation(5);

        }
        void DoubleNumber(int number) => Debug.Log("the double number is" + number * 2);


        void SquareNumber(int number) => Debug.Log("the square number is " + number * number);
        void CubeNumber(int number) => Debug.Log("the cube number is : " + number * number * number);



    }
}