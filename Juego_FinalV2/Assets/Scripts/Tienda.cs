using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tienda : MonoBehaviour {

    public Sprite redCharacter, greenCharacter;
    private SpriteRenderer spr;
    public MovementNoForces movScript;
    private bool redOn, greenOn;

	void Start () {
        spr = movScript.GetComponent<SpriteRenderer>();
        greenOn = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PoneSprites()
    {
        spr.sprite = greenCharacter;

        if (spr.sprite == greenCharacter)
        {
            greenOn = true;
        }
    }

}
