using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//scriptable object
[CreateAssetMenu(fileName = "BirdsSaved", menuName = "ScriptableObjects/BirdsSaved", order = 1)   ]
public class BirdsSaved : ScriptableObject
{
    [SerializeField]private  int birdsSaved;

    [SerializeField]private int lostBirds=10    ; 

    public void addBirdsSaved(int amount)
    {
        birdsSaved += amount;
    }   

    public void haveLostBird(){
        lostBirds--;    
    }





  }
