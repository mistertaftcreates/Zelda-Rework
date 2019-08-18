using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartManager : MonoBehaviour
{
    [SerializeField] private int maxHealth;
    [SerializeField] private FloatValue maxHealthValue;
    [SerializeField] private int currentHealth;
    [SerializeField] private FloatValue currentHealthValue;
    [SerializeField] private Image[] heartImages;
    [SerializeField] private Sprite fullSprite;
    [SerializeField] private Sprite halfFullSprite;
    [SerializeField] private Sprite emptySprite;


    public void SetupHearts()
    {
        float temp = maxHealthValue.value / 2;
        for (int i = 0; i < heartImages.Length; i++)
        {
            if(i < temp)
            {
                heartImages[i].enabled = true;
            }
            else
            {
                heartImages[i].enabled = false;
            }
        }
        float halves = currentHealthValue.value;
        for(int i = 0; i < temp; i ++)
        {
            if(halves >= 2)
            {
                halves -= 2;
                heartImages[i].sprite = fullSprite;
            }
            else if(halves == 1)
            {
                halves -= 1;
                heartImages[i].sprite = halfFullSprite;
            }
            else
            {
                heartImages[i].sprite = emptySprite;
            }
            
        }
    }
}
