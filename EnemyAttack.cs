using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public Transform eal;
    public float ar;
    public LayerMask el;

    public int EattackDamage = 1;

    public float mm=0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        mm=mm+Time.deltaTime;
        
        if(mm>=1)
        {
            EAttack();
            mm=0f;
        }
    }
    public void EAttack()
    {
        Collider2D[] hitP = Physics2D.OverlapCircleAll(eal.position, ar ,el);
        foreach(Collider2D player in hitP)
        {
            player.GetComponent<HeroKnight>().TakeDamage(EattackDamage);
        }
    }
}
