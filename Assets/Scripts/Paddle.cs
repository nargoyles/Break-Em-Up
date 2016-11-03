using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	void MoveWithMouse () {
		float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
		Vector3 paddlePos = new Vector3 (0.5f, this.transform.position.y, 0);
		
		paddlePos.x = Mathf.Clamp (mousePosInBlocks, 0.75f, 15.25f);
		
		this.transform.position = paddlePos;
	}
	// Update is called once per frame
	void Update () {
			MoveWithMouse ();
	}
}
