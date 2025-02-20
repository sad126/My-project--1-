using System;
using UnityEngine;

namespace assigment29
{
    public class TryCatchTest: MonoBehaviour
    {
        void Start()
        {
            int playScore =  100;
            int divisor = 0;
            try
            {
                print("Attempting to calculate score multiplier....");
                int totalScore = playScore / divisor;
                
            }catch(DivideByZeroException ex){
                print("Error: Division by zero occurredwhile calculating score multiplier.");
            }finally{
                print("Score calculation complete. Cleaning upresources.");
            }
        }
    }
}