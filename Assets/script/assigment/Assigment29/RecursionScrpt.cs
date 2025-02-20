using UnityEngine;

namespace assigment29
{
    public class RecursionScript : MonoBehaviour
    {
        public int FibonacciRecursive(int n)
        {
            if( n == 0 || n == 1  )return n;
            return FibonacciRecursive(n-1) + FibonacciRecursive(n-2);
        }
        public int FibonacciIterative(int n)
        {
            int a = 0;
            int b = 1;
           
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
        void Start()
        {
            print(FibonacciIterative(10));
            print(FibonacciIterative(30));
        }
    }
}