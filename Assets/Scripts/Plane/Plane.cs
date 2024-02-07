using System;
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
        ResetPlayer();
    }

    public void ResetPlayer()
    {
        GameOver?.Invoke();
        _mover.Reset();
    }
}
