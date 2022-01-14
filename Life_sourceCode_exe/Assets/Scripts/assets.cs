using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assets : MonoBehaviour
{
    private static assets _instance;

    public static assets instance()
    {
            return _instance;
    }

    private void Awake()
    {
        _instance = this;
    }

    public Transform Friend;

}
