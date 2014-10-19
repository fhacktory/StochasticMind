using UnityEngine;
using System.Collections;

namespace Platformer2D_3D
{
    public class CameraManagement : MonoBehaviour
    {

        public KeyCode              SwitchCam;
        public bool                 Active3D;      

        private Transform           trans;
        private CharacterController controller;

        void Start()
        {
            trans = transform;
            controller = GetComponent<CharacterController>();
        }
        // Update is called once per frame
        void Update()
        {

            if (Input.GetKeyDown(SwitchCam))
            {
                Active3D = !Active3D;
                Transform child = trans.GetChild(0);
                SwitchMode Mode = child.GetComponent<SwitchMode>();
                Mode.SwitchCamera();
                Mode.SwitchMoves();

                if (Active3D == true)
                {
                    controller.radius = 0.3f;
                    child.localScale = new Vector3(1, 1, 1);
                }
                else
                {
                    controller.radius = 0.05f;
                    child.localScale = new Vector3(0.1f, 1f, 1f);
                }
            }
        }
    }
}