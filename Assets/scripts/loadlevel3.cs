using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

	public class loadlevel3 : MonoBehaviour {
		
	public Button level3;

	public void Start () {
		level3 = level3.GetComponent<Button> ();
	}

	public void nextlevel () {
		SceneManager.LoadScene("level 3");
	}
}

