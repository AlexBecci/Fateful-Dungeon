using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveVolumenScene : MonoBehaviour
{
    private SaveVolumenScene instace;
    public SaveVolumenScene Instance
    {
        get
        {
            return instace;
        }
    }

    // Update is called once per frame
    
    private void Awake()
    {
        if(FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }

        else if(instace!= null && instace != this)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            instace = this;
        }

        DontDestroyOnLoad(gameObject);
    }
      
    
}
