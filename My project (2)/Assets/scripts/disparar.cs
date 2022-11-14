using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparar : MonoBehaviour
{
    public float range = 70;
    public float propulsionForce = 150;
    public Rigidbody rb;
    public Transform cam1;
    public Transform shootplace;
    public Transform mytransform;
    public LayerMask hittableLayers;
    public GameObject activtorpedo;
    public GameObject torpedo;
    public GameObject wildtorpedo;

    void start(){
        cam1 = GameObject.FindGameObjectWithTag("fpscamara").transform;
        
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            shoot();
        }
        
    }
    void shoot()
    {
        
        Instantiate(activtorpedo, shootplace);
        rb.AddForce(shootplace.forward * propulsionForce, ForceMode.Impulse);
        Destroy(activtorpedo, 3);
        
    }
    void SetInitialReferences()
    {
        mytransform = transform;
    }
    
}
