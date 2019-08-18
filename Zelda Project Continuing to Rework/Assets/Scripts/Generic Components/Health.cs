using UnityEngine;

/*
 * This script is a generic health component for
 * any item that needs to have health.  This can
 * be added to the player, enemies, pots or grass
 * in the scene.  It can also be extended by
 * inheriting from it for specific interactions desired.
 */

public class Health : MonoBehaviour
{
    [Tooltip("Max and current health \n Set this to one for pots")]
    [Header("Health values")]
    [SerializeField] public int maxHealth;
    [SerializeField] public int currentHealth;

    public void SetHealth(int amount)
    {
        currentHealth = amount;
    }

    public virtual void Damage(int damage)
    {
        currentHealth -= damage;
        if(currentHealth <= 0)
        {
            currentHealth = 0;
        }
    }

    public void Heal(int amount)
    {
        currentHealth += amount;
        if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }

    public void Kill()
    {
        currentHealth = 0;
    }

    public void FullHeal()
    {
        currentHealth = maxHealth;
    }
}
