using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnContact : Damage
{
    [SerializeField] private string otherString;
    [SerializeField] private int damageAmount;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(otherString))
        {
            Health temp = other.gameObject.GetComponent<Health>();
            if (temp)
            {
                ApplyDamage(temp, damageAmount);
            }
        }
    }
}
