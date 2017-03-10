using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroTween : MonoBehaviour {

	public GameObject[] entities;
	public float moveDistance;
	public float moveTime;

	void Start() {
		foreach (GameObject eachEntity in entities) {
			Vector3 originalPosition = eachEntity.transform.position;
			eachEntity.transform.position += Vector3.up * moveDistance;
			iTween.MoveTo (eachEntity, iTween.Hash ("y", originalPosition.y, "time", moveTime, "easetype", "easeInOutQuad"));
		}
	}
}
