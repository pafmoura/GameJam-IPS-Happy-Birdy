using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
public class SlowMotion : MonoBehaviour
{


    [SerializeField] private PowerUpManager powerUpManager;
    
    [SerializeField] private BirdsSaved birdsSaved;

    [SerializeField] private Timer timer;

    private int saveSpeedBirds;
    private float saveSpawnTimeBirds;

    [SerializeField] private GameObject slowMotionTimer; 

    [SerializeField]  private Button slowMotionButton;
    


    private void OnEnable()
    {
        timer.onTimerEnd += setSpeedBirds;
    }

    private void OnDisable()
    {
        timer.onTimerEnd -= setSpeedBirds;
    }



    //when the player click in the imahge
    public void slowMotionActive(){
        //if the player have slow motion power up
        if(powerUpManager.getSlowMotionPowerUp()>0){
            slowMotionTimer.SetActive(true);
            //disable the button
            slowMotionButton.interactable = false;

            powerUpManager.decreaseSlowMotionPowerUp();
            timer.startTimer();

            //save the speed of the birds and the time to spawn
            saveSpeedBirds = birdsSaved.getSpeed();
            saveSpawnTimeBirds = birdsSaved.getTimeToSpawn();
             
            //set the speed of the birds and the time to spawn
            birdsSaved.setSpeed(3);
            birdsSaved.setTimeToSpawn(2f);
            }
    }

    private void setSpeedBirds(){
        birdsSaved.setSpeed(saveSpeedBirds);
        birdsSaved.setTimeToSpawn(saveSpawnTimeBirds);
        slowMotionTimer.SetActive(false);
        slowMotionButton.interactable = true;
    }





}
