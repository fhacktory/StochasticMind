using UnityEngine;
using System.Collections;

public class EnemyAttributes : MonoBehaviour
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
        GUI.DrawTexture(new Rect(Screen.width * 0.3f, -Screen.height * 0.05f,
            Screen.width * 0.75f, Screen.height * 0.75f), owlTexture);
    }
}
