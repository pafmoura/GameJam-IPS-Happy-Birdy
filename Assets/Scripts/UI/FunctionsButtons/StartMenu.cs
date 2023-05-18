using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
    


    void Awake(){
        Time.timeScale = 0;
    }

    [SerializeField] private GameObject gameUI;

    


    public void startGame(){
        //set time scale to 0
        Time.timeScale = 1;
        gameUI.SetActive(true);
        gameObject.SetActive(false);
    }
}
