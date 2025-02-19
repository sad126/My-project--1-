using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assigment29
{
    public class TypeManagementScript:MonoBehaviour
    {
        class Animal
        {
            public virtual void MakeSound(){
                print("Animal sound");
            }
            public void Move()
            {
                debug.("Animal moves")
            }
        }
    }
}
