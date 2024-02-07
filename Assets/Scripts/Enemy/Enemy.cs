using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Attacker))]
public class Enemy : MonoBehaviour
{
    private Attacker _attacker;
    [SerializeField] private float _delay = 5f;

    private void Awake()
    {
        _attacker = GetComponent<Attacker>();
    }

    private void Start()
    {
        StartCoroutine(SetAttack());
    }

    private IEnumerator SetAttack()
    {
        while (enabled)
        {
            _attacker.Attack();
            yield return new WaitForSeconds(_delay);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.TryGetComponent<Bullet>(out Bullet bullet))
            gameObject.SetActive(false);
    }
}