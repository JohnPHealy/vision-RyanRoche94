using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;
    
    public int maxHealth = 100;
    int currentHealth;
   
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;

    }
     
   
    public void TakeDamage(int damage)
    {

        currentHealth -= damage;
        // hurt animation
        animator.SetTrigger("Hurt");

        

        if(currentHealth<= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Debug.Log("Enemy Died!!");

        // Die animation
        animator.SetBool("IsDead", true);

        //disable enemy
        this.enabled = false;
        // GetComponent<Collider2D>().enabled = false;


      
        {
            GetComponent<Patrol>().enabled = false;
        }
    }
}
