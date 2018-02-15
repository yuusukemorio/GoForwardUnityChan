using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour {

    private AudioSource Block;

    // Use this for initialization
    void Start()
    {
        //鳴らす音を指定
        Block = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D other) {
        if (tag == "Block") {
            //Block.PlayOneShot(Block.clip);
            Block.Play();
        }
    }
}
