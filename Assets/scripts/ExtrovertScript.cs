using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtrovertScript : MonoBehaviour {

	public bool amIHappy;
	public ExtSocialSpaceScript myExtSocialSpace;
	public ExtPersonalSpaceScript myExtPersonalSpace;
	public GameManagerScript myGameManager;

	public LayerMask backgroundLayerMask;

	public void spaceStateChange() {
		if (myExtSocialSpace.amIHappy && myExtPersonalSpace.amIHappy) {
			amIHappy = true;
		} 
		else {
			amIHappy = false;
		}
		myGameManager.happyChecker (this);
	}
}
