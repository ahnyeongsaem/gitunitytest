using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecube : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Time.deltaTime*100 , 0, 0);
        transform.Rotate(0, Time.deltaTime * 100, 0);
        transform.Rotate(0, 0, Time.deltaTime * 100);
    }
}
