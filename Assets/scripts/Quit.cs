using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour {

	public Button quitButton;

	public void Start () {
		quitButton = quitButton.GetComponent<Button> ();
	}

	public void QuitGame () {
		SceneManager.LoadScene("intro");
	}
}