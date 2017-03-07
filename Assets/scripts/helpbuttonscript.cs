using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

	public class helpbuttonscript : MonoBehaviour {

		public Button help;

		public void Start () {
			help = help.GetComponent<Button> ();
		}

		public void helpScene () {
			SceneManager.LoadScene("help");
		}
}

