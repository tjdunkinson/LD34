using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	
	public GameObject player1;
	public GameObject player2;

	public GameObject[] obstacles;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}
	void OnTriggerEnter2D (Collider2D winner)
	{
		if (winner.gameObject == player1)
		{
			Player1Win();
		}
		if (winner.gameObject == player2)
		{
			Player2Win();
		}
	}

	void Player1Win ()
	{
		print ("Player 1 Wins!");
	}

	void Player2Win ()
	{
		print ("Player 2 Wins!");
	}
}
