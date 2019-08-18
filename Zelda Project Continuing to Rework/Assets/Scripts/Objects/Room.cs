using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Room : MonoBehaviour
{
    [Header("Room Notifications")]
    [SerializeField] private string roomName;
    [SerializeField] private StringValue roomNameHolder;
    [SerializeField] private Notification roomnotification;
    [SerializeField] private string playerTag;
    [SerializeField] private GameObject[] respawnObjects;
    [SerializeField] private GameObject thisCamera;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag(playerTag) && !other.isTrigger)
        {
            thisCamera.SetActive(true);
            roomNameHolder.value = roomName;
            roomnotification.Raise();
            RespawnObjects();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(playerTag) && !other.isTrigger)
        {
            thisCamera.SetActive(false);
            DespawnObjects();
        }
    }

    void RespawnObjects()
    {
        for(int i = 0; i < respawnObjects.Length; i++)
        {
            respawnObjects[i].SetActive(true);
            Health temp = respawnObjects[i].GetComponentInChildren<Health>();
            if (temp)
            {
                temp.FullHeal();
            }
            ResetToPosition reset = respawnObjects[i].GetComponent<ResetToPosition>();
            if (reset)
            {
                reset.ResetPosition();
            }
        }
    }

    void DespawnObjects()
    {
        for (int i = 0; i < respawnObjects.Length; i++)
        {
            respawnObjects[i].SetActive(false);
        }
    }
}
