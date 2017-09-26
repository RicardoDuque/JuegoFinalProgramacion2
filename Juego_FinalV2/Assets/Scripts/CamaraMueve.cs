using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraMueve : MonoBehaviour {

	public Transform targetCam;
	public float speed;
	private Vector3 start, end;

	void OnDrawGizmosSelected(){
		Gizmos.DrawSphere (targetCam.position, 0.15f);
	}

	// Use this for initialization
	void Start () {
		if (targetCam != null) {
			targetCam.parent = null; //El target ya va a ser independiente y no se moverá con la plataforma, se queda en la misma posición
			start = transform.position;  //Posición inciial de la platforma
			end = targetCam.position; //Posición final de la plataforma, cuando llega al target
		}
			
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate(){
		if (targetCam != null){
			float fixedSpeed = speed * Time.deltaTime; //Velocidad multiplicada por el deltaTime(segs)
			transform.position = Vector3.MoveTowards (transform.position, targetCam.position, fixedSpeed); //Mueve entre transformPosition(actual)
			//y la posición del target con X velocidad
		}
		/*
		if (transform.position == targetCam.position) { //Si la posición de la plataforma es igual a la posición del target

			//target.position = (target.position == start) ? end : start)://Si targetPosition es igual a la start entonces, target position
			//tendrá valor de end, si no tendrá valor de start
			if (targetCam.position == start)
				targetCam.position = end;
			else
				targetCam.position = start;

		}
*/

	}

}
