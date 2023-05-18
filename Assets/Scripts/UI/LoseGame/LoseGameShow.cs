using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseGameShow : MonoBehaviour
{


    [SerializeField] private ManagerSlingShoot managerSlingShoot;
    [SerializeField] private BirdsSaved birdsSaved;
    [SerializeField] private GameObject loseGameUI;

    void OnEnable(){
        birdsSaved.onLoseGame += showLoseGame;
    }

    void OnDisable(){
        birdsSaved.onLoseGame -= showLoseGame;
    }



    // Start is called before the first frame update
    void Start()
    {
        loseGameUI.SetActive(false);    
    }

    

    public void showLoseGame(){
        //set time scale to 0
        Time.timeScale = 0;
        loseGameUI.SetActive(true);
        managerSlingShoot.disableSlingShoot(true);
    }



}
