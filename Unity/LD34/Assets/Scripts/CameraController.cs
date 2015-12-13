using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject myPlayer;
	public GameObject enemyPlayer;
	public float splitThreshold = 2.5f;

	//float yOffset;
	//float zOffset;
	Vector3 offset;
	Vector3 trans;
	float playerGap;

	// Use this for initialization
	void Start () {

		//yOffset = transform.position.y - (player1.transform.position.y);
		//zOffset = transform.position.z;

		offset = new Vector3 (transform.position.x, transform.position.y - (myPlayer.transform.position.y), transform.position.z);
	
	}
	
	// Update is called once per frame
	void Update () {

		playerGap = (myPlayer.transform.position.y - enemyPlayer.transform.position.y);

		if (playerGap >= splitThreshold || playerGap <= -splitThreshold) 
		{
			trans.y = myPlayer.transform.position.y + offset.y;
			trans.x = offset.x;
			trans.z = offset.z;
		} 
		else
		{
			trans.y = playerGap / 2;
			trans.y = enemyPlayer.transform.position.y + trans.y;

			trans.x = offset.x;
			trans.y = trans.y + offset.y;
			trans.z = offset.z;
		}

		transform.position = trans;
	}
}
