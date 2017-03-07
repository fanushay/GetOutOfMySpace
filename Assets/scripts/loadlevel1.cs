using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

	public class loadlevel1 : MonoBehaviour {
		
	public Button level1;

	public void Start () {
		level1 = level1.GetComponent<Button> ();
	}

	public void nextlevel () {
		SceneManager.LoadScene("level 1");
	}
}

