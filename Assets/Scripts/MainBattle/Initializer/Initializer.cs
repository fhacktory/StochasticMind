using UnityEngine;
using System.Collections;

public class Initializer : MonoBehaviour {

    public GameObject gameManager;
    public GameObject characters;

	void Start ()
    {
	    if (!GameObject.FindGameObjectWithTag("GameManager"))
            DontDestroyOnLoad(Instantiate(gameManager));
        if (!GameObject.FindGameObjectWithTag("Characters"))
            DontDestroyOnLoad(Instantiate(characters));
	}
	
	void Update () {
	
	}
}
