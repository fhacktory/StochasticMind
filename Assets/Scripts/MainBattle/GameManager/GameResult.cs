using UnityEngine;
using System.Collections;

public class GameResult
{
    public int      life;
    public int      defence;
    public int      damages;

    public GameResult(int life, int defence, int damages)
    {
        this.life = life;
        this.defence = defence;
        this.damages = damages;
    }
}
