using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
    
    [SerializeField] private ManagerSlingShoot managerSlingShoot;

    void Awake(){
        managerSlingShoot.disableSlingShoot();
        Time.timeScale = 0;
    }

    [SerializeField] private GameObject gameUI;

    [SerializeField] private GameObject buttonPauseGame;

    


    public void startGame(){

        //set time scale to 0
        Time.timeScale = 1;
        buttonPauseGame.SetActive(true);
        gameUI.SetActive(true);
        gameObject.SetActive(false);

        managerSlingShoot.enableSlingShoot();
    }
}
