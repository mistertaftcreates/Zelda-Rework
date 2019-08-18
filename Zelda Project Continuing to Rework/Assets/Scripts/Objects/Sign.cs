using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sign : Interactable
{
    [SerializeField] private Notification signNotification;
    [SerializeField] private StringValue signText;
    [SerializeField] private string newSignText;
    [SerializeField] private bool dialogActive = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInRange)
        {
            if(Input.GetButtonDown("Check"))
            {
                dialogActive = !dialogActive;
                signText.value = newSignText;
                signNotification.Raise();
            }
        }
    }

    public override void OnTriggerExit2D(Collider2D other)
    {
        base.OnTriggerExit2D(other);
        if(other.gameObject.CompareTag(otherTag) && !other.isTrigger)
        {
            if (dialogActive)
            {
                dialogActive = !dialogActive;
                signNotification.Raise();
            }
        }
    }

}
