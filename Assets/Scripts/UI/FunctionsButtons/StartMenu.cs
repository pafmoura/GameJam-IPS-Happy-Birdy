using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
    
    
    void Awake(){
        managerSlingShoot.disableSlingShoot();
        Time.timeScale = 0;
    }


    [SerializeField] private ManagerSlingShoot managerSlingShoot;

    [SerializeField] private GameObject canvasHighScore;


    [SerializeField] private GameObject gameUI;

    [SerializeField] private GameObject buttonPauseGame;

    [SerializeField] private ShowHighScore showHighScore;

    


    public void startGame(){

        //set time scale to 0
        Time.timeScale = 1;
        buttonPauseGame.SetActive(true);
        gameUI.SetActive(true);
        gameObject.SetActive(false);

        managerSlingShoot.enableSlingShoot();
    }


    public void viewHighScore(){
        //set time scale to 0
        Time.timeScale = 0;
        canvasHighScore.SetActive(true);
        showHighScore.showHighScoreinUI();
        gameObject.SetActive(false);
    }
}
