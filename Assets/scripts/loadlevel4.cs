using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

	public class loadlevel4 : MonoBehaviour {
		
	public Button level4;

	public void Start () {
		level4 = level4.GetComponent<Button> ();
	}

	public void nextlevel () {
		SceneManager.LoadScene("level 4");
	}
}

