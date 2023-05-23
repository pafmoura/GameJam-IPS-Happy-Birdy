using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSpawner : MonoBehaviour
{
   
   public GameObject birdPrefab;
public GameObject bossPrefab;


    [SerializeField]private float timeToSpawn;

    [SerializeField] private BirdsSaved birdsSaved;

    [SerializeField] private float subtractTime=0.2f;

    void Start()
    {
    timeToSpawn = birdsSaved.getTimeToSpawn();
    InvokeRepeating("SpawnBird", 0f, timeToSpawn);
    Invoke("inicialBoss", 0);
    }


    void inicialBoss(){
    InvokeRepeating("SpawnBoss", 0f, 20);
    }


    void SpawnBird()
    {
    float spawnX = transform.position.x; // Offset from the current position
    float spawnY = transform.position.y + Random.Range(-5f, 3f); // Posição Y aleatória
    
    Vector3 spawnPosition = new Vector3(spawnX, spawnY, 0f);
    GameObject bird = Instantiate(birdPrefab, spawnPosition, birdPrefab.transform.rotation);
    }

    void SpawnBoss()
    {
    float spawnX = transform.position.x; // Offset from the current position
    float spawnY = transform.position.y + Random.Range(-5f, 3f); // Posição Y aleatória
    
    Vector3 spawnPosition = new Vector3(spawnX, spawnY, 0f);
    GameObject birdboss = Instantiate(bossPrefab, spawnPosition, bossPrefab.transform.rotation);
    }



    public void decreaseTimeToSpawn(){
        timeToSpawn = birdsSaved.getTimeToSpawn();
    
        if(timeToSpawn <= 0.5f){
            return;
        }
        birdsSaved.setTimeToSpawn(timeToSpawn-subtractTime);
        timeToSpawn = birdsSaved.getTimeToSpawn();
       
        //invoke repeating
        this.CancelInvoke();
        this.InvokeRepeating("SpawnBird", 0f, timeToSpawn);
    }



    
    


}
