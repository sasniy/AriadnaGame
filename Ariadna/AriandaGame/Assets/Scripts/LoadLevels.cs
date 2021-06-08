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
        SceneManager.LoadScene("ChapterSelection");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Chapter1()
    {
        SceneManager.LoadScene("Chapter1");

    }

    public void Chapter2()
    {
        SceneManager.LoadScene("Chapter2");
    }

    public void Achievments()
    {
        SceneManager.LoadScene("AchievmentsScene");
    }
    public void TheoryLoad()
    {
        SceneManager.LoadScene("Theory");
    }
}
