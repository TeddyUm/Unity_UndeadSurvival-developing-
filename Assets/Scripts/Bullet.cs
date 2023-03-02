using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage;
    public int pen;

    public void Init(float _damage, int _pen)
    {
        _damage = damage;
        _pen = pen;
    }
}
