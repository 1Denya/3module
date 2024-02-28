﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballCasting : MonoBehaviour
{
    public Fireball fireballPrefab;
    public Transform fireballSourceTransform;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, fireballSourceTransform.position, fireballSourceTransform.rotation);
        }
    }
}
