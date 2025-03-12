using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assigment35
{
    public class ListMethodsExample : MonoBehaviour
    {

        // Start is called before the first frame update
        void Start()
        {
            List<int> numbers = new List<int> { 5, 6, 7, 50, 30, 1, 10 };
            numbers.Sort((x, y) => y.CompareTo(x));
            Debug.Log(string.Join(", ", numbers));
            List<int> numbers2 = new List<int> { 3, 6, 7, 10, 30, 5, 10 };
            print("the even numbers in list is \n" + string.Join(" , ", numbers2.FindAll((x) => x % 2 == 0)));


        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}