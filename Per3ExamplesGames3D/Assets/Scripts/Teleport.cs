using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {

	public GameObject FPSController;
	public float x;
	public float y;
	public float z;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other){
		FPSController.transform.position = new Vector3(x,y,z);
	}
}
