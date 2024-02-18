using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class For_Enemy : MonoBehaviour

{
    public float HP = 100f;  
    private float currentHealth;

    public Animator animator;
    void Start()
    {
        currentHealth = HP;  
    }

    public void TakeDamage(float damageAmount)
    {
        currentHealth -= damageAmount;  // Decrease the current health by the damage amount

        if (currentHealth <= 0)
        {
            animator.SetTrigger("Die");
            GetComponent<SphereCollider>().enabled = false;
            // Play Death Animation
            Die();
        }
        else
        {
            animator.SetTrigger("Damage");
        }

    }

    void Die()
    {     
        Destroy(gameObject);  
    }
}
