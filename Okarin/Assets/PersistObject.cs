using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistObject : MonoBehaviour {

    // Use this for initialization
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
