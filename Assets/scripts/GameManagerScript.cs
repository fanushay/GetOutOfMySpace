using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManagerScript : MonoBehaviour
{
	public List<IntrovertScript> introverts = new List<IntrovertScript>();
	public List<IntrovertScript> happyIntroverts = new List<IntrovertScript>();
	public List<IntrovertScript> unhappyIntroverts = new List<IntrovertScript>();
	public GameObject youWin;
	public GameObject Next;
	public GameObject Quit1;
	bool ableToWin = false;


	//extroverts
	public List<ExtrovertScript> extroverts = new List<ExtrovertScript>();
	public List<ExtrovertScript> happyExtroverts = new List<ExtrovertScript>();
	public List<ExtrovertScript> unhappyExtroverts = new List<ExtrovertScript>();


	/*
    //Personal Space and Social Space Minimum and Maximum Values
    [Header("Introverts")]
    public GameObject introvertPrefab;
    //number of Introverts
    //public int[] NumberOfIntros;
    public int numIntros;
    //introveert personal space
    public int introPersMin;
    public int introPersMax;
    //introvert social space
    public int introSocMin;
    public int introSocMax;

    [Header("Extroverts")]
    public GameObject extrovertPrefab;
    //number of Extroverts
    public int numExtros;
    //extrovert personal space
    public int extroPersMin;
    public int extroPersMax;
    //extrovert social space
    public int extroSocMin;
    public int extroSocMax;

    [Header("Friends A")]
    public GameObject friendAPrefab;
    //number of Friendss
    public int numFriendsA;
    //friends personal space
    public int friendAPersMin;
    public int friendAPersMax;
    //friends social space
    public int friendASocMin;
    public int friendASocMax;

    [Header("Friends B")]
    public GameObject friendBPrefab;
    //number of Friendss
    public int numFriendsB;
    //friends personal space
    public int friendBPersMin;
    public int friendBPersMax;
    //friends social space
    public int friendBSocMin;
    public int friendBSocMax;

    [Header("Couples")]
    public GameObject couplePrefab;
    //number of Couples
    public int numCouples;
    //couples personal space
    public int couplePersMin;
    public int couplePersMax;
    //couples social space
    public int coupleSocMin;
    public int coupleSocMax;

	*/

    

    

    
    

    //Create Coordinates For each Character
    
    


    // Use this for initialization
    void Start()
    {
		Invoke ("EnableWinCondition", 0.5f);

    }

	void EnableWinCondition() {
		ableToWin = true;
	}
	public void happyChecker (IntrovertScript receivedIntrovert){

		happyIntroverts.Clear ();
		unhappyIntroverts.Clear ();

		foreach (IntrovertScript eachIntrovert in introverts) {

			if (eachIntrovert.amIHappy == true) {
				happyIntroverts.Add (eachIntrovert);
			}
			if (eachIntrovert.amIHappy == false) {
				unhappyIntroverts.Add (eachIntrovert);
			}

			if (ableToWin) {
				if (happyIntroverts.Count == introverts.Count && happyExtroverts.Count == extroverts.Count) {
					Debug.Log ("You win");
					youWin.SetActive (true);
					Next.SetActive(true);
					Quit1.SetActive(true);
				}

			}
		}
	}

	public void happyChecker (ExtrovertScript receivedExtrovert){

		happyExtroverts.Clear ();
		unhappyExtroverts.Clear ();

		foreach (ExtrovertScript eachExtrovert in extroverts) {

			if (eachExtrovert.amIHappy == true) {
				happyExtroverts.Add (eachExtrovert);
			}
			if (eachExtrovert.amIHappy == false) {
				unhappyExtroverts.Add (eachExtrovert);
			}

			if (ableToWin) {
				if (happyIntroverts.Count == introverts.Count &&  happyExtroverts.Count == extroverts.Count) {
//					Debug.Log ("You win");
					youWin.SetActive(true);
					Next.SetActive(true);
					Quit1.SetActive(true);

				}

			}
		}
	}


}
