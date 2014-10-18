using UnityEngine;
using System.Collections;

public class PlayerAttributes : MonoBehaviour
{
	public int	    life;
    public string   name;
    public Texture  owlTexture;

	void Start ()
	{
	
	}
	
	void Update ()
	{
	
	}

    void OnGUI()
    {
        GUI.DrawTexture(new Rect(-Screen.width * 0.15f, Screen.height * 0.2f,
            Screen.width * 0.8f, Screen.height * 0.9f), owlTexture);
    }
}
