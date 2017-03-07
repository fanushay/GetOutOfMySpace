using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour {

	public Button playAgain;

	public void Start () {
		playAgain = playAgain.GetComponent<Button> ();
	}

	public void RestartGame () {
		SceneManager.LoadScene("level 1");
	}
}