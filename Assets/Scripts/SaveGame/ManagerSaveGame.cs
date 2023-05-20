using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class ManagerSaveGame : MonoBehaviour
{

    [SerializeField] private BirdsSaved birdsSaved;
    [SerializeField] private SaveGame saveGame;
    [SerializeField] private HighScore highScore;

    void OnEnable(){
        birdsSaved.onLoseGame += saveHighScore;
    }

    void OnDisable(){
        birdsSaved.onLoseGame -= saveHighScore;
    }


    void Awake(){
        saveGame.LoadListFromJsonFile();
    }


    void saveHighScore(){
        //save the high score

        highScore.addNewHighScore( DateTime.Now.ToString("dd/MM/yy"), birdsSaved.getBirdsSaved());
        
    
        saveGame.SaveListToJsonFile();
    }



    public void resetHighScore(){
        //reset the high score
        highScore.resetHighScore();
        saveGame.eraseData();
    }



}
