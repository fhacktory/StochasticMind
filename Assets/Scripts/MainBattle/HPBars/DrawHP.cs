using UnityEngine;
using System.Collections;

public class DrawHP : MonoBehaviour
{
    public Texture  enemyLifeTexture;
    public Texture  playerLifeTexture;
    public Texture  lifeBarTexture;

    private EnemyAttributes     enemyAttributes;
    private PlayerAttributes    playerAttributes;

    void Start()
    {
        enemyAttributes = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyAttributes>();
        playerAttributes = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerAttributes>();
    }

    void Update()
    {

    }

    void OnGUI()
    {
     //   GUI.DrawTexture(new Rect(Screen.width * 0.14f, Screen.height * 0.08f,
    //        Screen.width * 0.37f, Screen.height * 0.1f), lifeBarTexture);

        for (int i = 1 ; i <= enemyAttributes.life ; i++)
        {
            GUI.DrawTexture(new Rect(Screen.width * 0.2f + i * 55, Screen.height * 0.113f,
                Screen.width * 0.028f, Screen.height * 0.05f), enemyLifeTexture);
        }

     //   GUI.DrawTexture(new Rect(Screen.width * 0.7f, Screen.height * 0.6f,
       //     Screen.width * 0.35f, Screen.height * 0.1f), lifeBarTexture);
        for (int i = 1; i <= playerAttributes.life; i++)
        {
            GUI.DrawTexture(new Rect(Screen.width * 0.5f + i * 55, Screen.height * 0.7f,
                Screen.width * 0.028f, Screen.height * 0.05f), playerLifeTexture);
        }
    }
}
