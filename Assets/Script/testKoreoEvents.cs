using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;

public class testKoreoEvents : MonoBehaviour {

    public GameObject spinner;

	// Use this for initialization
	void Start () {
        Koreographer.Instance.RegisterForEvents("TestEventID", FireEventSpeen);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FireEventSpeen(KoreographyEvent korEvent)
    {
        //Debug.Log("Fired rhythm event");
        Quaternion spinpos = spinner.transform.rotation;
        spinner.transform.rotation = spinpos * Quaternion.Euler(0, 0, (float)5);
    }
}
