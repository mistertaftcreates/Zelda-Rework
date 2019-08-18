using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName ="Scriptable Objects/Notification", fileName ="New Notification")]
public class Notification : ScriptableObject
{
    public List <NotificationListener> listeners = new List<NotificationListener>();


    public void Raise()
    {
        for(int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].Raise();
        }
    }


    public void RegisterListener(NotificationListener listener)
    {
        if (!listeners.Contains(listener))
        {
            listeners.Add(listener);
        }
    }


    public void DeregisterListener(NotificationListener listener)
    {
        if (listeners.Contains(listener))
        {
            listeners.Remove(listener);
        }
    }
}
