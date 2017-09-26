using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawtargetCam : MonoBehaviour {


	public Transform targetCam;

	void OnDrawGizmosSelected(){
		Gizmos.color = Color.green;
		Gizmos.DrawSphere (targetCam.position, 0.15f);
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
