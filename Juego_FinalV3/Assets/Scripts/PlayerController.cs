using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed = 2f; //Modificador velocidad 
	public float maxSpeed = 5f; //Limitador velocidad
	public bool grounded;//Saber si estamos tocando el suelo
	public float jumpPower = 6.5f; //Variable para el salto
	private Animator anim; //Importar animaciones
	private Rigidbody2D rb2d; //Importar RigidBody
	private bool jump; //Para detectar botón

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> (); //Fuerza RigidBody // Hace referencia al RigidBody del objeto Player	
		anim = GetComponent<Animator>();//Importar animaciones del Player
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate() //Es mejor usarlo que usar el Update
	{
		float h = Input.GetAxis ("Horizontal");
		rb2d.AddForce (Vector2.right * speed * h); //Vector de fuerza del Rigidbody 
		//Vector que apunta hacia la derecha un unidad, se multiplica por la velocidad 
		//establecida y la dirección (h)
		//Debug.Log (rb2d.velocity.x); //Para que aparezca la velocidad en X en consola
		Debug.Log(h);
		//Limitamos velocidad MODO 1
		/*
		if (rb2d.velocity.x > maxSpeed)
			rb2d.velocity = new Vector2 (maxSpeed, rb2d.velocity.y);
		if (rb2d.velocity.x < -maxSpeed) 
			rb2d.velocity = new Vector2 (-maxSpeed, rb2d.velocity.y);
		*/
		//Limitamos la velocidad MODO 2
		float limitedSpeed = Mathf.Clamp (rb2d.velocity.x, -maxSpeed, maxSpeed);
		rb2d.velocity = new Vector2 (limitedSpeed, rb2d.velocity.y);

		if (Input.GetAxis ("Horizontal") == 0) //Frena al soltar tecla
			rb2d.velocity = new Vector2 (0, rb2d.velocity.y);
	
		anim.SetFloat ("Speed", Mathf.Abs (rb2d.velocity.x)); //Mathf.Abs: Busca el valor absoluto o la distancia que hay entre un punto
		//y otro punto, independientemente de si es positivo o negativo, es la dist. 
		anim.SetBool ("Grounded", grounded);//Saber si estamos tocando el suelo


		//Para que compruebe si va hacia la derecha o hacia la izquierda y gire el personaje
		if (h > 0.1f)
			transform.localScale = new Vector3 (1f, 1f, 1f);
		if (h < -0.1f)
			transform.localScale = new Vector3 (-1f, 1f, 1f);

		if (Input.GetKeyDown (KeyCode.UpArrow) && grounded)
			jump = true;

		if (jump) {
			rb2d.AddForce (Vector2.up * jumpPower, ForceMode2D.Impulse);
			jump = false;
		}
	}

}
