using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Groovebar : MonoBehaviour {
    private float time = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.Translate(0, (float)-(.4*22*Time.deltaTime), 0); //.4456 is the length of a beat or something in the bpm of the song. this should probably be a variable
        time += Time.deltaTime;
	}
}
