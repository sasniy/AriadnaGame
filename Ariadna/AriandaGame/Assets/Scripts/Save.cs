using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour
{
    static public void SaveText(string key,string text)
    {
        PlayerPrefs.SetString(key, text);
        PlayerPrefs.Save();
        Debug.Log("YEs");
    }    
}
