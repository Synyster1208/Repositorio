using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballControler : MonoBehaviour
{
    public float fuerza_y = 500;
    public float fuerza_x ;
    public bool onGround;

    void Start()
    {
        onGround = false;
        fuerza_x = 0;
        
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
               Vector3 fuerza = new Vector3(fuerza_x,fuerza_y,0);
               GetComponent<Rigidbody>().AddForce(fuerza);
             }
            
        }

        if(Input.GetKeyDown(KeyCode.Z)  )
        {
               fuerza_x = fuerza_x - 100;
               
        }

        if(Input.GetKeyDown(KeyCode.X)  )
        {
              fuerza_x = fuerza_x + 100;
              
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
