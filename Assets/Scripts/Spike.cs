using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spike : MonoBehaviour
{
    public GameObject playerParticle;
    public GameObject player;
   
    Animator anim;
    AudioSource aud;
    public AudioClip explosion;
    // Start is called before the first frame update
    void Start()
    {
        anim = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>();
        aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == new Vector3(0, 0, 0))
        {
            SceneManager.LoadScene(0);

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            aud.PlayOneShot(explosion);
            collision.gameObject.SetActive(false);
            Instantiate(playerParticle, collision.gameObject.transform.position, Quaternion.identity);
            anim.SetTrigger("Shake");
            Invoke("Scene", 1);
        }
        
    }
    void Scene()
    {
        //Instantiate(player, new Vector3(0, 0, 0), Quaternion.identity);
        Destroy(gameObject);
        SceneManager.LoadScene(0);
    }
}
