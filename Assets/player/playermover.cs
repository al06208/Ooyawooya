using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playermover : MonoBehaviour {

    public GameObject player;
    private BoxCollider2D playerColl;
    public Collider2D targ;
    public string str;
	// Use this for initialization
	void Start () {
        playerColl = player.GetComponent<BoxCollider2D>();
	}
	
    public void kill()
    {
        GameObject.Destroy(gameObject);
    }
	// Update is called once per frame

	void Update () {
        str = "";
        var vert = Input.GetAxis("Vertical");
        var horiz = Input.GetAxis("Horizontal");
        Vector2 mod = Vector2.zero;
        if (vert > 0)
        {
            mod += new Vector2(0, (float).251);
        }
        else if(vert < 0)
        {
            mod += new Vector2(0, (float)-.251);
        }
        if (horiz > 0)
        {
            mod += new Vector2((float).251, 0);
        }
        else if (horiz < 0)
        {
            mod += new Vector2((float)-.251, 0);
        }

        if(vert == 0 && horiz == 0)
        {
            //nothin
        }
        else
        {
            Vector2 move = new Vector2((float)(0.25) * horiz, (float)(0.25) * vert);
            Debug.DrawRay(playerColl.transform.position, move);
            RaycastHit2D hit = Physics2D.Raycast((Vector2)playerColl.transform.position+mod, 2*move);
            if (hit)
            {
                targ = hit.collider;
                str = targ.tag;
                if (str == "playarea" && hit.distance < 0.001)
                {
                    move = Vector2.zero;
                }
            }

            playerColl.transform.Translate(move);

        }

        


    }
}
