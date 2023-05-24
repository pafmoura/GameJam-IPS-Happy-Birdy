using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
[CreateAssetMenu(fileName = "PowerUpManager", menuName = "ScriptableObjects/PowerUpManager")]
public class PowerUpManager : ScriptableObject
{

    [SerializeField] private int slowMotionPowerUp=0;
    [SerializeField] private int doublePointsPowerUp=0;


    public event UnityAction onChangeSlowMotionPowerUp;
    public event UnityAction onChangeDoublePointsPowerUp;


    public int getSlowMotionPowerUp()
    {
            return slowMotionPowerUp;  
    }

    public void decreaseSlowMotionPowerUp(){
        slowMotionPowerUp--;
        onChangeSlowMotionPowerUp?.Invoke();
    }

    public void increaseSlowMotionPowerUp(){
        slowMotionPowerUp++;
        onChangeSlowMotionPowerUp?.Invoke();
    }




    public int getDoublePointsPowerUp()
    {
            return doublePointsPowerUp;  
    }

    public void decreaseDoublePointsPowerUp(){
        doublePointsPowerUp--;
        onChangeDoublePointsPowerUp?.Invoke();
    }

    public void increaseDoublePointsPowerUp(){
        doublePointsPowerUp++;
        onChangeDoublePointsPowerUp?.Invoke();
    }



    public void randomPowerUp(){
        int random = Random.Range(0, 2);
        if(random == 0){
            increaseSlowMotionPowerUp();
        }else if(random == 1){
            increaseDoublePointsPowerUp();
        }
    }

    public void resetVariables(){
        slowMotionPowerUp = 0;
        doublePointsPowerUp = 0;
        onChangeSlowMotionPowerUp?.Invoke();
        onChangeDoublePointsPowerUp?.Invoke();
    }



    public void resetWhenRestartGame(){
        resetVariables();
    }

    
}
