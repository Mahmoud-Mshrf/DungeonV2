using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player_life : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    [SerializeField] GameObject[] Axes;
    [SerializeField] private AudioSource DeathSoundEffect;

    // Start is called before the first frame update
    void Start()
    { 

       rb = GetComponent<Rigidbody2D>();
       anim = GetComponent<Animator>();
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            Die();
            DeathSoundEffect.Play();

        }
        if (collision.gameObject.CompareTag("KILLFloor"))
        {
            Axes[0].SetActive(true);
            Axes[1].SetActive(true);
        }
    }
    private void Die()
    {
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("Death");
    }
    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}

