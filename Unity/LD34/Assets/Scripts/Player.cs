using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public int playerNum;
	public float baseSpeed;
	public float accel;
	public float topSpeed;
	public float friction;

	public Vector2 velocity;
	private Rigidbody2D rigid;
	bool leftTom = false;
	bool rightTom = false;

	// Use this for initialization
	void Start () {

		rigid = GetComponent<Rigidbody2D> ();

		velocity = new Vector2 (0, baseSpeed);
		rigid.velocity = velocity;
			
	}
	
	// Update is called once per frame
	void Update () {

		ApplyAccel ();



		rigid.velocity = velocity;
	}

	void ApplyAccel ()
	{
		if (Input.GetButtonDown ("Player" + playerNum + "RightTom")) 
		{
			rightTom = true;
		}

		if (Input.GetButtonDown ("Player" + playerNum + "LeftTom")) 
		{
			leftTom = true;
		}

		if (leftTom == true && rightTom == true)
		{
			velocity += new Vector2(0,accel);
			leftTom = false;
			rightTom = false;
		}

		velocity.y -= friction / (topSpeed - velocity.y);
		print (friction / (topSpeed - velocity.y));
		if (velocity.y > topSpeed)
			velocity = new Vector2 (0, topSpeed);

		if (velocity.y < baseSpeed)
			velocity = new Vector2 (0, baseSpeed);
	}
}
