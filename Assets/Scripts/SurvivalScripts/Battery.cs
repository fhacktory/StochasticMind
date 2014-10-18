using UnityEngine;
using System.Collections;

public class Battery : MonoBehaviour {

    public bool     activated;
    public float    maxLvl;

    private float   energyLvl;
    private Light   light;
	// Use this for initialization
	void Start () {
        activated = true;
        energyLvl = maxLvl;
        light = transform.GetChild(0).GetComponent<Light>();
        StartCoroutine("DecreaseEnergyLevel");
	}
	
	// Update is called once per frame
	void Update () {
        if (energyLvl <= 3.5f)
            light.intensity = energyLvl;

        if (energyLvl <= 0)
            activated = false;
	}

    void OnGUI()
    {
        GUI.Label(new Rect(10, Screen.height - 100, 100, 100), "Battery Level: " + energyLvl);
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
        }
    }
}
