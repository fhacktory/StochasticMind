using UnityEngine;
using System.Collections;

namespace ShootEmUp
{
    public class Player : MonoBehaviour
    {

        [SerializeField]
        private uint life = 5u;
        [SerializeField]
        private float firePerSecond = 2.0f;
        [SerializeField]
        private float constantSpeed = 2.0f;
        [SerializeField]
        private float ZAxisSpeed = 2.0f;
        [SerializeField]
        private float XAxisSpeed = 2.0f;
        [SerializeField]
        private GameObject bullet;
        [SerializeField]
        private int TriggersToWin = 3;


        [SerializeField]
        private KeyCode forward = KeyCode.W;
        [SerializeField]
        private KeyCode backward = KeyCode.S;
        [SerializeField]
        private KeyCode right = KeyCode.D;
        [SerializeField]
        private KeyCode left = KeyCode.A;
        [SerializeField]
        private KeyCode shoot = KeyCode.Space;
        [SerializeField]
        private KeyCode fly = KeyCode.LeftShift;

        [SerializeField]
        private Transform[] fireStart;
        private Transform trans;
        private Transform rootTrans;
        private bool canFire = true;

        // Use this for initialization
        void Start()
        {
            trans = transform;
            rootTrans = trans.root.transform;

        }

        // Update is called once per frame
        void Update()
        {

            Vector3 direction = rootTrans.forward * constantSpeed;

            if (Input.GetKey(forward))
                direction += rootTrans.forward * ZAxisSpeed;
            else if (Input.GetKey(backward))
                direction += -rootTrans.forward * ZAxisSpeed;
            if (Input.GetKey(right))
                direction += rootTrans.right * XAxisSpeed;
            else if (Input.GetKey(left))
                direction += -rootTrans.right * XAxisSpeed;

            rootTrans.Translate(direction * Time.deltaTime, Space.World);

            if (Input.GetKey(shoot) && bullet != null && canFire)
            {
                foreach (Transform fire in fireStart)
                {
                    Vector3 firePosition;

                    if (fireStart != null)
                        firePosition = fire.position;
                    else
                        firePosition = rootTrans.position;

                    GameObject go = Instantiate(bullet, firePosition, Quaternion.identity) as GameObject;
                    go.transform.forward = go.transform.up;
                    StartCoroutine("ReloadFire");
                }
            }

            if (life <= 0)
            {
                Destroy(trans.root.gameObject);
                GameManager.SendResult(new GameResult(0, 0, 0));
                var enemy = GameObject.FindGameObjectWithTag("Enemy");
                var player = GameObject.FindGameObjectWithTag("Player");
                enemy.GetComponent<EnemyAttributes>().inBattle = true;
                player.GetComponent<PlayerAttributes>().inBattle = true;
                Application.LoadLevel(1);
            }
            if (TriggersToWin <= 0)
            {
                GameManager.SendResult(new GameResult(0, 0, 1));
                var enemy = GameObject.FindGameObjectWithTag("Enemy");
                var player = GameObject.FindGameObjectWithTag("Player");
                enemy.GetComponent<EnemyAttributes>().inBattle = true;
                player.GetComponent<PlayerAttributes>().inBattle = true;
                Application.LoadLevel(1);
            }
        }

        void OnTriggerEnter(Collider hit)
        {
            if (hit.tag == "Terrain")
                Destroy(gameObject);
            else if (hit.tag == "TerrainTrigger")
                TriggersToWin -= 1;

            else
                life -= 1;
        }

        IEnumerator ReloadFire()
        {
            canFire = false;
            yield return new WaitForSeconds(1 / firePerSecond);
            canFire = true;
        }
    }
}