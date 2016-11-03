using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour
{
	public static int score;
	public Text text;
	
	void Awake ()
	{
		text = GameObject.FindGameObjectWithTag ("score").GetComponent <Text> ();
	}
	
	public void ResetScore() {
		score = 0;
	}

	void Update ()
	{
		text.text = "Score: " + score;
	}
}