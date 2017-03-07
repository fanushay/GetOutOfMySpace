using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

	public class homebuttonscript : MonoBehaviour {

		public Button home;

		public void Start () {
			home = home.GetComponent<Button> ();
		}

		public void homeScene () {
			SceneManager.LoadScene("new_intro");
		}
}

