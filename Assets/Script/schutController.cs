using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;

public class schutController : MonoBehaviour {
    public GameObject bullet;

    //I set up angles and positions instead of making patterns fired by functions because........ 

    Vector2 diagright15 = new Vector2((float).65, (float)-.97);
    Vector2 diagleft15 = new Vector2((float)-.65, (float)-.97);
    Vector2 diagright5 = new Vector2(15, -150);
    Vector2 diagleft5 = new Vector2(-15, -150);
    //this is so fucking stupid
    Vector3 left = new Vector3(-5, -1, 0);
    Vector3 mid = new Vector3(0, -1, 0);
    Vector3 right = new Vector3(5, -1, 0);
    Vector3 hleft = new Vector3((float)-2.5, -1, 0);
    Vector3 hright = new Vector3((float)2.5, -1, 0); 

    void Start () {
        diagright15 *= 150;
        diagleft15 *= 150;
        //this was originally a debug bullet but because it plays on startup and the music also plays then I use it to shoot the first bullet. In the future, this will not be the case. Hopefully.
        Koreographer.Instance.RegisterForEvents("bulletKoreo", FireEvent);
        GameObject bull1 = Object.Instantiate(bullet, gameObject.transform.position + mid, Quaternion.identity);
        bull1.GetComponent<Rigidbody2D>().AddForce(diagleft15);
        GameObject bull2 = Object.Instantiate(bullet, gameObject.transform.position + mid, Quaternion.identity);
        bull2.GetComponent<Rigidbody2D>().AddForce(diagright15);
    }

    void FireEvent(KoreographyEvent korEvent)
    {
        //koreographer events can have a payload associated with them; the koreography for the bullets uses integer payloads
        int type = korEvent.GetIntValue();
        //again. Why did I not just make fucking functions?
        switch (type)
        {
            case 2:
                GameObject bull4 = Object.Instantiate(bullet, gameObject.transform.position + hleft, Quaternion.identity);
                GameObject bull5 = Object.Instantiate(bullet, gameObject.transform.position + hright, Quaternion.identity);
                bull4.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -150));
                bull5.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -150));
                break;
            case 3:
                GameObject bull1 = Object.Instantiate(bullet, gameObject.transform.position + left, Quaternion.identity);
                GameObject bull2 = Object.Instantiate(bullet, gameObject.transform.position + mid, Quaternion.identity);
                GameObject bull3 = Object.Instantiate(bullet, gameObject.transform.position + right, Quaternion.identity);
                bull1.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -150));
                bull2.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -150));
                bull3.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -150));
                break;
            case 4:
                GameObject bull6 = Object.Instantiate(bullet, gameObject.transform.position + mid, Quaternion.identity);
                bull6.GetComponent<Rigidbody2D>().AddForce(diagleft15);
                GameObject bull7 = Object.Instantiate(bullet, gameObject.transform.position + mid, Quaternion.identity);
                bull7.GetComponent<Rigidbody2D>().AddForce(diagright15);
                break;
            case 5:
                GameObject bull8 = Object.Instantiate(bullet, gameObject.transform.position + mid, Quaternion.identity);
                bull8.GetComponent<Rigidbody2D>().AddForce(diagleft5);
                GameObject bull9 = Object.Instantiate(bullet, gameObject.transform.position + mid, Quaternion.identity);
                bull9.GetComponent<Rigidbody2D>().AddForce(diagright5);
                break;
            default:
                break;
        }
    }
}
