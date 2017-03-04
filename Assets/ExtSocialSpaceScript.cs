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

	

    void ChangeColor(Color newColor)
    {
        SpriteRenderer socRender = GetComponent<SpriteRenderer>();
        socRender.color = newColor;
    }
	
	void ChangeState(bool shouldIBeHappy) {
		if (shouldIBeHappy) {
			ChangeColor (comfyColor);
			amIHappy = true;

		} else {
			Debug.Log("Too few In Social Space!");
			ChangeColor(unComfyColor);
			amIHappy = false;
		}
		myExtrovert.spaceStateChange ();

	}

	void OnTriggerEnter2D(Collider2D collision)
	{
		//if (collision.collider.tag=="social") {
		numBreach++;
		Debug.Log(numBreach);


		if (numBreach < 3) {

			Debug.Log ("Too Few In Social Space!");
			ChangeColor (unComfyColor);
			amIHappy = false;
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


		myExtrovert = GetComponentInParent<ExtrovertScript> ();
		if (numBreach > 4) {
			ChangeState (false);
		} else if (numBreach < 1) {
			ChangeState (false);
		}else {
			ChangeState (true);
		}

	}

	void Update()
	{
		

    // Update is called once per frame
    
}
    
}
