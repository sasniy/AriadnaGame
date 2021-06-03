using Ink.Runtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InkTestingScript : MonoBehaviour
{
    public TextAsset inkJSON;
    private Story story;
    public Text text;
    public Text textPrefab;
    public Button buttonPrefab;
    public Image image;
    public Sprite sprite1;
    public Sprite sprite2;

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
        if (story.currentTags[0] == "image1")
            image.sprite = sprite1;
        if (story.currentTags[0] == "image2")
            image.sprite = sprite2;
        foreach (Choice choice in story.currentChoices)
        {
            Button choiceButton = Instantiate(buttonPrefab) as Button;
            choiceButton.transform.SetParent(this.transform , false);     
            Text choiceText = choiceButton.GetComponentInChildren<Text>();
            choiceText.text = choice.text;
            if (story.currentChoices.Count == 1)
            {
                this.transform.GetComponent<VerticalLayoutGroup>().enabled = false;
                choiceButton.transform.localPosition = new Vector2(-350, -1500);
            }
            choiceButton.onClick.AddListener(delegate {
                chooseStoryChoice(choice);
            });

        }   
    }

    void eraseUI()
    {
        this.transform.GetComponent<VerticalLayoutGroup>().enabled = true;
        for (int i = 2  ; i < this.transform.childCount; i++)
        {
            Destroy(this.transform.GetChild(i).gameObject);
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
        string text = "";
        if (story.canContinue)
        {
            text = story.ContinueMaximally();
        }

        return text;
    }
}