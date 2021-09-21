using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class character_controller : MonoBehaviour {

    public float speed;
    int jump;
    float x, sx;
    bool ks;
    Animator anim;
    Rigidbody2D rb;
    // Use this for initialization
    void Start()
    {
        // Clear Score
        // game_manager.gameScore = 0;

        // Set jump
        jump = 0;

        // Set animator
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sx = transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        // Check falling y axis
        if(anim.transform.position.y < -5f)
        {
            Reload();
        }
        x = Input.GetAxis("Horizontal");
        anim.SetFloat("speed", Abs(x));
        if (Input.GetButtonDown("Jump") && jump < 3)
        {
            jump++;
            anim.SetBool("jump", true);
            rb.velocity = new Vector2(rb.velocity.x, 5f);
        }
        rb.velocity = new Vector2(x * speed, rb.velocity.y);
        if (x > 0)
        {
            transform.localScale = new Vector3(sx, transform.localScale.y, transform.localScale.z);
        }
        if (x < 0)
        {
            transform.localScale = new Vector3(-sx, transform.localScale.y, transform.localScale.z);
        }

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        anim.SetBool("jump", false);
        jump = 0;
    }
    float Abs(float x)
    {
        return x >= 0f ? x : -x;
    }
    public void Reload()
    {
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene);
        
        // Clear Score
        PlayerPrefs.DeleteKey("saveScore");
        PlayerPrefs.DeleteKey("addScore");
        Time.timeScale = 1;
    }
}
