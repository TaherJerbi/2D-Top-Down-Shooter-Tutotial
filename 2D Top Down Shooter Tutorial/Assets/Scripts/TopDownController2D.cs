using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownController2D : MonoBehaviour
{
    public float moveSpeed = 5f;

    Vector2 movement;
    Vector2 mousePos;

    Rigidbody2D rb2d;
    public Camera cam;

    private void Awake()
    {
        cam = Camera.main;
        rb2d = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenPointToRay(Input.mousePosition).origin;


    }

    private void FixedUpdate()
    {
        rb2d.MovePosition(rb2d.position + movement * moveSpeed * Time.fixedDeltaTime);
        //rb2d.velocity = Vector2.zero;
        //Vector Math stuff ...
        Vector2 lookDir = mousePos - rb2d.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        rb2d.rotation = angle;
    }
}
