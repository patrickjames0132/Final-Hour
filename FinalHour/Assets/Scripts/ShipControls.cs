using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShipControls : MonoBehaviour {

    public KeyCode space;
    private Animator anim;
    private Rigidbody2D rb;
    private float fuel;
    private float time;
    private float bestTime;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        anim.SetBool("ShipIdle", true);
        anim.SetBool("ShipThrust", false);
        fuel = 500f;
    }

    // Update is called once per frame
    void Update()
    {
        if (isFuel())
        {
            if (Input.GetKey(space))
            {
                rb.AddForce(new Vector2(0, 20));
                fuel--;
            }
            if (Input.GetKeyDown(space))
            {
                anim.SetBool("ShipIdle", false);
                anim.SetBool("ShipThrust", true);

            }
            else if (Input.GetKeyUp(space))
            {
                anim.SetBool("ShipIdle", true);
                anim.SetBool("ShipThrust", false);
            }
        }
        else
        {
            anim.SetBool("ShipIdle", true);
            anim.SetBool("ShipThrust", false);
        }
    }

    private bool isFuel()
    {
        if (fuel <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string gameObj = collision.collider.tag;
        bestTime = PlayerPrefs.GetFloat("bestTime");

        if (gameObj == "Asteroid")
        {
            time = Time.timeSinceLevelLoad;
            if (time > bestTime)
            {
                PlayerPrefs.SetFloat("bestTime", time);
            }
            StartCoroutine(Wait(1));
        }

        if (gameObj == "BottomWall")
        {
            time = Time.timeSinceLevelLoad;
            if (time > bestTime)
            {
                Debug.Log("HERE1");
                PlayerPrefs.SetFloat("bestTime", time);
            }
            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
        }
    }

    public float getFuel()
    {
        return fuel;
    }

    public void addFuel(float fuel)
    {
        this.fuel += fuel;
        return;
    }

    private IEnumerator Wait(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
    }
}
