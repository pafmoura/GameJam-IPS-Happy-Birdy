using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseBird : MonoBehaviour
{
    
    [SerializeField] private BirdsSaved birdsSaved;

    [SerializeField] private LoseGameShow loseGameShow;

    public void lostBird(){
        
        birdsSaved.haveLostBird();
    }

}
