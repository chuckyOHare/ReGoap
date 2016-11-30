﻿using UnityEngine;
using System.Collections;

public class ResourcesBagSensor : GoapSensor {
    private ResourcesBag resourcesBag;

    void Awake()
    {
        resourcesBag = GetComponent<ResourcesBag>();
    }

    void FixedUpdate()
    {
        var state = memory.GetWorldState();
        foreach (var pair in resourcesBag.GetResources())
        {
            state.Set("has" + pair.Key, pair.Value > 0);
        }
    }
}