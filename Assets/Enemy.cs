using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{

    //public float health = 50f;
    public NavMeshAgent enemy;
    public Transform Player;
    [SerializeField] private float time = 5;
    private float bulletTime;
    //public float enemyspeed;
    public GameObject enemyBullet;
    public Transform spawnPoint;
    [SerializeField] private enemydata DM;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (Player != null)
        {
            enemy.SetDestination(Player.position);
            ShootAtPlayer();
            LookAtPlayer();

        }
    }

    public void ShootAtPlayer()
    {
        bulletTime -= Time.deltaTime;

        if (bulletTime > 0) return;
        {
            bulletTime = time;

            GameObject bulletObj = Instantiate(enemyBullet, spawnPoint.transform.position, spawnPoint.transform.rotation) as GameObject;
            Rigidbody bulletRig = bulletObj.GetComponent<Rigidbody>();
            bulletRig.AddForce(-bulletRig.transform.forward * DM.m_speed, ForceMode.Impulse);
            Destroy(bulletObj, 1f);
        }
    }
    public void LookAtPlayer()
    {
        var heading = transform.position - Player.position;
        var rotation = Quaternion.LookRotation(heading);
        transform.rotation = rotation;
    }

    //public void TakeDamage(int damageAmount)
    // {
    //  health -= damageAmount;
    // Die();
    //}

    //    void Die()
    // {
    //        Destroy(gameObject);
    //}
}

