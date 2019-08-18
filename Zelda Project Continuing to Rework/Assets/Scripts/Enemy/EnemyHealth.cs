using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : Health
{

    [SerializeField] private GameObject deathEffect;


    public override void Damage(int damage)
    {
        base.Damage(damage);
        if(currentHealth <= 0)
        {
            Die();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    void Die()
    {
        
        Instantiate(deathEffect, transform.position, transform.rotation);
        this.transform.parent.gameObject.SetActive(false);
    }

}
