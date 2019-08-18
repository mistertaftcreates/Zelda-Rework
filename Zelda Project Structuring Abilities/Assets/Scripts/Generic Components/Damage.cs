using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public void ApplyDamage(Health otherHealth, int damageToGive)
    {
        if (otherHealth)
        {
            otherHealth.Damage(damageToGive);
        }
    }
}
