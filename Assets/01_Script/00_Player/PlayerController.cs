using JetBrains.Annotations;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5;   
    public Rigidbody2D rb;
   
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();       
    }  
    
    public virtual void Move(Vector2 direction)
    {
       
    }
}
