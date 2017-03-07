using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

	public class loadlevel7 : MonoBehaviour {
		
	public Button level7;

	public void Start () {
		level7 = level7.GetComponent<Button> ();
	}

	public void nextlevel () {
		SceneManager.LoadScene("level 7");
	}
}

