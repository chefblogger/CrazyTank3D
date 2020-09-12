using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepScore : MonoBehaviour
{

        public static int Score = 0;
   
    void OnGUI(){
       GUI.skin.box.fontSize = 30; 
        GUI.Box(new Rect(0, 0, 300, 400), "Dein Score ist:\n" + Score + " Punkte");

        

        if (Score >= 120){
            
            Application.LoadLevel("Scene01");
        }
    }

    
    

}
