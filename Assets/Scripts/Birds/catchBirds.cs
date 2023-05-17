using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catchBirds : MonoBehaviour
{

    [SerializeField]private  GameObject appleToShow  ;
    [SerializeField] private BirdsSaved birdsSaved;

    

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
            appleToShow.SetActive(true);
            disableCollider2D();
            birdsSaved.addBirdsSaved(1);
            Destroy(other.gameObject);

        }

    }



    private void disableCollider2D()
    {
        GetComponent<Collider2D>().enabled = false;
    }
}