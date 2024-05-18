using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Spawn : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    public GameObject[] obstacles;
    public GameObject[] obstaclesRandom;
    public GameObject[] obstaclesR;
    public GameObject lives;
    public GameObject cakes;



    private float startDelay = 1.0f;
    private float repeatRate = 1.0f;
    private PlayerController playerControllerScript;
    private float delay = 2.0f;
    private float repeatc = 5.0f;
    private float delays = 4.0f;
    private float repeats = 10.0f;
    private float delayed = 6.0f;
    private float repeated = 15.0f;
    private float delayLife = 10.0f;
    private int repeatLife;
    private float delayCake = 9.0f;
    private int repeatCake;

    // Start is called before the first frame update
    void Start()
    {
        int repeatLife = Random.Range(15, 40);
        int repeatCake = Random.Range(10, 30);
        InvokeRepeating("SpawnCookie", startDelay, repeatRate);
        InvokeRepeating("SpawnObstacle", delay, repeatc);
        InvokeRepeating("SpawnRandomObstacle", delays, repeats);
        InvokeRepeating("SpawnRObstacle", delayed, repeated);
        InvokeRepeating("SpawnLives", delayLife, repeatLife);
        InvokeRepeating("SpawnCakes", delayCake, repeatCake);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnCookie()
    {
        Vector3 spawnPoint = new Vector3(Random.Range(-2.7f, 2.7f), 0.5f, 50);
        int obstacleIndex = Random.Range(0, obstaclePrefabs.Length);
            Instantiate(obstaclePrefabs[obstacleIndex], spawnPoint, obstaclePrefabs[obstacleIndex].transform.rotation);

    }
    void SpawnObstacle()
    {
        Vector3 spawnPoint = new Vector3(-7, -13.9f, 130);
        int obstacleIndex = Random.Range(0, obstacles.Length);
        Instantiate(obstacles[obstacleIndex], spawnPoint, obstacles[obstacleIndex].transform.rotation);

    }
    void SpawnRandomObstacle()
    {
        Vector3 spawnPoint = new Vector3(Random.Range(-2.6f, 3.5f), 0.0f, 130);
        int obstacleRandomIndex = Random.Range(0, obstaclesRandom.Length);
        Instantiate(obstaclesRandom[obstacleRandomIndex], spawnPoint, obstaclesRandom[obstacleRandomIndex].transform.rotation);

    }
    void SpawnRObstacle()
    {
        Vector3 spawnPoint = new Vector3(Random.Range(-2.7f, 2.7f), 1.8f, 130);
        int obstacleRIndex = Random.Range(0, obstaclesR.Length);
        Instantiate(obstaclesR[obstacleRIndex], spawnPoint, obstaclesR[obstacleRIndex].transform.rotation);

    }
    void SpawnLives()
    {
        Vector3 spawnPoint = new Vector3(Random.Range(-3.2f, 3.2f), Random.Range(0.19f, 5), 130);
        Instantiate(lives, spawnPoint, lives.transform.rotation);

    }
    void SpawnCakes()
    {
        Vector3 spawnPoint = new Vector3(Random.Range(-3.2f, 3.2f), Random.Range(0.19f, 5), 130);
        Instantiate(cakes, spawnPoint, cakes.transform.rotation);

    }
}
