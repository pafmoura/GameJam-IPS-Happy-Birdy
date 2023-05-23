using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{

    public bool collided;

    public void Release()
    {
        PathPoints.instance.Clear();
        StartCoroutine(CreatePathPoints());
    }


    void Update(){
         if (transform.position.y < -10f) 
        {
            Destroy(gameObject); // Destruir o objeto
        }
    }

    IEnumerator CreatePathPoints()
    {
        while (true)
        {
            if (collided) break;
            PathPoints.instance.CreateCurrentPathPoint(transform.position);
            yield return new WaitForSeconds(PathPoints.instance.timeInterval);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collided = true;
    }




    
}
