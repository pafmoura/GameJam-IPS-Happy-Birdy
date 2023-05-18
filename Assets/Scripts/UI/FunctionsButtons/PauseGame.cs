using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{



    [SerializeField] private GameObject pauseGameUI;
   
   
   public void pauseGame(){
       pauseGameUI.SetActive(true);
       Time.timeScale = 0;
   }



    public void resumeGame(){
        Time.timeScale = 1;
        pauseGameUI.SetActive(false);
    }


    




}
