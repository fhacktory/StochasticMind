using UnityEngine;
using System.Collections;

public class ButtonMainMenu : MonoBehaviour
{
    public Font     textFont;

	void Start ()
    {
	
	}
	
	void Update ()
    {
	
	}

    void OnGUI()
    {
        var buttonStyle = new GUIStyle(GUI.skin.button);

        buttonStyle.font = textFont;
        buttonStyle.fontSize = (int)(Screen.width * 0.04f);
        buttonStyle.normal.textColor = new Color(0.3f, 0.6f, 0.2f);

        if (GUI.Button(new Rect(Screen.width * 0.4f, Screen.height * 0.1f,
            Screen.width * 0.2f, Screen.height * 0.2f), "Main Menu", buttonStyle))
            Application.LoadLevel(0);
    }
}
