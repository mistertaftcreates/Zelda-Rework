using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pot : Health
{
    [SerializeField] private GameObject destroyEffect;

    // Update is called once per frame
    void Update()
    {
        if(currentHealth <= 0)
        {
            Instantiate(destroyEffect, transform.position, transform.rotation);
            this.transform.parent.gameObject.SetActive(false);
        }
    }
}
