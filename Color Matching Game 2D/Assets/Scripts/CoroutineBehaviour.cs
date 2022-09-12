using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehaviour : MonoBehaviour
{ 
    public UnityEvent startEvent, startcountEvent, repeatcountEvent, endcountEvent, repeatUntilFalseEvent;
    public bool canRun;
    public IntData counterNum;
    public float seconds = 3f;
    
    
    private WaitForSeconds wfsObj;
    private WaitForFixedUpdate wffuObj;

    private void Start()
    {
        wfsObj = new WaitForSeconds(seconds);
        wffuObj = new WaitForFixedUpdate();
        startEvent.Invoke();
    }

    public void StartCounting()
    {
        StartCoroutine(Counting());
    }
   
    private IEnumerator Counting()
   {
      
      startcountEvent.Invoke();
      yield return wfsObj;
      while (counterNum.value > 0)
      {   
          repeatcountEvent.Invoke();
          counterNum.value--;
          yield return wfsObj;
      }
      endcountEvent.Invoke();
   }

    public void StartRepeatUntilFalse()
    {
        canRun = true;
        StartCoroutine(RepeatUntilFalse());
    }

     private IEnumerator RepeatUntilFalse()
     {
         while (canRun)
         {
             yield return wfsObj;
             repeatUntilFalseEvent.Invoke();
         }
     }
}
