using System.Collections;
using UnityEditor.ShaderGraph;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{
    public float currentHp;
    public float maxHP;
    public SpriteRenderer spriteRenderer;
    public void OnDamage(float damage)
    {
        currentHp -= damage;
        if(currentHp <= 0)
        {
            Destroy(gameObject);
        }
    }
    IEnumerator Feedback()
    {
        spriteRenderer.color = Color.red;
        yield return new WaitForSeconds(.2f);
        spriteRenderer.color = Color.red;
        yield break;
    }
   
}
