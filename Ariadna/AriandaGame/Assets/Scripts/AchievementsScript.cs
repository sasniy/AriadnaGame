using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementsScript : MonoBehaviour
{
    private Color green = new Color(0, 100, 0, 255);
    private Color yellow = new Color(255, 255, 0, 255);
    [SerializeField] GameObject[] AchievementsObject;

    void Start()
    {
        for (int i = 0; i < AchievementsObject.Length; i++)
        {
            AchievementsObject[i].GetComponentInChildren<Text>().text = Load.LoadText(i.ToString());
            if (AchievementsObject[i].GetComponentInChildren<Text>().text== "Выполнено")
            {
                AchievementsObject[i].GetComponentInChildren<Text>().color = green;
            }
            else
            {
                AchievementsObject[i].GetComponentInChildren<Text>().color = yellow;

            }
            //AchievementsObject[i].GetComponentInChildren<Text>().fontSize = 50;
        }
    }
    private void Update()
    {
        

    }
    private void OnApplicationQuit()
    {
        for (int i =0;i<AchievementsObject.Length;i++)
        {
            Save.SaveText(i.ToString(), AchievementsObject[i].GetComponentInChildren<Text>().text);
        }
    }
  
}
