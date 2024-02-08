using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider2D))]
public class Plane : MonoBehaviour
{
    private PlaneMover _mover;

    public event UnityAction GameOver;

    private void Awake()
    {
        _mover = GetComponent<PlaneMover>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        GameOver?.Invoke();
    }

    public void ResetPlayer()
    {
        _mover.Reset();
    }
}
