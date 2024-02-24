using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ballControler : MonoBehaviour
{
    //Componentes
    private Rigidbody rb;

    //Float
    public float fuerza_y = 500;
    public float fuerza_x ;
    public float fuerza_z ;

    //Bool
    public bool onGround;

    //Texto
    public Text X_txt;
    public Text Z_txt;
    public Text Start_txt;

    void Start()
    {
        onGround = false;
        fuerza_x = 0;
        fuerza_z = 0;
        rb = GetComponent<Rigidbody>();


    }

    
    void Update()
    {
        X_txt.text = fuerza_x.ToString();
        Z_txt.text = fuerza_z.ToString();

        if (Input.GetKeyDown(KeyCode.Return))
        {
            print("Space key was released");
            Destroy(Start_txt);
            if(rb != null)
            {
              rb.useGravity = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space)  )
        {
             if(onGround)
             {
               Vector3 fuerza = new Vector3(fuerza_x,fuerza_y,fuerza_z);
               rb.AddForce(fuerza);
             }
            
        }

        if(Input.GetKeyDown(KeyCode.A)  )
        {
               fuerza_x = fuerza_x - 100;
               
        }

        if(Input.GetKeyDown(KeyCode.D)  )
        {
              fuerza_x = fuerza_x + 100;
              
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            fuerza_z = fuerza_z + 100;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            fuerza_z = fuerza_z - 100;
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
