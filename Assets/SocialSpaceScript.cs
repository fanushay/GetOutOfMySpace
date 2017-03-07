﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocialSpaceScript : MonoBehaviour
{
	
    //SpriteRenderer socSprite = GetComponent<SpriteRenderer>();
    public Color unComfyColor = new Color();
    public Color comfyColor = new Color();
	IntrovertScript myIntrovert;
	ExtrovertScript myExtrovert;
    private int numBreach = 0;

	public bool amIHappy;

	public float changeSpeed = 10.0f;
	public float changeTime = 0.25f;
	SpriteRenderer mySpriteRenderer;
	int currentState = 2;

    void ChangeColor(Color newColor)
    {
        //SpriteRenderer socRender = GetComponent<SpriteRenderer>();
        //socRender.color = newColor;
    }
	
		
    void OnTriggerEnter2D(Collider2D collision)
    {
		//if (collision.collider.tag=="social") {
			numBreach++;
        	//Debug.Log(numBreach);


        	if (numBreach > 3)
        	{
			ChangeState (false);
        }
    }
	//}

	void ChangeState(bool shouldIBeHappy) {
		if (shouldIBeHappy) {
			ChangeColor (comfyColor);
			amIHappy = true;
			HappyAnimation ();

		} else {
			//Debug.Log("Too Many In Social Space!");
			ChangeColor(unComfyColor);
			amIHappy = false;
			UnhappyAnimation ();
		}
		myIntrovert.spaceStateChange ();

	}

    void OnTriggerExit2D(Collider2D collision)
    {
		//if (collision.collider.tag=="social") {
        	numBreach--;
        	//Debug.Log(numBreach);

		if (numBreach > 3) {
			ChangeState (false);
		} 
		else {
			ChangeState (true);
		}
    }
	//}
    // Use this for initialization


	void Start()
	{

		mySpriteRenderer = GetComponent<SpriteRenderer> ();

		myIntrovert = GetComponentInParent<IntrovertScript> ();
		if (numBreach > 3) {
			ChangeState (false);
		} else {
			ChangeState (true);
		}

		myExtrovert = GetComponentInParent<ExtrovertScript> ();
		if (numBreach > 4) {
			ChangeState (false);
		} else {
			ChangeState (true);
		}

	}

	public void UnhappyAnimation() {
		CancelInvoke ("UnhappyAnimation");
		if (currentState != 0) {
			currentState = 0;
		}  else if (currentState == 0) {
			currentState = 1;
		}
		Invoke ("UnhappyAnimation", changeTime);
	}

	public void HappyAnimation() {
		CancelInvoke ("UnhappyAnimation");
		currentState = 2;
		mySpriteRenderer.color = comfyColor;
	}

	void Update()
	{
		if (currentState == 0) {
			mySpriteRenderer.color = Color.Lerp (mySpriteRenderer.color, unComfyColor, Time.deltaTime * changeSpeed);
		}  else if (currentState == 1) {
			mySpriteRenderer.color = Color.Lerp (mySpriteRenderer.color, comfyColor, Time.deltaTime * changeSpeed);
		}
	}
    
}
