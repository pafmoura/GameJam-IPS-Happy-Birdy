using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "HighScore", menuName = "ScriptableObjects/HighScore", order = 1) ]
public class HighScore : ScriptableObject
{

    [SerializeField]private List<SaveData> highScoreList = new List<SaveData>();
  


  public void setHighScoreList(List<SaveData> list)
  {
    highScoreList = list;
  }

    public List<SaveData> getHighScoreList()
    {
        return highScoreList;
    }


    public void addNewHighScore(string date, int birdsCollected )
    {
        SaveData newHighScore = new SaveData(date, birdsCollected);
        highScoreList.Add(newHighScore);
    }


    public void sortHighScoreList()
    {
        //sort the list by number of birds collected
        highScoreList.Sort((x, y) => y.birds.CompareTo(x.birds));

    }


    public void resetHighScore()
    {
        highScoreList.Clear();
    }
}
