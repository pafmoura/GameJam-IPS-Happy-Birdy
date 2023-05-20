using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class SaveGame : MonoBehaviour
{
        [SerializeField] private HighScore highScore;


    public void SaveListToJsonFile()
    { 

        if (!Directory.Exists(Application.persistentDataPath + "/SaveData"))

        {
            Debug.Log("Creating directory");
        Directory.CreateDirectory(Application.persistentDataPath + "/SaveData");
        }


        
         List<SaveData> list = highScore.getHighScoreList();
  

        ListSaveData listSaveData = new ListSaveData();

        // Convert the list to an array for serialization
        SaveData[] array = list.ToArray();

        listSaveData.array = array;

        // Convert the array to JSON
        string json = JsonUtility.ToJson(listSaveData);

        // Define the file path
        string filePath = Application.persistentDataPath + "/SaveData/listData.json";

        try
        {
            // Write the JSON data to the file
            File.WriteAllText(filePath, json);
            Debug.Log("List saved to JSON file: " + filePath);
        }
        catch (Exception e)
        {
            Debug.LogError("Failed to save list to JSON file: " + e.Message);
        }
    }


    public void LoadListFromJsonFile()
    {

        inicialState();



        List<SaveData> list = highScore.getHighScoreList();
        // Define the file path
        string filePath = Application.persistentDataPath + "/SaveData/listData.json";

        try
        {
            // Read the JSON data from the file
            string json = File.ReadAllText(filePath);

            // Convert the JSON data to an array
            ListSaveData listSaveData = JsonUtility.FromJson<ListSaveData>(json);



            
            
            highScore.setHighScoreList(listSaveData.arrayToList());

            Debug.Log("List loaded from JSON file: " + filePath);
        }
        catch (Exception e)
        {
            Debug.LogError("Failed to load list from JSON file: " + e.Message);
        }
    }


    private void inicialState(){
        
        if (!Directory.Exists(Application.persistentDataPath + "/SaveData"))
        {
            
        Directory.CreateDirectory(Application.persistentDataPath + "/SaveData");
        }

        if(!File.Exists(Application.persistentDataPath + "/SaveData/listData.json")){
            SaveListToJsonFile();
        }
    }




    public void eraseData(){
        //show the content of the file
        
        
        if (File.Exists(Application.persistentDataPath + "/SaveData/listData.json"))
        {
            
            File.Delete(Application.persistentDataPath + "/SaveData/listData.json");
            
            
        }
    }


    



}






[Serializable]
public class SaveData
{
    public string date;
    public int birds;
    

    public SaveData(string date, int birds)
    {
        this.date = date;
        this.birds = birds;
    }
}


[Serializable]
public class ListSaveData{
    public SaveData[] array;


    public List<SaveData> arrayToList(){
        List<SaveData> list = new List<SaveData>();
        foreach(SaveData data in array){
            list.Add(data);
        }
        return list;
    }
}
