using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : Health
{
    [SerializeField] private FlashColor flash;

    public override void Damage(int damage)
    {
        base.Damage(damage);
        if(currentHealth > 0)
        {
            if (flash)
            {
                flash.StartFlash();
            }
        }
    }
}
