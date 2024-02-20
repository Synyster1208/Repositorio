using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballControler : MonoBehaviour
{
    public float forceJump = 500;
    public bool onGround;

    void Start()
    {
        onGround = false;
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            print("Space key was released");
            if(GetComponent<Rigidbody>() != null){
              GetComponent<Rigidbody>().useGravity = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.A)  )
        {
             if(onGround)
             {
               Vector3 fuerza = new Vector3(0,forceJump,0);
               GetComponent<Rigidbody>().AddForce(fuerza);
             }
            
        }
        
    }

    private void OnCollisionEnter(Collision other) 
    {
        Debug.Log("colision");
        onGround = true;
    }

    private void OnCollisionStay(Collision other) 
    {
        Debug.Log("colision");
        onGround = true;
    }

     private void OnCollisionExit(Collision other) 
    {
        onGround = false;
    }
}
