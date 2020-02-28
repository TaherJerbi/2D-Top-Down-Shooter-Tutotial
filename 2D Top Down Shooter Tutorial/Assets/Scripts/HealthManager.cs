using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    static float _MAXHEALTH = 100f;
    [SerializeField]
    private float health = 100f;
    public Behaviour[] disableOnDeath;
    private void Start()
    {
        health = _MAXHEALTH;
    }

    public void TakeDamage(float amount)
    {
        health -= amount;

        if (health <= 0)
        {
            health = 0;
            Die();
        }


    }
    //Anything you want to do when the player dies is coded in this function
    private void Die()
    {
        foreach (Behaviour behaviour in disableOnDeath)
        {
            behaviour.enabled = false;
        }
        Destroy(gameObject, 3f);
    }
}
