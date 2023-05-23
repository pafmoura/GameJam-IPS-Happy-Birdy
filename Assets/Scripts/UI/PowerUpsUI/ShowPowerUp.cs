using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowPowerUp : MonoBehaviour
{


    [SerializeField] private PowerUpManager powerUpManager;
    
    [SerializeField] private TextMeshProUGUI slowMotionPowerUpText;

    [SerializeField] private TextMeshProUGUI doublePointsPowerUpText;


    void Start(){
        showSlowMotionPowerUp();
        showDoublePointsPowerUp();
    }

    private void OnEnable()
    {
        powerUpManager.onChangeSlowMotionPowerUp += showSlowMotionPowerUp;
        powerUpManager.onChangeDoublePointsPowerUp += showDoublePointsPowerUp;
    }

    private void OnDisable()
    {
        powerUpManager.onChangeSlowMotionPowerUp -= showSlowMotionPowerUp;
        powerUpManager.onChangeDoublePointsPowerUp -= showDoublePointsPowerUp;
    }

    private void showSlowMotionPowerUp(){
        slowMotionPowerUpText.text = powerUpManager.getSlowMotionPowerUp().ToString();
    }

    private void showDoublePointsPowerUp(){
        doublePointsPowerUpText.text = powerUpManager.getDoublePointsPowerUp().ToString();
    }

    
}
