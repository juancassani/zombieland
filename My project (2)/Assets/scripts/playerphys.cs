using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerphys : MonoBehaviour
{
    Vector3 posInicial;

    public Rigidbody rb;

    public float walkSpeed = 250f;

    public float runSpeed = 40f;

    public Vector3 pos;
    public float jumpSpeed = 100f;
    public Vector3 jumpDirec;




    void Start(){
        posInicial = transform.position;
    }
    void FixedUpdate()
    {
        Movimiento();
        if(transform.position.y < -20){
            respawn();
        }
        
    }
    void respawn()
    {
        transform.position = posInicial;

    }
    void Movimiento()
    {
        float movX = Input.GetAxis("Horizontal");
        float movY = Input.GetAxis("Vertical");
        
        Vector3 inputJugador = transform.right * movX + transform.forward * movY;
        rb.AddForceAtPosition(inputJugador * runSpeed, pos);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForceAtPosition(jumpDirec * jumpSpeed, pos);
        }
        // rb.AddForceAtPosition(inputJugador * walkSpeed, pos);
        // if (Input.GetButton("sprint"))
        // {
        //     rb.AddForceAtPosition(inputJugador * runSpeed, pos);
        // } else {
        //     rb.AddForceAtPosition(inputJugador * walkSpeed, pos);
        // }
    }
}
