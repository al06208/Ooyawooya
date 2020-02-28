using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//is this script even necessary? Probably not
public class GrooveZone : MonoBehaviour {
    public string key;
    // Use this for initialization
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("groove detected");
        if(collision.tag == "groove")
        {
            if (Input.GetKeyDown(key))
            {
                GameObject.Destroy(collision.gameObject);
            }
        }
    }
}
