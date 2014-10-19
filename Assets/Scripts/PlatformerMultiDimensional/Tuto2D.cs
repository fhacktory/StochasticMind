using UnityEngine;
using System.Collections;

namespace Platformer2D_3D
{
public class Tuto2D : MonoBehaviour {

    public GUIStyle         Style;
    public CameraManagement CamData;
    private bool            IsHitting;

    void Start()
    {
        IsHitting = false;
    }

    void OnGUI()
    {
        if (CamData.Active3D == false && IsHitting)
            GUI.Label(new Rect(Screen.width / 2 - 250, 20, 250, 100), "You should press " + CamData.SwitchCam + " and see what's the problem...", Style);
        else if (CamData.Active3D && IsHitting)
            GUI.Label(new Rect(Screen.width / 2 - 250, 20, 250, 100), "When you're in 2D your character can pass through narrow place but it requires to be well placed !", Style);
    }

    void OnTriggerStay(Collider hit)
    {
        if (hit.tag == "Player")
            IsHitting = true;
    }

    void OnTriggerExit(Collider hit)
    {
        if (hit.tag == "Player")
            IsHitting = false;
    }
}
}