using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    Transform player;
    Vector2 dir;
    Rigidbody2D rb;
    public float speed = 2f;
    public float dmg = 20f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player").transform;
    }
    private void Update()
    {
        if (player)
            dir = (player.position - transform.position).normalized;

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = dir * speed;

        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision.gameObject.tag == "Player")
        //{
        //    collision.gameObject.GetComponent<HealthManager>().TakeDamage(dmg);
        //}
    }
}
