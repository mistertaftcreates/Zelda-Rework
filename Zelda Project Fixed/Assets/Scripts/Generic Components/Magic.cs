using UnityEngine;

public class Magic : MonoBehaviour
{
    [SerializeField] private int currentMagic;
    [SerializeField] private int maxMagic;


    public bool CanUseMagic(int amountToUse)
    {
        if(currentMagic >= amountToUse)
        {
            return true;
        }
        return false;
    }

    public void UseMagic(int amountToUse)
    {
        currentMagic -= amountToUse;
        if(currentMagic<= 0)
        {
            currentMagic = 0;
        }
    }

    public void UseAllMagic()
    {
        currentMagic = 0;
    }

    public void FillMagic()
    {
        currentMagic = maxMagic;
    }

    public void AddMagic(int amountToAdd)
    {
        currentMagic += amountToAdd;
        if(currentMagic > maxMagic)
        {
            currentMagic = maxMagic;
        }
    }
}
