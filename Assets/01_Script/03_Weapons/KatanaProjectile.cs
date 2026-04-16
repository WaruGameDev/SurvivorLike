using UnityEngine;

public class KatanaProjectile : MonoBehaviour
{
    public float projectileDamage;
    public float speed;
    public Vector2 direction;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<IDamageable>() != null)
        {
            collision.GetComponent<IDamageable>().OnDamage(projectileDamage);
        }
    }
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }


}
