using System;
using UnityEngine;

public class GameObjectDisabler : MonoBehaviour
{

   private void OnEnable()
   {
      var triggerEventsBehaviour = FindObjectOfType<Unit6TriggerEventsBehaviour>();
      if (triggerEventsBehaviour != null)
      {
//         Unit6TriggerEventsBehaviour.triggerExitEvent.AddListener(DisableGameObject);
      }
   }

   private void OnDisable()
   {
      var triggerEventsBehaviour = FindObjectOfType<Unit6TriggerEventsBehaviour>();
      if (triggerEventsBehaviour != null)
      {
 //        Unit6TriggerEventsBehaviour.triggerExitEvent.AddListener(DisableGameObject);
      }
   }

   private void DisableGameObject()
   {
      gameObject.SetActive(false);
   }
}
