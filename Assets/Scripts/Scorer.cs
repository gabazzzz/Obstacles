using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int Score = 0;

    private void OnCollisionEnter(Collision other) 
   {
     if(other.gameObject.tag != "hit")
     {
        Score += 1;
        Debug.Log("Ilość uderzeń"+ Score);

     }
        

   }
        
    
   
    
}
