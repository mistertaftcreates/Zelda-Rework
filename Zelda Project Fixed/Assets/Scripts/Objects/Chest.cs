using UnityEngine;

public class Chest : Interactable
{

    [SerializeField] private AnimatorController anim;
    [SerializeField] private BoolValue openValue;
    [SerializeField] private bool isOpen;
    [SerializeField] private Notification chestNotification;
    [SerializeField] private SpriteValue spriteValue;
    [SerializeField] private StringValue itemString;
    [SerializeField] private InventoryItem myItem;
    [SerializeField] private Inventory playerInventory;

    // Start is called before the first frame update
    void Start()
    {
        isOpen = openValue.value;
        if (isOpen)
        {
            anim.SetAnimParameter("open", true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(playerInRange && Input.GetButtonUp("Check"))
        {
            if (isOpen)
            {
                return;
            }
            DisplayContents();
        }
    }


    void DisplayContents()
    {
        isOpen = !isOpen;
        anim.SetAnimParameter("open", true);
        openValue.value = isOpen;
        spriteValue.value = myItem.mySprite;
        itemString.value = myItem.myDescription;
        chestNotification.Raise();
        playerInventory.AddItem(myItem);
        myNotification.Raise();
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
