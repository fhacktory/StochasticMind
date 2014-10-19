using UnityEngine;
using System.Collections;

public class EnemyAttributes : MonoBehaviour
{
	public int	    life;
    public string   enemyName;
    public Texture  owlTexture;
    public bool     inBattle = true;

	void Start ()
	{
        enemyName = "Noel";
	}
	
	void Update ()
	{
        if (0 == life)
            Application.LoadLevel(9);
	}

    void OnGUI()
    {
        if (inBattle)
            GUI.DrawTexture(new Rect(Screen.width * 0.3f, -Screen.height * 0.05f,
                Screen.width * 0.75f, Screen.height * 0.75f), owlTexture);
    }
}
