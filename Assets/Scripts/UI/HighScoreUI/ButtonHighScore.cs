using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHighScore : MonoBehaviour
{
   



    public void mainMenu(){
        
        gameObject.SetActive(false);
        //load the scene 
        SceneManager.LoadScene("Game");
        
    }
    
}
