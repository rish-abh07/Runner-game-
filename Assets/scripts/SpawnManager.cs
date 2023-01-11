using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    
    private Vector3 newpos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    public GameObject[] obstaclesPrefab;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spawn()
    {
        if (playerControllerScript.gameOver == false)
        {
             int obstacleIndex = Random.Range(0, obstaclesPrefab.Length);
             Instantiate(obstaclesPrefab[obstacleIndex], newpos, obstaclesPrefab[obstacleIndex].transform.rotation);
        }
    }
}
