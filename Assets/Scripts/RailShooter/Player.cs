using UnityEngine;
using System.Collections;

namespace RailShooter
{
    public class Player : MonoBehaviour
    {
        [SerializeField]
        private int PointsForWin = 10;
        [SerializeField]
        private GameObject cameraObj;
        [SerializeField]
        private float maxTime = 75.0f;
        private float spentTime = 0.0f;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            spentTime += Time.deltaTime;

            if (PointsForWin <= 0)
            {
                GameManager.SendResult(new GameResult(0, 0, 1));
                var enemy = GameObject.FindGameObjectWithTag("Enemy");
                var player = GameObject.FindGameObjectWithTag("Player");
                enemy.GetComponent<EnemyAttributes>().inBattle = true;
                player.GetComponent<PlayerAttributes>().inBattle = true;
                Application.LoadLevel(1);
            }
            if (spentTime >= maxTime)
            {
                GameManager.SendResult(new GameResult(0, 0, 0));
                var enemy = GameObject.FindGameObjectWithTag("Enemy");
                var player = GameObject.FindGameObjectWithTag("Player");
                enemy.GetComponent<EnemyAttributes>().inBattle = true;
                player.GetComponent<PlayerAttributes>().inBattle = true;
                Application.LoadLevel(1);
            }

            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit hit;
                Ray ray = cameraObj.camera.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out hit, 1000) && hit.transform.tag == "Enemy")
                {
                    Destroy(hit.transform.gameObject);
                    PointsForWin -= 1;
                }
            }
        }
    }
}
