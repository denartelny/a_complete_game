using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    public GameObject bullet;
    public Transform direction;
    Animator anim;
    AudioSource aud;
    public AudioClip shoot;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameObject.SetActive(true);
        aud = GetComponent<AudioSource>();
        anim = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float forvard = Input.GetAxis("Vertical") * speed;
        float left = Input.GetAxis("Horizontal") * speed;
        rb.velocity = new Vector2(left, forvard);
        if (Time.timeScale == 1)
        {
            var direction = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
            var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
        if (Input.GetMouseButtonDown(1) && Time.timeScale == 1)
        {
            Shoot();
            aud.PlayOneShot(shoot);
            anim.SetTrigger("Shake");
        }


        void Shoot()
        {
            Instantiate(bullet, direction.position, transform.rotation);
        }
       
    }
}
