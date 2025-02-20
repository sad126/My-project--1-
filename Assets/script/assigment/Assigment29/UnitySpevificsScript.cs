using Unity.VisualScripting;
using UnityEngine;

namespace assigment29
{
    public class UnitySpevificsScript: MonoBehaviour
    {
        GameObject target;
        void Start()
        {
           print("Game started!");
           target = GameObject.Find("TargetObject");
           
           print(target != null ? "Found object by name: TargetObject": "No TargetObject found.");
           print(GameObject.FindGameObjectWithTag("Joker") != null? "Found object by tag: Joker" : "No Joker object found.");
           print(GameObject.FindAnyObjectByType<Light>()!= null ?"Found object of type Light: Directional Light" :"No Light object found.");
        }
        void OnEnable()
        {
            
             print("GameObject Enabled");
        }
        void OnDisable()
        {
            print("GameObject Disabled");
        }
        void Update()
        {
            if(Input.GetKeyDown(KeyCode.D)){
                target.SetActive(false);
                
            }
        }
    }
    
}