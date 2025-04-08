using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyCharacterController : MonoBehaviour
{
    // Start is called before the first frame update
   Rigidbody rigidbody;
   Vector3 input;     float speed = 4f;
   bool jump = false;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.freezeRotation = true;
        rigidbody.mass = 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        input = input.normalized * speed;
        input.y = rigidbody.velocity.y;
        if(Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
        }
    }
    void FixedUpdate(){
        if(jump)
        {
            rigidbody.AddForce(Vector3.up * 10, ForceMode.Impulse);
            jump = false;
        }else{
            rigidbody.velocity = input ;
        }
    }
}
