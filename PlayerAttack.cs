using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private Animator animator;

    public Transform attackLocation;
    public float attackRange;
    public LayerMask enemieLayers;

    public int attackDamage = 1;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
            if(Input.GetMouseButtonDown(0))
            {
                {
                    attack();
                }
            }
    }
    void attack()
    {
        animator.SetTrigger("Attack");

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackLocation.position, attackRange ,enemieLayers);

        foreach(Collider2D Enemy in hitEnemies)
        {
            Enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
        }
    }
    void OnDrawGizmosSelected()
    {
        if(attackLocation == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(attackLocation.position, attackRange);
    }
}