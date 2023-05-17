using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSpawner : MonoBehaviour
{
   
   public GameObject birdPrefab;


    [SerializeField]private float timeToSpawn;

    [SerializeField] private BirdsSaved birdsSaved;


    void Start()
    {
    timeToSpawn = birdsSaved.getTimeToSpawn();
    InvokeRepeating("SpawnBird", 0f, timeToSpawn);
    }

    void SpawnBird()
    {
    float spawnX = transform.position.x; // Offset from the current position
    float spawnY = transform.position.y + Random.Range(-5f, 3f); // Posição Y aleatória
    
    Vector3 spawnPosition = new Vector3(spawnX, spawnY, 0f);
    GameObject bird = Instantiate(birdPrefab, spawnPosition, birdPrefab.transform.rotation);
    }


    public void decreaseTimeToSpawn(){
        timeToSpawn = birdsSaved.getTimeToSpawn();
    
        if(timeToSpawn <= 0.5f){
            return;
        }
        birdsSaved.setTimeToSpawn(timeToSpawn-0.2f);
        timeToSpawn = birdsSaved.getTimeToSpawn();
       
        //invoke repeating
        CancelInvoke();
        InvokeRepeating("SpawnBird", 0f, timeToSpawn);
    }



    
    


}
