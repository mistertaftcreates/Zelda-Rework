using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogController : MonoBehaviour
{
    [SerializeField] private StringValue stringText;
    [SerializeField] private Notification dialogNotification;
    [SerializeField] private TextMeshProUGUI dialogText;
    [SerializeField] private GameObject dialogObject;
    [SerializeField] private bool dialogActive = false;

    public void ActivateDialog()
    {
        dialogActive = !dialogActive;
        if (dialogActive)
        {
            SetDialog();
        }
        else
        {
            DeactivateDialog();
        }
    }

    void SetDialog()
    {
        dialogObject.SetActive(true);
        dialogText.text = stringText.value;
    }

    void DeactivateDialog()
    {
        dialogObject.SetActive(false);
    }

}
