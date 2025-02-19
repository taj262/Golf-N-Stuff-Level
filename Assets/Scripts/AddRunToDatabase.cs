using System;
using System.Collections;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class AddRunToDatabase : MonoBehaviour
{
    public string defaultURL = "http://localhost:8000/addPlayerData.php/";

    public string input;
    public string completeURL;

    void createCompleteURL() // also int time when the time comes
    {
        completeURL = defaultURL + "?username=" + input + "&score=" + watch.totalScore.ToString() +
                                                          "&time=" + watch.timeString;

    }

    void sendDataToDatabase()
    {

    }

    public void SendInputAndData(String name)
    {
        input = name;
        Debug.Log(input);

        createCompleteURL();

        Debug.Log(completeURL);

        UnityWebRequest.Get(completeURL).SendWebRequest();
    }

    
}
