using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DDOL : MonoBehaviour
{
    private static DDOL _instance;
    void Awake()
    {
        DontDestroyOnLoad(this);
        if (_instance == null)
            _instance = this;
        else
            Destroy(gameObject);
    }
}