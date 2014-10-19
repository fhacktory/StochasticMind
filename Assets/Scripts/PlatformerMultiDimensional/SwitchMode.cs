using UnityEngine;
using System.Collections;

namespace Platformer2D_3D
{
    public class SwitchMode : MonoBehaviour
    {
        public Player2D Mode2D;
        public Player3D Mode3D;

        public void SwitchCamera()
        {
            for (int i = 0; i < transform.childCount; ++i)
            {
                GameObject child = transform.GetChild(i).gameObject;
                child.SetActive(!child.activeSelf);
            }
        }

        public void SwitchMoves()
        {
            Mode2D.enabled = !Mode2D.enabled;
            Mode3D.enabled = !Mode3D.enabled;
        }
    }
}