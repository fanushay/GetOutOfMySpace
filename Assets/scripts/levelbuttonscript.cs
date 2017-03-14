using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

	public class levelbuttonscript : MonoBehaviour {

	public Button level;

		public void Start () {
		level = level.GetComponent<Button> ();
		}

	public void levelScene () {
			SceneManager.LoadScene("new_levelSelect");
		}
}

