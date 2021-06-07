﻿using Ink.Runtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class InkTestingScript : MonoBehaviour
{
    public static bool FirstAchievement;
    public TextAsset inkJSON;
    private Story story;
    public Text text;
    public Button buttonPrefab;
    public Image PanelText;
    public Image image;
    public Image PanelButton;
    public Sprite[] sprites;

    // Start is called before the first frame update
    void Start()
    {
        story = new Story(inkJSON.text);
        refreshUI();

    }

    void refreshUI()
    {
        eraseUI();

        text.text = loadStoryChunk();
        if (story.currentChoices.Count == 0)
        {
            Application.LoadLevel("MainMenu");
        }

        image.sprite = sprites[int.Parse(story.currentTags[0])-1];
        foreach (Choice choice in story.currentChoices)
        {
            Button choiceButton = Instantiate(buttonPrefab) as Button;
            choiceButton.transform.SetParent(PanelButton.transform , false);     
            Text choiceText = choiceButton.GetComponentInChildren<Text>();
            choiceText.text = choice.text;
            
            //if (story.currentChoices.Count == 1)
            //{
            //    choiceButton.transform.localPosition = new Vector2(PanelButton.transform.localScale.x-290, PanelButton.transform.localScale.y/2 -70) ;

            //}
            choiceButton.onClick.AddListener(delegate {
                chooseStoryChoice(choice);
            });

        }   
    }

    void eraseUI()
    {
        PanelButton.transform.GetComponent<VerticalLayoutGroup>().enabled = true;
        for (int i = 0  ; i < PanelButton.transform.childCount; i++)
        {
            Destroy(PanelButton.transform.GetChild(i).gameObject);
        }
    }

    void chooseStoryChoice(Choice choice)
    {
        story.ChooseChoiceIndex(choice.index);
        refreshUI();
    }   

    // Update is called once per frame
    void Update()
    {
    }

    string loadStoryChunk()
    {
        string text = " ";
        if (story.canContinue)
        {
            text= story.ContinueMaximally();

        }  
        return text;
    }
}