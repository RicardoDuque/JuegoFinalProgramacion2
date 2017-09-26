using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour {

    public static int points = 0;
    public Text textPoints;

	// Use this for initialization
	void Start () {
        UpdatePoints();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void UpdatePoints()
    {
        textPoints.text = "Puntos: " + points; //Muestra variable points
    }

    public void GetPoints()
    {
        points++; //Suma puntos a la variable points
        UpdatePoints(); //Cada vez que ganaun punto, se muestra
    }

    public void LosePoints()
    {
        if (points > 0)
        {
            points--;
            UpdatePoints();
        }
        
    }
}
