using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Bullet : MonoBehaviour
{
    public float speed;
    public float DestroyTime;
    public GameObject enemyParticle;
    Animator anim;
    AudioSource aud;
    public AudioClip explosion;


    void Start()
    {
        Invoke("DestroyBullet", DestroyTime);
        anim = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>();
        aud = GetComponent<AudioSource>();
    }
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
    void DestroyBullet()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            anim.SetTrigger("Shake");
            Destroy(collision.gameObject);
            Instantiate(enemyParticle, collision.gameObject.transform.position, Quaternion.identity);
            aud.PlayOneShot(explosion);

        }
    }
}
