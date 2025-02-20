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
                print("Animal moves");
            }

        }
        class Cat: Animal, ICanFight
        {
            public void Attack()
            {
                print("Cat attacks with claws!");
            }

            public override void MakeSound()
            {
                print("Meow");
            }
             public void Move()
            {
                print("Cat runs quickly.");
            }
        }
        
      
       public interface ICanFight
       {
        public void Attack();
       }
        public class Warrior : ICanFight
        {
            public void Attack()
            {
                print("Warrior attacks with a sword!");
            }
        }
         void Start()
       {

        
        Animal animal = new Cat();
        animal.MakeSound();
        animal.Move();
        Cat cat1 = animal as Cat;
        cat1.MakeSound();
        cat1.Move();
        List<ICanFight> canFights = new List<ICanFight>{new Cat(), new Warrior()};
        foreach(var item in canFights){
            item.Attack();
            
        }
        foreach(var item in canFights){
            if(item is Cat)
                print("The object is a Cat.");
            
            else
                print("The object is a Warrior.");
            
        }
        
       }

    }

}
