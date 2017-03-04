using System.Collections;
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

	

    void ChangeColor(Color newColor)
    {
        SpriteRenderer socRender = GetComponent<SpriteRenderer>();
        socRender.color = newColor;
    }
	
		
    void OnTriggerEnter2D(Collider2D collision)
    {
		//if (collision.collider.tag=="social") {
			numBreach++;
        	Debug.Log(numBreach);


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

		} else {
			Debug.Log("Too Many In Social Space!");
			ChangeColor(unComfyColor);
			amIHappy = false;
		}
		myIntrovert.spaceStateChange ();

	}

    void OnTriggerExit2D(Collider2D collision)
    {
		//if (collision.collider.tag=="social") {
        	numBreach--;
        	Debug.Log(numBreach);

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

	void Update()
	{
  

    // Update is called once per frame
    
}
    
}
