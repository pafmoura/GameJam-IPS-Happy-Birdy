using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartGame : MonoBehaviour
{
   
   [SerializeField] private BirdsSaved birdsSaved;



    public void restartGame(){
         Time.timeScale = 1;
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
