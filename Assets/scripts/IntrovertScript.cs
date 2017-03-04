using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntrovertScript : MonoBehaviour {

	public bool amIHappy;
	public SocialSpaceScript mySocialSpace;
	public PersonalSpaceScript myPersonalSpace;
	public GameManagerScript myGameManager;

	void Update() {
		
	}

	public void spaceStateChange() {
		if (mySocialSpace.amIHappy && myPersonalSpace.amIHappy) {
			amIHappy = true;
		} 
		else {
			amIHappy = false;
		}
		myGameManager.happyChecker (this);
	}
}
