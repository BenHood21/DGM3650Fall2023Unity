using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class MatchBehaviour : MonoBehaviour
{
   public ID idObj;
   public UnityEvent matchEvent, noMatchEvent, noMatchDelayEvent;

   private IEnumerator OnTriggerEnter(Collider other)
   {
       var tempObj = other.GetComponent<IDContainerBehaviour>();
       if (tempObj == null)
           yield break;

       var otherID = tempObj.idObj;
       if (otherID == idObj)
       {
           matchEvent.Invoke();
           Debug.Log("match");
       }
       else
       {
           noMatchEvent.Invoke();
           yield return new WaitForSeconds(0.5f);
           noMatchDelayEvent.Invoke();
           Debug.Log("no match");
       }
   }
}
