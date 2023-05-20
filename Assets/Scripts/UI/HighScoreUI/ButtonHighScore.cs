using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHighScore : MonoBehaviour
{
   
    [SerializeField] private ManagerSaveGame managerSaveGame;


    public void mainMenu(){
        
        gameObject.SetActive(false);
        //load the scene 
        SceneManager.LoadScene("Game");
        
    }
    

    public void resetHighScore(){
            
        managerSaveGame.resetHighScore();
        SceneManager.LoadScene("Game");
    }

}
