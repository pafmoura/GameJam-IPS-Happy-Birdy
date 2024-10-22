using UnityEngine;
using UnityEngine.Events;
using System.Collections;

//scriptable object
[CreateAssetMenu(fileName = "BirdsSaved", menuName = "ScriptableObjects/BirdsSaved", order = 1)   ]
public class BirdsSaved : ScriptableObject
{
    [SerializeField]private  int birdsSaved;

    [SerializeField]private int lostBirds=10;

    [SerializeField] private int speed=3;

    [SerializeField] private float timeToSpawn=3f;
    

    //for the power up double points
    [SerializeField] private bool doublePoints=false;


    //event
    public event UnityAction onBirdsSaved;
    public event UnityAction onLostBirds;
    public event UnityAction onLoseGame;


    public void resetVariables(){
        doublePoints = false;
        birdsSaved = 0;
        lostBirds = 10;
        speed = 3;
        timeToSpawn = 3f;

        onBirdsSaved?.Invoke();
        onLostBirds?.Invoke();
    }

    public void addBirdsSaved(int amount)
    {
        birdsSaved += amount;
        //call event
        onBirdsSaved?.Invoke();
    }   

    public void haveLostBird(){
        if(lostBirds>0){
            lostBirds--;    
            onLostBirds?.Invoke();
            
            if(lostBirds==0)
            {

                onLoseGame?.Invoke();
            }
        }else{
         //   onLoseGame?.Invoke();
        }
    }

    //getters
    public int getBirdsSaved(){
        return birdsSaved;
    }
    public int getLostBirds(){
        return lostBirds;
    }

    public int getSpeed(){
        return speed;
    }
    public int setSpeed(int speed){
        return this.speed = speed;
    }
    public float getTimeToSpawn(){
        return timeToSpawn;
    }
    public float setTimeToSpawn(float timeToSpawn){
        return this.timeToSpawn = timeToSpawn;
    }
    public bool isToDoublePoints(){
        return doublePoints;
    }
    public void setToDoublePoints(bool doublePoints){
        this.doublePoints = doublePoints;
    }


  }
