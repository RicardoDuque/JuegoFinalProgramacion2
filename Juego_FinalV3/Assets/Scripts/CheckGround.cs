using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Asignar etiquetas "Ground" a los elementos suelo en Unity

public class CheckGround : MonoBehaviour {

	//private PlayerController player;
	private MovementNoForces moveNoFor;

	// Use this for initialization
	void Start () {
		//player = GetComponentInParent<PlayerController>();
		moveNoFor = GetComponentInParent<MovementNoForces> ();
	}
	
	// Método para comprobar colisiones
	void OnCollisionStay2D(Collision2D col) {
		if (col.gameObject.tag == "Ground")//Comprobar si colisionador tiene etiqueta "Ground"
			//player.grounded = true;
			moveNoFor.grounded = true;	

		if (col.gameObject.tag == "PlatformMoving")
			moveNoFor.grounded = true;
	}

	// Método para salir de la colisión
	void OnCollisionExit2D(Collision2D col) {
		if (col.gameObject.tag == "Ground")
			//player.grounded = false;
			moveNoFor.grounded = false;

		if (col.gameObject.tag == "PlatformMoving")
				moveNoFor.grounded = false;
	}
}
