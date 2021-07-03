﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energy_create : MonoBehaviour
{
    [SerializeField] private float span = 3f;
    public GameObject Energy_parent;

    private void Start()
    {
        StartCoroutine("Create_Energy");
    }

    IEnumerator Create_Energy()
    {
        while (true)
        {
            yield return new WaitForSeconds(span);
            Debug.LogFormat("{0}秒経過", span);
        }
    }
}
