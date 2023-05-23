using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
public class Timer : MonoBehaviour
{
   

    [SerializeField] private Image uiFill;
   
    public int Duration;

    private int remainingDuration;

    public event UnityAction onTimerEnd;



   
    public void startTimer()
    {
        Being(Duration);
    }

    private void Being(int Second)
    {
        remainingDuration = Second;
        StartCoroutine(UpdateTimer());
    }

    private IEnumerator UpdateTimer()
    {
        while(remainingDuration >= 0)
        {
           
              
            uiFill.fillAmount = Mathf.InverseLerp(0, Duration, remainingDuration);
            remainingDuration--;
            yield return new WaitForSeconds(1f);
        
      
        }
        OnEnd();
    }

    private void OnEnd()
    {
        onTimerEnd?.Invoke();
    }


}
