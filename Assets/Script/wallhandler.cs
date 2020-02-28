using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallhandler : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "bullet")
        {
            GameObject.Destroy(collision.gameObject);
        }
    }
}
