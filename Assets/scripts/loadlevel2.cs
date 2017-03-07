using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

	public class loadlevel2 : MonoBehaviour {
		
	public Button level2;

	public void Start () {
		level2 = level2.GetComponent<Button> ();
	}

	public void nextlevel () {
		SceneManager.LoadScene("level 2");
	}
}

