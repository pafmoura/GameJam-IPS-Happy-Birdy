using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catchBoss : MonoBehaviour
{

    [SerializeField]private  GameObject appleToShow  ;
    int remainingApples=1;
    [SerializeField] private BirdsSaved birdsSaved;
    [SerializeField]
    private AudioClip _clip;

    [SerializeField] private PowerUpManager powerUpManager;
    


    // Start is called before the first frame update
    void Start()
    {
        appleToShow.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    //method to trigger collision
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("collision detected");
        if (other.gameObject.tag == "apple")
        {
            if(remainingApples>=0){
                remainingApples--;
                Destroy(other.gameObject);
            }
            else
            {
            //power up added
            powerUpManager.randomPowerUp();

            appleToShow.SetActive(true);
            AudioSource.PlayClipAtPoint(_clip, transform.position);
            disableCollider2D();
            birdsSaved.addBirdsSaved(3);
            Destroy(other.gameObject);
            }
        }

    }



    private void disableCollider2D()
    {
        GetComponent<Collider2D>().enabled = false;
    }
}