using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour
{
    
    public float speed = 1f; // Velocidade inicial de movimento dos pássaros
    
    [SerializeField] private BirdsSaved birdsSaved;

    [SerializeField] private LoseBird loseBird;

    [SerializeField] private GameObject appleToShow;
   
    
    void Awake(){
        speed= birdsSaved.getSpeed();
    }

    

    void Update()
    {

        Vector3 movement = new Vector3(0f, 0f, 1f);
        transform.Translate( movement * 1 * Time.deltaTime);
        
        if (transform.position.x < -10f) // Se o pássaro sair da tela no lado esquerdo
        {

            //check if the apple is active
            if (appleToShow.activeSelf)
            {
               return;
            }

            //count that the bird is lost
            loseBird.lostBird();

            Destroy(gameObject); // Destruir o objeto do pássaro
        }
    }


    
}
