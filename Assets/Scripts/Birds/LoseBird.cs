using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseBird : MonoBehaviour
{
    
    [SerializeField] private BirdsSaved birdsSaved;

    
    
    public void lostBird(){
        
        birdsSaved.haveLostBird();
    }

}
