using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

	public class themebuttonscript : MonoBehaviour {

	public Button theme;

		public void Start () {
		theme = theme.GetComponent<Button> ();
		}

	public void themeScene () {
			SceneManager.LoadScene("ThemeSelect");
		}
}

