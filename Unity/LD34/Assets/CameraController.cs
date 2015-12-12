using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player1;
	public GameObject player2;

	float yOffset;
	float zOffset;
	Vector3 trans;

	// Use this for initialization
	void Start () {

	//	yOffset = transform.position.y - (player1.transform.position.y);
		zOffset = transform.position.z;
	
	}
	
	// Update is called once per frame
	void Update () {


		trans.y = (player1.transform.position.y); //- player2.transform.position.y) / 2;
		//trans.y = trans.y - yOffset;
		trans.z = zOffset;
		transform.position = trans;

	
	}
}
