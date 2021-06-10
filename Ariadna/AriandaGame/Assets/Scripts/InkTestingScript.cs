using Ink.Runtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class InkTestingScript : MonoBehaviour
{
    public TextAsset inkJSON;
    private Story story;
    public Text text;
    public Button buttonPrefab;
    public Image PanelText;
    public Image image;
    public Image PanelButton;
    public Sprite[] sprites;
    private int count;
    int result;

    void Start()
    {
        story = new Story(inkJSON.text);
        refreshUI();

    }

    void refreshUI()
    {
        eraseUI();
        Choices.alone = false;
        Choices.goodEnd = false;
        Choices.together = false;
        Choices.badend = false;
        Choices.normalEnd = false;
        text.text = loadStoryChunk();
        if (int.TryParse(story.currentTags[0],out int result))
            image.sprite = sprites[int.Parse(story.currentTags[0]) - 1];
       
        if (story.currentChoices.Count == 0)
        {
            if (story.currentTags[0] == "BadEnding")
            {
                Save.SaveText("1", "Выполнено");
                Choices.alone = true;
            }
            if (story.currentTags[0] == "Ending")
            {
                Save.SaveText("2", "Выполнено");
                Choices.together = true;
            }
            if (story.currentTags[0] == "GoodEndWithTheory")
            {
                Save.SaveText("0", "Выполнено");
                Save.SaveText("3", "Выполнено");
                Save.SaveText("5", "Выполнено");
                Choices.goodEndWithTheory = true;
            }
            if (story.currentTags[0] == "GoodEnd")
            {
                Save.SaveText("0", "Выполнено");
                Save.SaveText("3", "Выполнено");
                Save.SaveText("5", "Выполнено");
                Choices.goodEnd = true;
            }
            if (story.currentTags[0] == "BadSecondEnd")
            {
                Save.SaveText("4", "Выполнено");
                Choices.badend = true;
            }
            if (story.currentTags[0] == "NormalEnd")
            {
                Choices.normalEnd = true;
            }
            SceneManager.LoadScene("GameOverScene");
        }
        foreach (Choice choice in story.currentChoices)
        {
            Button choiceButton = Instantiate(buttonPrefab) as Button;
            choiceButton.transform.SetParent(PanelButton.transform, false);
            Text choiceText = choiceButton.GetComponentInChildren<Text>();
            choiceText.text = choice.text;
            choiceButton.onClick.AddListener(delegate
            {
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