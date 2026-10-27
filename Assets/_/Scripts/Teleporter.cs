using UnityEngine;
public class Teleporter : MonoBehaviour
{
   public Transform teleportTarget;
   void OnTriggerEnter(Collider other)
   {
       if (other.CompareTag("Player"))
       {
           CharacterController cc = other.GetComponent<CharacterController>();
           if (cc) cc.enabled = false; // Disable before moving
           other.transform.position = teleportTarget.position;
           if (cc) cc.enabled = true; // Re-enable after moving
       }
   }
}