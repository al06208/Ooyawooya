using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticBullet : MonoBehaviour {
    public GameObject player;
    public Collider2D nut;
    private float life;
    private void Start()
    {
        player = GameObject.Find("PlayerHolder");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        nut = collision;
        Debug.Log("FUNNY SCREAM");
        if(collision.tag == "Player")
        {
            player.GetComponent<playermover>().kill();
        }
    }
    private void Update()
    {
        life += Time.deltaTime;
        if (life > 5)
            GameObject.Destroy(gameObject);
    }
}
