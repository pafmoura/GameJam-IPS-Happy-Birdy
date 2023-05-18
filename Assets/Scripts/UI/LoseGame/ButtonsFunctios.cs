using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonsFunctios : MonoBehaviour
{
    
    [SerializeField] private GameObject loseGameUI;
    
   [SerializeField]private RestartGame restartGame;

    [SerializeField] private ManagerSlingShoot managerSlingShoot;
   
    public void restartGameButton(){


        

        managerSlingShoot.enableSlingShoot(true);
        restartGame.restartGame();
        loseGameUI.SetActive(false);
        
    }


    public void mainMenu(){
        Time.timeScale = 1;
        loseGameUI.SetActive(false);
        //load the scene 
        SceneManager.LoadScene("Game");
        
    }
}
