using System;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assigment35
{
    public abstract class AbstractBseClass
    {
        public abstract void PerformAction();
        public  void PrintInfo(){
            Debug.Log("This is a concrete method in the abstract base class.");
        }

    }
    public class DerivedClassExample : AbstractBseClass
    {
        public override void PerformAction()
        {
            Debug.Log("PerformAction is implemented in the derived class.");
        }

        
    }
    public class TestAbstractClass : MonoBehaviour
    {
        void Start()
        {
            DerivedClassExample classExample = new DerivedClassExample();
            classExample.PerformAction();
            classExample.PrintInfo();
        }
    }
}