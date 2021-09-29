using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetector : MonoBehaviour
{
    // Start is called before the first frame update
   public GameOverManager gameOverManager;
 
    private void OnTriggerEnter(Collider other)
    {   
        // Debug.Log(other);
        if (other.tag == "Enemy" && !other.isTrigger)
        {
            // Debug.Log("Warning");
            float enemyDistance = Vector3.Distance(transform.position,other.transform.position);
            gameOverManager.ShowWarning(enemyDistance);
        }
    }
}
