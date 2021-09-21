using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public Animator anim;
    public int maxHealth = 2;
    int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }
    public void TakeDamage(int damage)
    {
        anim.SetBool("IsAttack", true);
        currentHealth -= damage;
        
        if(currentHealth<=0)
        {
            anim.SetBool("Isdead", true);
            Die();
            Destroy(gameObject);

            Text txt;
            txt = GameObject.Find("/Canvas/Text").GetComponent<Text>();
            Gamemanager.nScore+=10; 
            txt.text = "" + Gamemanager.nScore;
        }
    }
    void Die()
    {
        Debug.Log("Enemy died!");

        anim.SetBool("Isdead", true);

        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
    }
}
