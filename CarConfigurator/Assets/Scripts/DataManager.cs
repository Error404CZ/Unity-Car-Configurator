using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataManager : MonoBehaviour
{
    public SaveData saveDataS;
    private string fileData = "saveData.txt";
    
    public void SaveData()
    {
        string jsonData = JsonUtility.ToJson(saveDataS);
        //Debug.Log(json);
        WriteToFile(fileData, jsonData);
        Debug.Log("SaveData");
    }
    
    public void LoadData()
    {
        string jsonData = ReadFromFile(fileData);
        JsonUtility.FromJsonOverwrite(jsonData, saveDataS);
        Debug.Log("LoadData");
    }
    
    
    private void WriteToFile(string fileName, string jsonData)
    {
        string path = GetFilePath(fileName);
        FileStream fileStream = new FileStream(path, FileMode.Create);

        using (StreamWriter writer = new StreamWriter(fileStream))
        {
            writer.Write(jsonData);
        }
    }

    private string ReadFromFile(string fileName)
    {
        string path = GetFilePath(fileName);
        if (File.Exists(path))
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string jsonData = reader.ReadToEnd();
                return jsonData;
            }
        }else
        {
            Debug.LogWarning("!File not found!");
        }

        return "";
    }

    private string GetFilePath(string fileName)
    {
        return Application.persistentDataPath + "/" + fileName;
    }
}
