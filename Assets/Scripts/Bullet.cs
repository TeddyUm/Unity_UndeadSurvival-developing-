using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage;
    public int pen;
    public int bulletSpeed = 10;

    Rigidbody2D rigid;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    public void Init(float _damage, int _pen, Vector3 _dir)
    {
        damage = _damage;
        pen = _pen;

        if(pen > -1)
        {
            rigid.velocity = _dir * bulletSpeed;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy") || pen == -1)
        {
            return;
        }

        pen--;

        if(pen == -1)
        {
            rigid.velocity = Vector2.zero;
            gameObject.SetActive(false);
        }
    }
}
