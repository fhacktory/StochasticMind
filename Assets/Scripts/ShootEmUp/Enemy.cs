using UnityEngine;
using System.Collections;

namespace ShootEmUp
{
    public class Enemy : MonoBehaviour
    {

        [SerializeField]
        private int life = 5;
        [SerializeField]
        private float firePerSecond = 2.0f;
        [SerializeField]
        private float speed = 2.0f;
        [SerializeField]
        private GameObject bullet;
        [SerializeField]
        private Transform[] fireStart;
        private Transform trans;

        // Use this for initialization
        void Start()
        {

            trans = transform;
            StartCoroutine("Fire");

        }

        // Update is called once per frame
        void Update()
        {

            trans.Translate(trans.forward * speed * Time.deltaTime, Space.World);

            if (life <= 0)
                Destroy(gameObject);

        }

        IEnumerator Fire()
        {
            while (true)
            {
                yield return new WaitForSeconds(1 / firePerSecond);

                if (bullet != null)
                {
                    foreach (Transform fire in fireStart)
                    {
                        Vector3 firePosition;
                        Vector3 forward;

                        if (fire != null)
                        {
                            firePosition = fire.position;
                            forward = fire.forward;
                        }

                        else
                        {
                            firePosition = trans.position;
                            forward = trans.forward;
                        }

                        Debug.DrawRay(fire.position, fire.forward * 100, Color.yellow);

                        GameObject go = Instantiate(bullet, firePosition, Quaternion.identity) as GameObject;
                        go.transform.up = forward;

                    }
                }
            }
        }

        void OnTriggerEnter()
        {
            life -= 1;
        }
    }
}
