﻿using UnityEngine;
using System;
using System.Collections;

public class Battery : MonoBehaviour {

    public bool     activated;
    public float    maxLvl;

    private float   energyLvl;
    private Light   torch;
	// Use this for initialization
	void Start () {
        activated = true;
        energyLvl = maxLvl;
        torch = transform.GetChild(0).GetComponent<Light>();
        StartCoroutine("DecreaseEnergyLevel");
	}
	
	// Update is called once per frame
	void Update () {
        if (energyLvl <= 3.5f)
            torch.intensity = energyLvl;

        if (energyLvl <= 0)
            activated = false;
	}

    void OnGUI()
    {
        GUI.Label(new Rect(10, Screen.height - 100, 120, 50), "Battery Level: " + Math.Round(energyLvl).ToString());
    }

    IEnumerator DecreaseEnergyLevel()
    {
        while (true)
        {      
            if (activated)
                energyLvl -= 0.5f;
            else if (energyLvl < maxLvl)
                energyLvl += 0.4f;
            yield return new WaitForSeconds(0.5f);
            if (energyLvl > maxLvl)
                energyLvl = maxLvl;
        }
    }
}
