using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowPowerUp : MonoBehaviour
{


    [SerializeField] private PowerUpManager powerUpManager;
    
    [SerializeField] private TextMeshProUGUI slowMotionPowerUpText;


    void Start(){
        showSlowMotionPowerUp();
    }

    private void OnEnable()
    {
        powerUpManager.onChangeSlowMotionPowerUp += showSlowMotionPowerUp;
    }

    private void OnDisable()
    {
        powerUpManager.onChangeSlowMotionPowerUp -= showSlowMotionPowerUp;
    }

    private void showSlowMotionPowerUp(){
        slowMotionPowerUpText.text = powerUpManager.getSlowMotionPowerUp.ToString();
    }

    
}
