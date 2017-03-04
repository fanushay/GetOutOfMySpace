using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocialSpaceScript_Extrovert : MonoBehaviour
{
	
    //SpriteRenderer socSprite = GetComponent<SpriteRenderer>();
    public Color unComfyColor = new Color();
    public Color comfyColor = new Color();



    private int numBreach = 0;

	public bool amIHappy = false;

	

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


		if (numBreach < 2) {

			Debug.Log ("Too Few In Social Space!");
			ChangeColor (unComfyColor);
			amIHappy = false;
		} else {
			ChangeColor (comfyColor);
			amIHappy = true;
		}
    }
	//}

    void OnTriggerExit2D(Collider2D collision)
    {
		//if (collision.collider.tag=="social") {
        	numBreach--;
        	Debug.Log(numBreach);

		if (numBreach < 2) {

			Debug.Log ("Too Few In Social Space!");
			ChangeColor (unComfyColor);
			amIHappy = false;
		} 
		/*else {
			ChangeColor (comfyColor);
			amIHappy = true;
		}*/
    }
	//}
    // Use this for initialization


	void Start()
	{
	}

	void Update()
	{
  

    // Update is called once per frame
    
}
    
}
