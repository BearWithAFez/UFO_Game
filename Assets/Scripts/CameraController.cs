using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject Player;
    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - Player.transform.position;
	}
	
	// LateUpdate is called once per frame (at the end)
	void LateUpdate() {
        transform.position = Player.transform.position + offset;
	}
}
