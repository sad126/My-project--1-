using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assigment29
{
    public class BasicsScript: MonoBehaviour
    {
        void Start()
        {
            var var1 = 5;
            var var2 = 5.2;
            var var3 = "kk";
            Debug.Log(var1%2 == 0?$"The number {var1} is even": $"The number {var1} is odd");
            print(DateTime.Now.Date.DayOfWeek);
            print(DateTime.Now.TimeOfDay);
            print(DateTime.Now.Day);
        }
    }
}