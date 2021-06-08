using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementsScript : MonoBehaviour
{
    [SerializeField] GameObject[] AchievementsObject;
    void Start()
    { 
        if(testScript.yes)
        {
            Save.SaveText("0", "Выполнен");
            AchievementsObject[0].GetComponentInChildren<Text>().color = new Color(0, 140, 0, 255);

        }
        for (int i = 0;i<AchievementsObject.Length;i++)
        {
            AchievementsObject[i].GetComponentInChildren<Text>().text = Load.LoadText(i.ToString());
        }
    }
    private void OnApplicationQuit()
    {
        for (int i =0;i<AchievementsObject.Length;i++)
        {
            Save.SaveText(i.ToString(), AchievementsObject[i].GetComponentInChildren<Text>().text);
        }
    }
  
}
