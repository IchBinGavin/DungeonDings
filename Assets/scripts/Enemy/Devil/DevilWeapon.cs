using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevilFireBall : MonoBehaviour
{
    
    public GameObject fireBallPrefab;
    public Transform firepoint;
    private float fireforce = 3f;
    private GameObject player;

    private float baseDamage = 3f;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public float GetDamage()
    {
        return baseDamage;
    }


    public void fireFireball()
    {

        GameObject bullet = Instantiate(fireBallPrefab, firepoint.position, firepoint.rotation);
        bullet.GetComponent<Rigidbody2D>().velocity = (player.transform.position - transform.position).normalized * fireforce;
        

        
    }
}
