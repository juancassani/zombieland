using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lanzarbabosa : MonoBehaviour
{
    public Rigidbody rb;
    public float torpedoSpeed = 90f;
    private Collider[] hitColliders;
    public float bulletSpeed;
    public float blastRadius;
    public float explosionForce;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        slugFired();
    }

    private void slugFired(){
        Vector3 forward = rb.transform.forward;
        rb.AddForce(forward * torpedoSpeed, ForceMode.Impulse);
    }
    private void OnCollisionEnter(Collision col)
    {
        explosion(col.contacts[0].point);
    }

    void explosion(Vector3 explosionPoint)
    {
        hitColliders = Physics.OverlapSphere(explosionPoint, blastRadius);
        foreach(Collider hitcol in hitColliders)
        {
            Debug.Log(hitcol.gameObject.name);
            hitcol.GetComponent<Rigidbody>().isKinematic = false;
            hitcol.GetComponent<Rigidbody>().AddExplosionForce(explosionForce, explosionPoint, blastRadius, 1 , ForceMode.Impulse);
        }
    }
    
    
}

