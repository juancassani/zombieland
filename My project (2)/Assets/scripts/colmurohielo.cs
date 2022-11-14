using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colmurohielo : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            rb.isKinematic = false;
        }
        if (col.gameObject.CompareTag("explotion"))
        {
            rb.isKinematic = false;
        }
    }
}
