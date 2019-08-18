using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SOObserver : MonoBehaviour
{
    public SOObserver instance;

    [SerializeField] private List<ScriptableObject> objectsInMemory;
    
    // Start is called before the first frame update
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
