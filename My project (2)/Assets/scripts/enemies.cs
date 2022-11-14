using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemies : MonoBehaviour
{
    GameObject[] Enemies;
    public float enemyCount;
    public GameObject ui;

    void Update()
    {
        Enemies = GameObject.FindGameObjectsWithTag("enemy");

        if(Enemies.Length <= 0)
        {
            ui.SetActive(true);
            
        }
    }


}
