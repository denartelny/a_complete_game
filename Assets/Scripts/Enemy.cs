using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   public Transform Player;
    public float speed;
    void Start()
    {
      
    }
    void Update()
    {
        if (Player.gameObject.activeSelf.Equals(true))
        {
            transform.position = Vector2.MoveTowards(transform.position, Player.position, speed * Time.deltaTime);
        }
        
        
    }
}
