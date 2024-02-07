using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float _speed = 8f;

    public void SetFly(float direction)
    {
        StartCoroutine(Fly(direction));
    }

    private IEnumerator Fly(float direction)
    {
        float endTime = Time.time + 6f;
            
        while (Time.time < endTime)
        {
            transform.Translate(transform.right * (direction * (Time.deltaTime * _speed)), Space.World);
            
            yield return null;
        }

        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
    }
}