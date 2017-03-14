using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loadlevel10 : MonoBehaviour {

		public Button level10;

		public void Start () {
			level10 = level10.GetComponent<Button> ();
		}

		public void nextlevel () {
			SceneManager.LoadScene("level 10");
		}
	}

