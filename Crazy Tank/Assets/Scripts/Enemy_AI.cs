using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_AI : MonoBehaviour
{
Transform tr_Player;

public GameObject player;
public GameObject feind;
public float entfernung;


 float f_RotSpeed=50.0f,f_MoveSpeed = 10.0f;

 // Use this for initialization
 void Start () {

  tr_Player = GameObject.FindGameObjectWithTag ("Player").transform;
  
 }
 
 // Update is called once per frame
 void Update () {
  /* Look at Player*/
  transform.rotation = Quaternion.Slerp (transform.rotation
                                        , Quaternion.LookRotation (tr_Player.position - transform.position)
                                        , f_RotSpeed * Time.deltaTime);

  /* Move at Player*/
  transform.position += transform.forward * f_MoveSpeed * Time.deltaTime;

  entfernung = Vector3.Distance(player.transform.position, feind.transform.position);

  if ( entfernung <= 5)
  {
      Debug.Log("++++++++++++++++++BUUUUMMMMM++++++++++++++++++");
      
      
      
  }

 }





}
