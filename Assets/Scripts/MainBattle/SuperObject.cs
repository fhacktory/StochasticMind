﻿using UnityEngine;
using System.Collections;

public class SuperObject : MonoBehaviour {

    public bool win;
    

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}