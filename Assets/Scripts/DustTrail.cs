using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem dustTrail;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player"){
            dustTrail.Play();
        }
    }
    void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.tag == "Player"){
            dustTrail.Stop();
        }
    }
}
