using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiveItem : MonoBehaviour
{
    [SerializeField] private SpriteRenderer mySprite;
    [SerializeField] private SpriteValue receivedSprite;
    [SerializeField] private AnimatorController anim;
    [SerializeField] private StateMachine myState;
    [SerializeField] private bool isActive = false;

    [Header("Dialog Stuff")]
    [SerializeField] private Notification dialogNotification;

    // Start is called before the first frame update
    void Start()
    {
        mySprite.enabled = false;
    }


    public void ChangeSpriteState()
    {
        Debug.Log(isActive);
        isActive = !isActive;
        Debug.Log(isActive);
        if (isActive)
        {
            DisplaySprite();
        }
        else
        {
            DisableSprite();
        }
    }


    void DisplaySprite()
    {
        myState.ChangeState(GenericState.receiveItem);
        mySprite.enabled = true;
        mySprite.sprite = receivedSprite.value;
        anim.SetAnimParameter("receiveItem", true);
        dialogNotification.Raise();
    }


    void DisableSprite()
    {
        myState.ChangeState(GenericState.idle);
        mySprite.enabled = false;
        dialogNotification.Raise();

    }
}
