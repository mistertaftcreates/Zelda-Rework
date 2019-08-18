using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoor : Interactable
{

    [SerializeField] private bool isOpen;
    [SerializeField] private BoolValue isOpenValue;
    [SerializeField] private Inventory playerInventory;
    [SerializeField] private InventoryItem keyitem;
    [SerializeField] private SpriteRenderer doorSprite;
    [SerializeField] private Collider2D doorCollider;


    // Start is called before the first frame update
    void Start()
    {
        isOpen = isOpenValue.value;
    }

    // Update is called once per frame
    void Update()
    {
        if(!isOpen && playerInRange)
        {
            if (Input.GetButtonDown("Check"))
            {
                if (PlayerHasKey())
                {
                    playerInventory.UseItem(keyitem);
                    Open();
                }
            }
        }
    }


    bool PlayerHasKey()
    {
        return playerInventory.canUseItem(keyitem);
    }

    void Close()
    {
        isOpen = false;
        doorSprite.enabled = true;
        doorCollider.enabled = true;
    }

    void Open()
    {
        isOpen = true;
        myNotification.Raise();
        doorSprite.enabled = false;
        doorCollider.enabled = false;
    }

    public override void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(otherTag) && !other.isTrigger)
        {
            playerInRange = true;
            if (!isOpen)
            {
                myNotification.Raise();
            }
        }
    }

    public override void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(otherTag) && !other.isTrigger)
        {
            playerInRange = false;
            if (!isOpen)
            {
                myNotification.Raise();
            }
        }
    }
}
