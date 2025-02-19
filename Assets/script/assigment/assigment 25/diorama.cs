using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diorama : MonoBehaviour
{
   private bool isObend = false;
   public float speed = 5f;
    private Quaternion close;
    private Quaternion  open;
    public GameObject anoph;
    private Vector3 temp1;
    private Vector3 temp2;
   
    void Start()
    {
        anoph = GameObject.Find("anomphrizim");
        open = Quaternion.Euler(transform.eulerAngles.x-180, transform.eulerAngles.y, transform.eulerAngles.z);
        close = transform.rotation;
        temp1 = Vector3.zero;
        temp2 = anoph.transform.localScale;
    }

    
    void Update()
    {
        if(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)){
            isObend = !isObend;
            
        }
        
        transform.rotation = Quaternion.Lerp(transform.rotation , isObend ? open : close , Time.deltaTime*speed);
        anoph.transform.localScale = Vector3.Lerp(anoph.transform.localScale , isObend ? temp1 : temp2 , Time.deltaTime*speed);
        

    }
}
