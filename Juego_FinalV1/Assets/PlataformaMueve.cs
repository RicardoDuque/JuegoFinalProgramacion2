using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaMueve : MonoBehaviour {

	public Transform target;
	public float speed;
	private Vector3 start, end; //Determinar posición de inicio y final para que cambie cuando llegue al final


	// Use this for initialization
	void Start () {
		if (target != null) {
			target.parent = null; //El target ya va a ser independiente y no se moverá con la plataforma, se queda en la misma posición
			start = transform.position;  //Posición inciial de la plaatforma
			end = target.position; //Posición final de la plataforma, cuando llega al target
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate(){
		if (target != null){
			float fixedSpeed = speed * Time.deltaTime; //Velocidad multiplicada por el deltaTime(segs)
			transform.position = Vector3.MoveTowards (transform.position, target.position, fixedSpeed); //Mueve entre transformPosition(actual)
																								   //y la posición del target con X velocidad
		}

		if (transform.position == target.position) { //Si la posición de la plataforma es igual a la posición del target

			//target.position = (target.position == start) ? end : start)://Si targetPosition es igual a la start entonces, target position
			//tendrá valor de end, si no tendrá valor de start
			if (target.position == start)
				target.position = end;
			else
				target.position = start;

		}


	}
}
