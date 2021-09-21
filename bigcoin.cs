using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bigcoin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Collider2D c;
        if (!GetComponent<Collider2D>())
        {
            c = gameObject.AddComponent<BoxCollider2D>();
        }
        else
        {
            c = GetComponent<Collider2D>();
        }
        c.isTrigger = true;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {   
        //saveScore
        if(collision.gameObject.CompareTag("Player"))
        {
            Text txt;
            txt = GameObject.Find("/Canvas/Text").GetComponent<Text>();
            Gamemanager.nScore+=10; 
            txt.text = "" + Gamemanager.nScore;

            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
        
            Debug.Log("Coin Collected!");
            Destroy(gameObject,0.5f);
        }

        //Add sound
        //AudioSource audio = GetComponent<AudioSource>();
        //audio.Play();
        
        //Destroy(gameObject,0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
