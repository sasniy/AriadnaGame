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
        text.text = loadStoryChunk();
        if (int.TryParse(story.currentTags[0],out int result))
            image.sprite = sprites[int.Parse(story.currentTags[0]) - 1];
        if (story.currentTags[0] == "BadEnding")
        {
            Debug.Log("Corectrl");
            Save.SaveText("1", "Выполнено");
        }
        if (story.currentChoices.Count == 0)
        {

           
            if (story.currentTags[0] == "Ending")
                Save.SaveText("2", "Выполнено");
            SceneManager.LoadScene("MainMenu");
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