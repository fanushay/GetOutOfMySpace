using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class unlocker : MonoBehaviour {

	public float nextLevelLoadTime;
    private int LevelAmount = 8;
    private int CurrentLevel;

	// Use this for initialization
	void Start () {
        CheckCurrentLevel();
        
	}
	


	public void LoadNextLevel() {
		int NextLevel = CurrentLevel + 1;
		if(NextLevel<LevelAmount)
		{
			PlayerPrefs.SetInt("Level" + NextLevel.ToString(), 1);
			//PlayerPrefs.SetInt("Level" + CurrentLevel.ToString());

		}else
		{
			//PlayerPrefs.SetInt("Level" + CurrentLevel.ToString());
		}
		Invoke ("LoadNextLevelForReal", nextLevelLoadTime);

	}

	public void LoadNextLevelForReal() {
		SceneManager.LoadScene("new_levelSelect");

	}

    void CheckCurrentLevel()
    {
        for(int i=1; i < LevelAmount; i++)
        {
			if (Application.loadedLevelName == "level " + i.ToString())
            {
                CurrentLevel = i;
                SaveMyGame();
            }
        }
    }
    void SaveMyGame()
    {
        int NextLevel = CurrentLevel;
        if(NextLevel<LevelAmount)
        {
            PlayerPrefs.SetInt("Level" + NextLevel.ToString(), 1);
            //PlayerPrefs.SetInt("Level" + CurrentLevel.ToString());

        }else
        {
            //PlayerPrefs.SetInt("Level" + CurrentLevel.ToString());
        }

    }

	void Update() {
		if (Input.GetKeyDown (KeyCode.R)) {
			Debug.Log ("Clearing player prefs");
			PlayerPrefs.DeleteAll ();
		}
	}
}
