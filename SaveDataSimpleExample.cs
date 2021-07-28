// written by Marius Rubo, 2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveDataSimpleExample : MonoBehaviour
{
    void Start()
    {
        string phpLocation = "https://YOUR_SERVER_FOLDER/SaveData.php";
        string filename = "Participant123";
        string data = "Condition,A;Rating1,3;Rating2,4;Rating3,3"; // data is stored as one string so seprate columns with ";", "," etc. 
        SaveData(phpLocation, filename, data);
    }

    // Two remarks:
    // - Data is sent and Unity does not bother to wait for php script to confirm reception. This is possible, though, in a Coroutine
    // - I use the older WWW class instead of the newer UnityWebRequest class because the former was more robust in one use case (when loading a video from a url).
    private void SaveData(string phpLocation, string filename, string data)
    {
        WWWForm form = new WWWForm();
        form.AddField("name", filename);
        form.AddField("dataToSave", data);
        WWW www = new WWW("https://www.rubo-research.com/Study1Data/SaveData.php", form);
    }
}
