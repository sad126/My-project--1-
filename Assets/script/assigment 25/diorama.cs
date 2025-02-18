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
    private bool anophapparent = false;
    void Start()
    {
        open = Quaternion.Euler(transform.eulerAngles.x-180, transform.eulerAngles.y, transform.eulerAngles.z);
        close = transform.rotation;
    }

    
    void Update()
    {
        if(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)){
            isObend = !isObend;
            anophapparent = !anophapparent;
        }
        anoph.SetActive(!anophapparent);
        transform.rotation = Quaternion.Lerp(transform.rotation , isObend ? open : close , Time.deltaTime*speed);
        

    }
}
