using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D (Collider player)
	{
		Entered (player.gameObject);
	}
	void Entered (GameObject player)
	{

	
	}
}
