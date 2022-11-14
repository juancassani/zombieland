using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform player;
    public float speedFollow = 35f;
    private float minDistance = 10f;
    private float activateDistance = 70f;
    public float runSpeed = 2f;
    public GameObject ui;
    
    public enum TypeOfEnemy
    {
        enemy1,
        enemy2
    };
    public TypeOfEnemy type;
    void Start()
    {
        
    }

    void Update()
    {
        switch(type)
        {
            case TypeOfEnemy.enemy1:
                LookAtPlayer();
                break;
            
            case TypeOfEnemy.enemy2:
                LookAtPlayer(); 
                DistanceCheck();
                FollowPlayer();
                break;
            
            default:
                LookAtPlayer(); 
                DistanceCheck();
                FollowPlayer();
                break;
               
        }
    }

    public void DistanceCheck()
    {
        float distBetween = Vector3.Distance(player.position, transform.position);

        if (distBetween <= minDistance)
        {
            speedFollow = 0;
        } if( distBetween <= activateDistance){
            speedFollow = runSpeed;
        }
        else
        {
            speedFollow = 0f;
        }
        if(distBetween <= 5f)
        {
            ui.SetActive(true);
        }
        
    }
    public void FollowPlayer()
    {
        transform.position += transform.forward * speedFollow * Time.deltaTime;
    }


    public void LookAtPlayer()
    {
        // como hago que el player vea al jugador?: playerrotation con direccion al jugador (resta/suma de vectores con el position? acabo de ver zoom y usamos el siguiente script)
        transform.LookAt(player);
    }


    
}
