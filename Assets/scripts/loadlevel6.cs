using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

	public class loadlevel6 : MonoBehaviour {
		
	public Button level6;

	public void Start () {
		level6 = level6.GetComponent<Button> ();
	}

	public void nextlevel () {
		SceneManager.LoadScene("level 6");
	}
}

