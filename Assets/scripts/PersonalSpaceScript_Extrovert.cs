using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonalSpaceScript_Extrovert : MonoBehaviour
{
	
    //SpriteRenderer socSprite = GetComponent<SpriteRenderer>();
    public Color unComfyColor = new Color();
    public Color comfyColor = new Color();

	public bool amIHappy;



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


        if (numBreach > 5)
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

		if (numBreach > 5) {

			Debug.Log ("Too Many In Personal Space!");
			ChangeColor (unComfyColor);
			amIHappy = false;
		} 
		else { 
			ChangeColor (comfyColor);
			amIHappy = true;
		}
    }

    // Use this for initialization


	void Start()
	{
	}

	void Update()
	{
  

    // Update is called once per frame
    
}
    
}
