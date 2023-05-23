using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoublePoints : MonoBehaviour
{
    [SerializeField] private PowerUpManager powerUpManager;

    [SerializeField] private BirdsSaved birdsSaved;
    
    [SerializeField] private Timer timer;


    [SerializeField] private GameObject doublePointsTimer; 

    [SerializeField]  private Button doublePointsButton;
    


    private void OnEnable()
    {
        timer.onTimerEnd += finishPowerUp;
    }

    private void OnDisable()
    {
        timer.onTimerEnd -= finishPowerUp;
    }



    //when the player click in the imahge
    public void doublePointsActive(){
        //if the player have slow motion power up
        if(powerUpManager.getDoublePointsPowerUp()>0){
            doublePointsTimer.SetActive(true);
            //disable the button
            doublePointsButton.interactable = false;


            //double the points by bird saved
            birdsSaved.setToDoublePoints(true);


            powerUpManager.decreaseDoublePointsPowerUp();
            timer.startTimer();


            }
    }

    private void finishPowerUp(){
        birdsSaved.setToDoublePoints(false);
        doublePointsTimer.SetActive(false);
        doublePointsButton.interactable = true;
    }


}
