﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    // public Material originalMaterial;
    public Color originalColor;
    public Renderer originalRender;


    void Start()
    {
        originalRender = GetComponent<Renderer>();
        originalColor = GetComponent<Renderer>().material.color;
        // originalColor = GetComponent<Renderer>().material.GetColor();
    }
    public void Yellow()
    {
        GetComponent<Renderer>().material.color = Color.blue;
    }
    public void Red()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
    public void Origin()
    {
        originalRender.material.color = originalColor;
    }
    public void Green()
    {
        GetComponent<Renderer>().material.color = Color.green;
    }
}
