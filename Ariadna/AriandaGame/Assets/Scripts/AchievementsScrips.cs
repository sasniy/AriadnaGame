using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]
public class AchievementsScrips : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> AchievementsList;
    GameObject Achievement;
    void checkAch()
    {
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (InkTestingScript.FirstAchievement)
        {
            AchievementsList[0].GetComponentInChildren<Image>().GetComponentInChildren<Image>().color = new Vector4(255, 255, 255, 255);
            InkTestingScript.FirstAchievement = true;
        }
    }
}
