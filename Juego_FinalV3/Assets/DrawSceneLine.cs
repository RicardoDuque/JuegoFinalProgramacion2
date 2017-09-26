using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawSceneLine : MonoBehaviour {

	public Transform from, to; //Punto de inicio y de llegada de donde se va a dibujar la línea


	void OnDrawGizmosSelected(){
		if (from != null && to != null){
			Gizmos.color = Color.red;
			Gizmos.DrawLine (from.position, to.position);
			Gizmos.DrawSphere (from.position, 0.15f);
			Gizmos.DrawSphere (to.position, 0.15f);
		}
	}


}
