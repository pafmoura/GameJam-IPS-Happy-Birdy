using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
[CreateAssetMenu(fileName = "PowerUpManager", menuName = "ScriptableObjects/PowerUpManager")]
public class PowerUpManager : ScriptableObject
{

    [SerializeField] private int slowMotionPowerUp=0;


    public event UnityAction onChangeSlowMotionPowerUp;



    public int getSlowMotionPowerUp
    {
        get
        {
            return slowMotionPowerUp;
        }
        
    }

    public void decreaseSlowMotionPowerUp(){
        slowMotionPowerUp--;
        onChangeSlowMotionPowerUp?.Invoke();
    }

    public void increaseSlowMotionPowerUp(){
        slowMotionPowerUp++;
        onChangeSlowMotionPowerUp?.Invoke();
    }



    public void randomPowerUp(){
        int random = 0;//Random.Range(0, 2);
        if(random == 0){
            increaseSlowMotionPowerUp();
        }
    }

    
}
