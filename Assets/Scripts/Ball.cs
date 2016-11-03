using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	private Paddle paddle;
	private Vector3 paddleToBallVector;
	private bool gameStarted = false;
	public AudioClip[] sounds;
	private AudioSource chime;
	public static float ballSpeed = 8f;

//	private Vector2 ballVelocity = new Vector2 (2f, 9f); 
	
	// Use this for initialization
	void Start () {
		paddle = GameObject.FindObjectOfType<Paddle> ();
		paddleToBallVector = this.transform.position - paddle.transform.position;
	}

	void OnCollisionEnter2D(Collision2D hit){
		int rand = Random.Range (0, sounds.Length-1);
		chime = GetComponent<AudioSource> ();
		chime.clip = sounds[rand];
		chime.Play ();
	}

	public static void SetDifficulty (float speed) {
		ballSpeed = speed;
	}

		// Update is called once per frame
	void Update () {


		if (!gameStarted) {
			this.transform.position = paddle.transform.position + paddleToBallVector;

		
			if (Input.GetMouseButtonDown (0)) {
				this.GetComponent<Rigidbody2D>().velocity = new Vector2 (2f, ballSpeed);
				gameStarted = true;
			}
		}
	}
}
