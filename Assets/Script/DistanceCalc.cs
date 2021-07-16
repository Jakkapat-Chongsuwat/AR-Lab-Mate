using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DistanceCalc : MonoBehaviour {
	public GameObject boundary1;
	public GameObject boundary2;
	public GameObject model;
	
	

	
	// Use this for initialization
	void Start () {
		SetDistance();
		
	}
	
	// Update is called once per frame
	void Update () {
		SetDistance();

		
	}

	private void SetDistance() {

		float distance = Vector3.Distance (boundary1.transform.position, boundary2.transform.position);
		Debug.Log("distance = "+distance);

		float new_z_Position = boundary1.transform.position.z;
		new_z_Position = ((boundary1.transform.position.z-boundary2.transform.position.z)/2)+(distance*0.3497f-99.273f);
		Debug.Log (boundary1.transform.position.z-boundary2.transform.position.z);
		Debug.Log ("new z position = "+new_z_Position);
		model.transform.localScale = new Vector3(distance/2, distance/2 , distance);
		//model.transform.position =  new Vector3(boundary1.transform.position.x,boundary1.transform.position.y,new_z_Position);
		

	}
}