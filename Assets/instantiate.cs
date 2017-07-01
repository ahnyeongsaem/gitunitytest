using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiate : MonoBehaviour {

    GameObject e;
    public GameObject hey;
	// Use this for initialization
	void Start () {
        e = Instantiate(hey);   
    }
	
	// Update is called once per frame
	void Update () {
      
        e.transform.position += new Vector3(0.05f, 0, 0);
	}
}
