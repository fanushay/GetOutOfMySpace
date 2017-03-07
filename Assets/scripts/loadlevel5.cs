using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

	public class loadlevel5 : MonoBehaviour {
		
	public Button level5;

	public void Start () {
		level5 = level5.GetComponent<Button> ();
	}

	public void nextlevel () {
		SceneManager.LoadScene("level 5");
	}
}

