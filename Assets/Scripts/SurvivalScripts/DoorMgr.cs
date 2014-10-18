using UnityEngine;
using System.Collections;

public class DoorMgr : MonoBehaviour {

    public GameObject[]  Doors;
    public bool          OneDoorOpened;
	// Use this for initialization

    void OnStart()
    {
        OneDoorOpened = false;
    }

    public void OpenDoor()
    {
        Doors[Random.Range(0, Doors.Length)].SetActive(false);
        OneDoorOpened = true;
    }
}
