﻿using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour {
	static Music instance = null;

	void Awake () {
		if (instance != null) {
			Destroy (gameObject);
		} else {
			instance = this;
			GameObject.DontDestroyOnLoad (gameObject);
		}
	}

}