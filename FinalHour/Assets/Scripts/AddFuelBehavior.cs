using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddFuelBehavior : MonoBehaviour {

    public Camera mainCam;
    private Rigidbody2D rb;
    private Transform tf;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        tf = GetComponent<Transform>();
        rb.velocity = new Vector2(-10, 0);
    }

    void Update()
    {
        if (tf.position.x < (mainCam.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x - 2f))
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        string gameObj = collision.GetComponent<Collider2D>().tag;
        if ((gameObj == "Ship"))
        {
            collision.GetComponent<ShipControls>().addFuel(100f);
            Destroy(this.gameObject);
        }
    }
}
