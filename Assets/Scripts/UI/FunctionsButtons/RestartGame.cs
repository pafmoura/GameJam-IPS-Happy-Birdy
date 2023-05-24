using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartGame : MonoBehaviour
{
   
   [SerializeField] private BirdsSaved birdsSaved;

    [SerializeField] private PowerUpManager powerUpManager;

    
    [SerializeField] private Timer timerSlowMotion;
    [SerializeField] private Timer timerDoublePoints;


    public void restartGame(){
         Time.timeScale = 1;

        
        timerSlowMotion.OnEnd();
        timerDoublePoints.OnEnd();
        powerUpManager.resetWhenRestartGame();

        
         birdsSaved.resetVariables();
         deleteAllBirds();


        
    }


    private void deleteAllBirds(){
        GameObject[] birds = GameObject.FindGameObjectsWithTag("Bird");
        foreach (GameObject bird in birds)
        {
            Destroy(bird);
        }
    }

}
