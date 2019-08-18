using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayerPosition : MonoBehaviour
{
    [SerializeField] private VectorValue playerPosition;

    // Start is called before the first frame update
    void Start()
    {
        if (playerPosition)
        {
            transform.position = playerPosition.value;
        }
    }
}
