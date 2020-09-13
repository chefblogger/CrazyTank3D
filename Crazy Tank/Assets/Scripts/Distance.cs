using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{

    public GameObject player;
    public GameObject feind;



    public float entfernung;

    private float aktiv = 0;


    public float AlarmRadius = 100f;

    
    

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

        if (entfernung < AlarmRadius){
            //alarmsound.Play();
            //gameObject.renderer.material.color = Color.red;
            gameObject.GetComponent<MeshRenderer>().material.color = Color.red;

            Invoke("RaketeStart", 5); // 5 sek verzögerung
              }



        if (entfernung > AlarmRadius) {
            
            gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
        }
    }

    public void RaketeStart(){
            if (aktiv == 1)
                {
                Debug.Log("Rakete abgeschossen");
                aktiv += 2;
                
                }
                else if ( aktiv == 0){
                    aktiv  += 1;
                }
                
                
            }
                
    


}
