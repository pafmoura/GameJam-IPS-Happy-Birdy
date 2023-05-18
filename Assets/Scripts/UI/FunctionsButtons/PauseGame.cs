using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseGame : MonoBehaviour
{
    [SerializeField] private ManagerSlingShoot managerSlingShoot;


    [SerializeField] private GameObject pauseGameUI;
    
   [SerializeField]private RestartGame restartGame;
   
   public void pauseGame(){
       pauseGameUI.SetActive(true);
       Time.timeScale = 0;
         managerSlingShoot.disableSlingShoot();
   }



    public void resumeGame(){
        Time.timeScale = 1;
        pauseGameUI.SetActive(false);
        managerSlingShoot.enableSlingShoot();
    }


    public void restartGameButton(){
        restartGame.restartGame();
        pauseGameUI.SetActive(false);
        managerSlingShoot.enableSlingShoot(true);
        
    }


    public void mainMenu(){
        Time.timeScale = 1;
        pauseGameUI.SetActive(false);
        //load the scene 
        SceneManager.LoadScene("Game");
        
    }
    




}
