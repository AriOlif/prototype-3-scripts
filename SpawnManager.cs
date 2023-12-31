using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject ObstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeat = 2;
    private PlayerController PlayerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        PlayerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", startDelay, repeat);
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        if(PlayerControllerScript.gameOver == false){
        Instantiate(ObstaclePrefab, spawnPos, ObstaclePrefab.transform.rotation);
        }
    }
}
