/*********************************************
NAME: Elijah Tong
Student Number: 101126281
Source File:BulletController.cs
Last Modified: 2020-10-21
Description: Moves bullets horizontally across the screen and returns bullets once they get off screen or hit and enemy for later use. 
Previous Version: This used to move bullets vertically until they went off screen or hit an enemy.
*********************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour, IApplyDamage
{
    //public variables
    public float HorizontalSpeed;
    public float HorizontalBoundary;
    public BulletManager bulletManager;
    public int damage;
    
    // Start is called before the first frame update
    void Start()
    {
        bulletManager = FindObjectOfType<BulletManager>();
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        //Bullets moving from left to right 
        transform.position += new Vector3(HorizontalSpeed, 0.0f, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        if (transform.position.x > HorizontalBoundary)
        {
            bulletManager.ReturnBullet(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log(other.gameObject.name);
        bulletManager.ReturnBullet(gameObject);
    }

    public int ApplyDamage()
    {
        return damage;
    }
}
