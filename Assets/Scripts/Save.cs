﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour
{
    private void Start()
    {
        PlayerPrefs.Save();
    }
}
