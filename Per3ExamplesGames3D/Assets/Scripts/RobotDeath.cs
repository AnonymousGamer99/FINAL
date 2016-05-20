using UnityEngine;
using System.Collections;

public class RobotDeath : MonoBehaviour {
	public GameObject Directional_Light;
	public GameObject FPSController;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter (Collider other){
		Application.LoadLevel ("GameOver");
		Destroy (Directional_Light);
		Destroy (FPSController);
	}
}
