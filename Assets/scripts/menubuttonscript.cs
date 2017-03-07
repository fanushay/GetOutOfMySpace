using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

	public class menubuttonscript : MonoBehaviour {
		
	public Button menu;
	public GameObject menubar;

	public void Start () {
		menu =  menu.GetComponent<Button> ();
	}

	public void update () {
		menubar.SetActive(true);;
	}
}

