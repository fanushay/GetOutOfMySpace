using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LevelManagerScript : MonoBehaviour
{
    [System.Serializable]
    public class Level
    {
        public string LevelText;
        public int UnLocked;
        public bool IsInteractable;

        
    }

    public GameObject levelButton;
    public Transform Spacer;
    public List<Level> LevelList;


    // Use this for initialization
    void Start()
    {
        
        FillList();
    }

    void FillList()
    {
        foreach (var level in LevelList)
        {
            GameObject newbutton = Instantiate(levelButton) as GameObject;
            LevelButton button = newbutton.GetComponent<LevelButton>();
            button.LevelText.text = level.LevelText;
            //Level1, Level2,...

            if (PlayerPrefs.GetInt("Level" + button.LevelText.text) == 1)
            {
                level.UnLocked = 1;
                level.IsInteractable = true;
            }
            button.unlocked = level.UnLocked;
            button.GetComponent<Button>().interactable = level.IsInteractable;
            button.GetComponent<Button>().onClick.AddListener(() => loadLevel("level " + button.LevelText.text)); 

            newbutton.transform.SetParent(Spacer, false);
        }

        SaveAll();
    }

    void SaveAll()
    {
        /* if (PlayerPrefs.HasKey("Level1"))
         {
             return;
         }
         else*/
        {
            GameObject[] allButtons = GameObject.FindGameObjectsWithTag("LevelButton");
            foreach (GameObject buttons in allButtons)
            {
                LevelButton button = buttons.GetComponent<LevelButton>();
                PlayerPrefs.SetInt("Level" + button.LevelText.text, button.unlocked);
            }


        }


    }


    void loadLevel(string value)
    {
        SceneManager.LoadScene(value);
    }
  
}