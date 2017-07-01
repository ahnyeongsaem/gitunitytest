using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecube : MonoBehaviour {

    float speed = 20;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Time.deltaTime*5, 0, 0);
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
