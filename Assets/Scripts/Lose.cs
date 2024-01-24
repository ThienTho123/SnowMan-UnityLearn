using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{
    [SerializeField] float loadDelay = 1f;
    [SerializeField] ParticleSystem loseEffect;
    [SerializeField] AudioClip audioSFX;
    bool deadth = false ;
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Round" && deadth ==false)
        {
            FindObjectOfType<Move>().DisableControl();
            loseEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(audioSFX);
            deadth = true;
            Invoke("LoadScene", loadDelay);
        }
    }
    void LoadScene()
    {
        SceneManager.LoadScene(0);
    }

}
