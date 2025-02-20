using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assigment29
{
    public class CustomObjectTest : MonoBehaviour
    {
        void Start(){
            CustomObject customObject = new CustomObject(50, "hassan");
            print(customObject.ToString());
            CustomObject customObject2 = new CustomObject(30, "shady");
            print(customObject2.ToString());
            if(customObject==customObject2){
                print("to object is equeled");
            }
            else if(customObject!=customObject2){
                print("to object is not equeled");
            }
        }
    }
}