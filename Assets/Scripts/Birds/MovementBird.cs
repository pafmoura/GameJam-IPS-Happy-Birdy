using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBird : MonoBehaviour
{
    
    public float speed = 5f; // Velocidade inicial de movimento dos pássaros
    
    [SerializeField] private BirdsSaved birdsSaved;

    [SerializeField] private LoseBird loseBird;
   
    
    void Awake(){
        speed= birdsSaved.getSpeed();
    }

    

    void Update()
    {
         speed= birdsSaved.getSpeed();

        Vector3 movement = new Vector3(0f, 0f, 1f);
        transform.Translate( movement * speed * Time.deltaTime);
        
        if (transform.position.x < -10f) // Se o pássaro sair da tela no lado esquerdo
        {
            //count that the bird is lost
            loseBird.lostBird();

            Destroy(gameObject); // Destruir o objeto do pássaro
        }
    }


    
}
