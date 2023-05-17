using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseSpeed : MonoBehaviour
{
     [SerializeField] private int amountToIncrease = 2;
    [SerializeField] private int multiplierToIncrease = 2;
    [SerializeField] private BirdsSaved birdsSaved;

    [SerializeField]private BirdSpawner birdSpawner;
   

    void Awake(){
        birdsSaved.resetVariables();
    }


 void OnEnable()
    {
        birdsSaved.onBirdsSaved += increaseSpeed;
    }
    
    private void increaseSpeed(){
        if(birdsSaved.getBirdsSaved() % multiplierToIncrease == 0 && birdsSaved.getBirdsSaved() != 0){
            //this.speed += 30f;
            birdsSaved.setSpeed(birdsSaved.getSpeed()+amountToIncrease);

            //increase speed of bird spawner
            birdSpawner.decreaseTimeToSpawn();
            
        }

    }
}
