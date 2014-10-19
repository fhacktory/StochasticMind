using UnityEngine;
using System.Collections;

public class PlayerAttributes : MonoBehaviour
{
	public int	    life;
    public int      defence;
    public string   playerName;
    public Texture  owlTexture;
    public bool     inBattle;

	void Start ()
	{
	    playerName = "Leon";
	}
	
	void Update ()
	{
        if (0 == life)
            Application.LoadLevel(8);
	}

    void OnGUI()
    {
        if (inBattle)
            GUI.DrawTexture(new Rect(-Screen.width * 0.15f, Screen.height * 0.2f,
                Screen.width * 0.8f, Screen.height * 0.9f), owlTexture);
    }

    public static PlayerAttributes operator+(PlayerAttributes player, GameResult result)
    {
        if ((player.life < 5 && result.life > 0) || result.life < 0)
            player.life += result.life;

        player.defence += result.defence;
        GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyAttributes>().life -= result.damages;

        return player;
    }
}
