using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float timeBtwAttack;
    public float startTimaBtwAttack;
    public int health;
    public float speed;
    public Transform player;
    private void Start()
    {
        
    }
    private void Update()
    {
        if(health<=0)
        {
            Destroy(gameObject);
        }
        if(player.transform.position.x>transform.position.x)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
    }
}
