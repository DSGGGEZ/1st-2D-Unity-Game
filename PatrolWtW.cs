using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PatrolWtW : MonoBehaviour
{
    public float speed = 1f;
    public float mm = 0f;
    public float limit =2f;
    public Transform target;
    private bool iw = true;

    public bool movingRight = true;
    private Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        anim.SetBool("IsWalk", iw);
    }
    
    void Update()
    {
        mm += Time.deltaTime;
        
        if(mm<limit)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Rotate(new Vector3(0, -180, 0), Space.Self);
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            mm=0;
        }
    }
    
}