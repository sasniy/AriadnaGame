using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevels : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChapterSelection()
    {
        Application.LoadLevel("ChapterSelection");
    }

    public void MainMenu()
    {
        Application.LoadLevel("MainMenu");
    }

    public void Chapter1()
    {
        Application.LoadLevel("Chapter1");

    }

    public void Chapter2()
    {
        Application.LoadLevel("Chapter2");
    }

    public void Achievments()
    {
        Application.LoadLevel("AchievmentsScene");
    }
}
