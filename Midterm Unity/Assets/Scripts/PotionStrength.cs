﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionStrength : MonoBehaviour
{
    public ParticleSystem ps;
    private float currentLifetime;

    private void Start()
    {
        
    }

    private void Update()
    {
        currentLifetime = (0.8f + GameManager.Instance.score / 15);
        ps.startLifetime = currentLifetime;
    }
}
