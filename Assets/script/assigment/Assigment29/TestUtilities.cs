using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace assigment29
{
    public class TestUtilities:MonoBehaviour
    {
        void Start(){
            int x = 10;
            int y = 6;
            int z = 7;
            print("the sum x, y, z is " + Utilities.Add(x, y , z));
            print("saed".RepeatString(5));
        }
    }
}