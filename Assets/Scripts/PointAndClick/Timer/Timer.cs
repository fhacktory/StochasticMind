using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

    public float    time;

	void Start ()
    {
	
	}

	void Update ()
    {
        time -= Time.deltaTime;
	}

    void OnGUI()
    {
        GUI.Label(new Rect(0, 0, 200, 50), "Time: " + time);
        var mice = GameObject.FindGameObjectsWithTag("Mouse");
        if (mice.Length < 3)
            GUI.Label(new Rect(0, 50, 200, 50), "Win");
        else if (time <= 0.0f)
            GUI.Label(new Rect(0, 50, 200, 50), "Lose");

    }
}
