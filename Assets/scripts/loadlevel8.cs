using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loadlevel8 : MonoBehaviour {

	public Button level8;

	public void Start () {
		level8 = level8.GetComponent<Button> ();
	}

	public void nextlevel () {
		SceneManager.LoadScene("level 8");
	}
}

