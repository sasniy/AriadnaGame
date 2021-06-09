using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class AchievementStatus : MonoBehaviour
{
    public GameObject[] Achievements;
    public GameObject ResetPanel;
    public Button yesButton;
    public Button noButton;
    public static bool FirstChapter;
    public static bool SecondChapter; 
    public void Reset()
    {
        ResetPanel.gameObject.SetActive(true);
        yesButton.onClick.AddListener(yesClick);
        noButton.onClick.AddListener(noClick);    
       
    }
    private void yesClick()
    {
        ResetPanel.gameObject.SetActive(false);
        PlayerPrefs.DeleteAll();
        for (int i = 0; i < Achievements.Length; i++)
        {
            Save.SaveText(i.ToString(), "Не выполнено");
            Achievements[i].GetComponentInChildren<Text>().text = Load.LoadText(i.ToString());
            Achievements[i].GetComponentInChildren<Text>().color = new Color(255, 255, 0, 255);
        }
    }
    private void noClick()
    {
        ResetPanel.gameObject.SetActive(false);
    }    
}

