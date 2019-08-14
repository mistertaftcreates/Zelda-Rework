using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetToPosition : MonoBehaviour
{

    [SerializeField] private Vector2 resetPosition;

    public void ResetPosition()
    {
        transform.localPosition = resetPosition;
    }
}
