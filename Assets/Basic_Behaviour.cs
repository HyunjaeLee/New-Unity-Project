using UnityEngine;
using System.Collections;

public class Basic_Behaviour : MonoBehaviour {

	public int Speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W))
			transform.Translate (Vector3.forward*Speed*Time.deltaTime);
		if (Input.GetKey (KeyCode.A))
			transform.Translate (Vector3.left*Speed*Time.deltaTime);
		if (Input.GetKey (KeyCode.S))
			transform.Translate (Vector3.back*Speed*Time.deltaTime);
		if (Input.GetKey (KeyCode.D))
			transform.Translate (Vector3.right*Speed*Time.deltaTime);
	}
}
