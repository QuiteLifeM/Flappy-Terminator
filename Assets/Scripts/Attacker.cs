using System;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class Attacker : MonoBehaviour
{
    [SerializeField] private Bullet _bullet;
    [SerializeField] private float _xOffset;
    [SerializeField] float _positiveDirection;

    private Vector3 _additiveVector3;
    
    public void Attack()
    {
        _additiveVector3 = new Vector3(_xOffset, 0);
        Bullet newBullet = Instantiate(_bullet, transform.position + _additiveVector3, transform.rotation);
        newBullet.SetFly(_positiveDirection);
    }
}
