 using UnityEngine;
 using System.Collections;

 public class EnemyMovement4 : MonoBehaviour {
     private Vector3 pos1 = new Vector3(7,9/2,0);
     private Vector3 pos2 = new Vector3(-6,9/2,0);
     public float speed = 1.0f;
 
     void Update() {
         transform.position = Vector3.Lerp (pos1, pos2, (Mathf.Sin(speed * Time.time) + 1.0f) / 2.0f);
     }
 }
