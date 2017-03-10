using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtSocialSpaceScript : MonoBehaviour
{
	
    //SpriteRenderer socSprite = GetComponent<SpriteRenderer>();
	public Color unComfyColor = new Color();
    public Color comfyColor = new Color();

	ExtrovertScript myExtrovert;
    private int numBreach = 0;

	public bool amIHappy;

	public float changeSpeed = 10.0f;
	public float changeTime = 0.25f;
	SpriteRenderer mySpriteRenderer;
	int currentState = 2;


    void ChangeColor(Color newColor)
    {
       // SpriteRenderer socRender = GetComponent<SpriteRenderer>();
       // socRender.color = newColor;
    }
	
	void ChangeState(bool shouldIBeHappy) {
		if (shouldIBeHappy) {
			ChangeColor (comfyColor);
			amIHappy = true;
			HappyAnimation ();

		} else {
			//Debug.Log("Too few In Social Space!");
			//ChangeColor(unComfyColor);
			amIHappy = false;
			UnhappyAnimation ();
		}
		myExtrovert.spaceStateChange ();

	}

	void OnTriggerEnter2D(Collider2D collision)
	{
		//if (collision.collider.tag=="social") {
		numBreach++;
		Debug.Log(numBreach);


		if (numBreach < 3) {

			//Debug.Log ("Too Few In Social Space!");
			//ChangeColor (unComfyColor);
			//amIHappy = false;
			ChangeState (false);
		} else {
			
			ChangeState (true);
		}
	}
	//}

	void OnTriggerExit2D(Collider2D collision)
	{
		//if (collision.collider.tag=="social") {
		numBreach--;
		Debug.Log(numBreach);

		if (numBreach < 3) {

			Debug.Log ("Too Few In Social Space!");
		
			ChangeState (false);
		}
	}
	//}
    // Use this for initialization


	void Start()
	{

		mySpriteRenderer = GetComponent<SpriteRenderer> ();

		myExtrovert = GetComponentInParent<ExtrovertScript> ();
		if (numBreach > 4) {
			ChangeState (false);
		} else if (numBreach < 1) {
			ChangeState (false);
		}else {
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
