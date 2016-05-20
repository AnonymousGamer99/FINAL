using UnityEngine;
using System.Collections;

public class RobotFollow : MonoBehaviour {

	//You may consider adding a rigid body to the robot for accurate physics simulation
	private GameObject wayPoint;
	private Vector3 wayPointPos;
	public Transform FPSController;
	//This will be the robot's speed. Adjust as necessary.
	public float speed = 6.0f;
	void Start ()
	{
		//At the start of the game, the zombies will find the gameobject called wayPoint.
		wayPoint = GameObject.Find("wayPoint");
	}
	
	void Update ()
	{
		wayPointPos = new Vector3(wayPoint.transform.position.x, wayPoint.transform.position.y, wayPoint.transform.position.z);
		//Here, the robot will follow the waypoint.
		transform.position = Vector3.MoveTowards(transform.position, wayPointPos, speed * Time.deltaTime);
		transform.LookAt (FPSController);
	}
}
