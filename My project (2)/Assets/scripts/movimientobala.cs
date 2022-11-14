using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientobala : MonoBehaviour
{
    public float bulletSpeed;
    public GameObject bullet;
    public float destroyTime;
    public Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward * bulletSpeed * Time.deltaTime;
        Destroy(bullet, destroyTime);
    }
}
