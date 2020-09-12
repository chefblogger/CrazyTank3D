using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{

    public GameObject player;
    public GameObject feind;

    public float entfernung;

    //public AudioSource alarmsound;

    // Start is called before the first frame update
    void Start()
    {
        //alarmsound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        entfernung = Vector3.Distance(player.transform.position, feind.transform.position);

        if (entfernung < 50){
            //alarmsound.Play();
            gameObject.renderer.material.color = Color.red;
            Debug.Log("ALARM");
        }
    }
}
