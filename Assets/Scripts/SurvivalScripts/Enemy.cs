using UnityEngine;
using System.Collections;

namespace Survival
{

    public class Enemy : MonoBehaviour
    {

        public GameObject Target;

        private NavMeshAgent agent;

        // Use this for initialization
        void Start()
        {
            agent = GetComponent<NavMeshAgent>();
        }

        // Update is called once per frame
        void Update()
        {
            agent.SetDestination(Target.transform.position);
        }

        void OnCollisionEnter(Collision hit)
        {
            if (hit.transform.tag == "Player")
            {
                GameManager.SendResult(new GameResult(-1, 0, 0));
                var enemy = GameObject.FindGameObjectWithTag("Enemy");
                var player = GameObject.FindGameObjectWithTag("Player");
                enemy.GetComponent<EnemyAttributes>().inBattle = true;
                player.GetComponent<PlayerAttributes>().inBattle = true;
                Application.LoadLevel(1);
            }
        }
    }
}