using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float                Speed;
    public float                RotateSpeed;
    public GUIStyle             Style;

    [SerializeField]
    private KeyCode Up;
    [SerializeField]
    private KeyCode Down;
    [SerializeField]
    private KeyCode Left;
    [SerializeField]
    private KeyCode Right;
    [SerializeField]
    private KeyCode Action;
    [SerializeField]
    private KeyCode Light;

    private Transform           trans;
    private CharacterController controller;
    private Light               lightComponent;
    private DoorMgr             doorManager;
    private bool                isHitting;
	// Use this for initialization
	void Start () {
        trans = transform;
        controller = GetComponent<CharacterController>();
        controller.SimpleMove(new Vector3(0, 0, 0));
        lightComponent = trans.GetChild(0).GetComponent<Light>();
        doorManager = GameObject.FindGameObjectWithTag("Maze").GetComponent<DoorMgr>();
	}
	
	// Update is called once per frame
    void Update()
    {
        if (Input.GetKey(Up))
        {
            controller.SimpleMove(Vector3.forward * Speed);
            trans.rotation = Quaternion.Lerp(trans.rotation, Quaternion.Euler(0, 0, 0), Time.deltaTime * RotateSpeed);
        }
        if (Input.GetKey(Left))
        {
            controller.SimpleMove(Vector3.left * Speed);
            trans.rotation = Quaternion.Lerp(trans.rotation, Quaternion.Euler(0, -90, 0), Time.deltaTime * RotateSpeed);
        }
        if (Input.GetKey(Down))
        {
            controller.SimpleMove(Vector3.back * Speed);
            trans.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 180, 0), Time.deltaTime * RotateSpeed);
        }
        if (Input.GetKey(Right))
        {
            controller.SimpleMove(Vector3.right * Speed);
            trans.rotation = Quaternion.Lerp(trans.rotation, Quaternion.Euler(0, 90, 0), Time.deltaTime * RotateSpeed);
        }
        if (Input.GetKeyDown(Light))
            lightComponent.enabled = !lightComponent.enabled;
    }

    void OnGUI()
    {
        if (isHitting)
        {
            if (doorManager.OneDoorOpened == false)
                GUI.Label(new Rect(Screen.width / 2 - 100, 100, 100, 50), "Press " + Action + " to unlock a door", Style);
            else
                GUI.Label(new Rect(Screen.width / 2 - 100, 100, 100, 50), "Something has moved...", Style);
        }
    }

    void OnTriggerStay(Collider hit)
    {
        if (hit.tag == "Switch")
        {
            isHitting = true;         
            if (Input.GetKey(Action) && doorManager.OneDoorOpened == false)
                doorManager.OpenDoor();
        }
    }

    void OnTriggerExit()
    {
        isHitting = false;
    }
}
