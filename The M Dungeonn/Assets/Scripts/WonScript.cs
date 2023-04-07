using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WonScript : MonoBehaviour
{
    public Items PlayerItems;
    public GameObject Door;
    public GameObject Stick;
    [SerializeField] private AudioSource finishSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player"&& PlayerItems.Keys==2)
        {
            Stick.GetComponent<Animator>().enabled = true;
            Door.GetComponent<Animator>().enabled = true;
            gameObject.SetActive(false);
            finishSoundEffect.Play();

        }
    }
}
