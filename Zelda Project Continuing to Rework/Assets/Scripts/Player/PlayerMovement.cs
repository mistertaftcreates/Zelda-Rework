using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : Movement
{
    [SerializeField] private AnimatorController anim;
    [SerializeField] private StateMachine myState;
    [SerializeField] private float WeaponAttackDuration;
    [SerializeField] private ReceiveItem myItem;

    private Vector2 tempMovement = Vector2.down;


    // Start is called before the first frame update
    void Start()
    {
        myState.ChangeState(GenericState.idle);
    }

    // Update is called once per frame
    void Update()
    {
        if(myState.myState == GenericState.receiveItem)
        {
            if(Input.GetButtonDown("Check"))
            {
                myState.ChangeState(GenericState.idle);
                anim.SetAnimParameter("receiveItem", false);
                myItem.ChangeSpriteState();
            }
            return;
        }
        GetInput();
        SetAnimation();
    }


    void SetState(GenericState newState)
    {
        myState.ChangeState(newState);
    }


    void GetInput()
    {
        if(Input.GetButtonDown("Weapon Attack"))
        {
            StartCoroutine(WeaponCo());
            tempMovement = Vector2.zero;
            Motion(tempMovement);
        }
        else if (myState.myState != GenericState.attack)
        {
            tempMovement.x = Input.GetAxisRaw("Horizontal");
            tempMovement.y = Input.GetAxisRaw("Vertical");
            Motion(tempMovement);
        }
        else
        {
            tempMovement = Vector2.zero;
            Motion(tempMovement);
        }
    }

    void SetAnimation()
    {
        if (tempMovement.magnitude > 0)
        {
            anim.SetAnimParameter("moveX", Mathf.Round(tempMovement.x));
            anim.SetAnimParameter("moveY", Mathf.Round(tempMovement.y));
            anim.SetAnimParameter("moving", true);
            SetState(GenericState.walk);
        }
        else
        {
            anim.SetAnimParameter("moving", false);
            if(myState.myState != GenericState.attack)
            {
                SetState(GenericState.idle);
            }
        }
    }

    public IEnumerator WeaponCo()
    {
        myState.ChangeState(GenericState.attack);
        anim.SetAnimParameter("attacking", true);
        yield return new WaitForSeconds(WeaponAttackDuration);
        myState.ChangeState(GenericState.idle);
        anim.SetAnimParameter("attacking", false);
    }
}
