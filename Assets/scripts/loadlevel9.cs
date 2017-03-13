using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loadlevel9 : MonoBehaviour {

	public Button level9;

	public void Start () {
		level9 = level9.GetComponent<Button> ();
	}

	public void nextlevel () {
		SceneManager.LoadScene("level 9");
	}
}

