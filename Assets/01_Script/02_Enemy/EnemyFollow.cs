using JetBrains.Annotations;
using UnityEngine;

public class EnemyFollow : Enemy
{
    public Transform target;
    public float speed = 5;

    void Start()
    {
        target = PlayerManager.instance.actualInput.actualPlayer.transform;
    }

    void Update()
    {
        Vector2 direction = (target.position - transform.position).normalized;    
        transform.Translate(direction*speed * Time.deltaTime);
    }
}
