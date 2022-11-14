using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool gameEnded = false;
    public float restartDelay = 10f;


    public void CompleteLevel()
    {
        Debug.Log("¡nivel completado!");
    }
    public void EndGame()
    {
        if (gameEnded == false)
        {
            gameEnded = true;
            Debug.Log("Derrota");
            Invoke("Restart", restartDelay);
        }
    }

    public void Restart()
    {

    }
    GameObject[] Enemies;
    public float enemyCount;
    public GameObject ui;

    void Update()
    {
        Enemies = GameObject.FindGameObjectsWithTag("enemy");

        if(Enemies.Length <= 0)
        {
            ui.SetActive(true);
            CompleteLevel();
        }
    }



}
