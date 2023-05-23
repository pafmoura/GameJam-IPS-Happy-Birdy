using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catchBirds : MonoBehaviour
{

    [SerializeField]private  GameObject appleToShow  ;
    [SerializeField] private BirdsSaved birdsSaved;
    [SerializeField]
    private AudioClip _clip;


    // Start is called before the first frame update
    void Start()
    {
        appleToShow.SetActive(false);
        
    }




    //method to trigger collision
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("collision detected");
        if (other.gameObject.tag == "apple")
        {
            
            appleToShow.SetActive(true);
            AudioSource.PlayClipAtPoint(_clip, transform.position);
            disableCollider2D();

            // if the player have double points power up
            if(birdsSaved.isToDoublePoints()){
                birdsSaved.addBirdsSaved(2);
            }else{
                birdsSaved.addBirdsSaved(1);
            }
            
            Destroy(other.gameObject);

        }

    }



    private void disableCollider2D()
    {
        GetComponent<Collider2D>().enabled = false;
    }
}