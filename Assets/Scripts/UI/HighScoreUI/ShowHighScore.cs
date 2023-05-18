using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ShowHighScore : MonoBehaviour
{
   
   [SerializeField] private HighScore highScore;

    [SerializeField] private TextMeshProUGUI highScoreText;
    [SerializeField] private TextMeshProUGUI dateHighScoreText1;

    [SerializeField] private TextMeshProUGUI highScoreText2;
    [SerializeField] private TextMeshProUGUI dateHighScoreText2;

    [SerializeField] private TextMeshProUGUI highScoreText3;
    [SerializeField] private TextMeshProUGUI dateHighScoreText3;

    [SerializeField] private TextMeshProUGUI highScoreText4;
    [SerializeField] private TextMeshProUGUI dateHighScoreText4;

    [SerializeField] private TextMeshProUGUI highScoreText5;
    [SerializeField] private TextMeshProUGUI dateHighScoreText5;



    public void showHighScoreinUI(){
        
        highScore.sortHighScoreList();
        printHighScores();
       
    }



    private void printHighScores(){

        //print all the text with --- in the inicial state
        highScoreText.text = "---";
        dateHighScoreText1.text = "---";

        highScoreText2.text = "---";
        dateHighScoreText2.text = "---";

        highScoreText3.text = "---";
        dateHighScoreText3.text = "---";

        highScoreText4.text = "---";
        dateHighScoreText4.text = "---";

        highScoreText5.text = "---";
        dateHighScoreText5.text = "---";



        if(highScore.getHighScoreList().Count == 0){
            return;
        }

        if( highScore.getHighScoreList().Count>=1){
        highScoreText.text = highScore.getHighScoreList()[0].birds.ToString();
        dateHighScoreText1.text = highScore.getHighScoreList()[0].date;
        }

        if( highScore.getHighScoreList().Count>=2){
        highScoreText2.text = highScore.getHighScoreList()[1].birds.ToString();
        dateHighScoreText2.text = highScore.getHighScoreList()[1].date;
        }

        if( highScore.getHighScoreList().Count>=3){
        highScoreText3.text = highScore.getHighScoreList()[2].birds.ToString();
        dateHighScoreText3.text = highScore.getHighScoreList()[2].date;

        }
        
        if( highScore.getHighScoreList().Count>=4){
        highScoreText4.text = highScore.getHighScoreList()[3].birds.ToString();
        dateHighScoreText4.text = highScore.getHighScoreList()[3].date;
        }

        if( highScore.getHighScoreList().Count>=5){
        highScoreText5.text = highScore.getHighScoreList()[4].birds.ToString();
        dateHighScoreText5.text = highScore.getHighScoreList()[4].date;
        }

    }



}
