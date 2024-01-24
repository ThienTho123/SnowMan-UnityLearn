using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTail : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] ParticleSystem dustailEffect;
    void OnCollisionEnter2D(Collision2D other) {
        if(other.collider.tag== "Round")
        {
            dustailEffect.Play();
        }
    }
    void OnCollisionExit2D(Collision2D other) {
        if(other.collider.tag== "Round")
        {
            dustailEffect.Stop();
        }

    }
}
