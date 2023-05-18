using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerSlingShoot : MonoBehaviour
{
    
    [SerializeField] private GameObject slingShoot;
    [SerializeField] private Slingshot slingshotScript;




    public void disableSlingShoot(bool haveLostGame=false){
        slingShoot.GetComponent<Slingshot>().enabled = false;
        slingShoot.GetComponent<BoxCollider2D>().enabled = false;
        if(haveLostGame){
            disableApples();
            slingshotScript.CreateBird();
        }
    }




    public void enableSlingShoot(bool haveDisableApples=false){
        
        slingShoot.GetComponent<Slingshot>().enabled = true;
        slingShoot.GetComponent<BoxCollider2D>().enabled= true;
        
        if(haveDisableApples){
            disableApples();
            
            PathPoints.instance.Clear();
            slingshotScript.CreateBird();

        }
    }






    private void disableApples(){
        GameObject[] apples = GameObject.FindGameObjectsWithTag("apple");
        foreach (GameObject apple in apples)
        {

            Destroy(apple);
        }
    }

}
