using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class showInfoUI : MonoBehaviour
{
    //listener to the event 
    public BirdsSaved birdsSaved;
    public TextMeshProUGUI birdsCatchText;
    public TextMeshProUGUI birdsLostText;
    
    void Start()
    {
        updateBirdsCatch();
        updateBirdsLost();
    }


    void OnEnable()
    {
        birdsSaved.onBirdsSaved += updateBirdsCatch;   
        birdsSaved.onLostBirds += updateBirdsLost;
    
    }
    void OnDisable(){
        birdsSaved.onBirdsSaved -=  updateBirdsCatch;
        birdsSaved.onLostBirds -= updateBirdsLost;

    }



    void updateBirdsCatch(){
        birdsCatchText.text = birdsSaved.getBirdsSaved().ToString();

    }
    void updateBirdsLost(){
        birdsLostText.text = birdsSaved.getLostBirds().ToString();
    }


}
