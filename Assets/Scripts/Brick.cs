using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	private int count;
	public Sprite[] hitSprites;
	private bool isBreakable;
	public static int breakableCount = 0;
	private LevelManager levelManager;

	// Use this for initialization
	void Start () {
		levelManager = GameObject.FindObjectOfType<LevelManager> ();
		count = 0;
		isBreakable = (this.tag == "brick");
		if (isBreakable) {
			breakableCount++;
		}
	}

	void OnCollisionEnter2D(Collision2D hit) {
		 if (isBreakable) {
			HandleHits ();
		}
	}

	void HandleHits() {
		count++;
		Score.score += 20;
		int maxHits = hitSprites.Length + 1;
		if (count >= maxHits) {
			breakableCount--;
			levelManager.BrickDestroyed();
			Destroy (gameObject);
		} else {
			LoadSprites ();
		}
	}
		
		void LoadSprites(){
		int spriteIndex = count - 1;
		if (hitSprites [spriteIndex]) {
			this.GetComponent<SpriteRenderer> ().sprite = hitSprites [spriteIndex];
		}
	}

	// Update is called once per frame
	void Update () {

		}

			
	
}
