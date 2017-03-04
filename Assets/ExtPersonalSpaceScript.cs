using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtPersonalSpaceScript : MonoBehaviour
{
	
    //SpriteRenderer socSprite = GetComponent<SpriteRenderer>();
    public Color unComfyColor = new Color();
    public Color comfyColor = new Color();

	public bool amIHappy;

	ExtrovertScript myExtrovert;

    private int numBreach = 0;

	

    void ChangeColor(Color newColor)
    {
        SpriteRenderer persRender = GetComponent<SpriteRenderer>();
        persRender.color = newColor;
    }
	
		
    void OnTriggerEnter2D(Collider2D collision)
    {
        numBreach++;
        Debug.Log(numBreach);


        if (numBreach > 2)
        {

            Debug.Log("Too Many In Personal Space!");
            ChangeColor(unComfyColor);
			amIHappy = false;
        }
    }


    void OnTriggerExit2D(Collider2D collision)
    {
        numBreach--;
        Debug.Log(numBreach);

		if (numBreach > 2) {

			Debug.Log ("Too Many In Personal Space!");
			ChangeColor (unComfyColor);
			amIHappy = false;
		} 
		else { 
			ChangeColor (comfyColor);
			amIHappy = true;
		}
    }

	void ChangeState(bool shouldIBeHappy) {
		if (shouldIBeHappy) {
			ChangeColor (comfyColor);
			amIHappy = true;

		} else {
			Debug.Log("Too Many In Social Space!");
			ChangeColor(unComfyColor);
			amIHappy = false;
		}

		myExtrovert.spaceStateChange ();
	}

    // Use this for initialization


	void Start()
	{



		myExtrovert = GetComponentInParent<ExtrovertScript> ();
		if (numBreach > 2) {
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
