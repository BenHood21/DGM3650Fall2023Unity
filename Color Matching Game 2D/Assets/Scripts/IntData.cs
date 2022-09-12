using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/IntData", order = 3)]
public class IntData : ScriptableObject
{
   public int value;

   public void SetValue(int num)
   {
      value = num;
   }

   public void CompareValue(IntData obj)
   {
      if (value >= obj.value)
      {
         
      }
      else
      {
         value = obj.value;
      }
   }
   public void SetValue(IntData obj)
   {
      value = obj.value;
   }
   public void UpdateValue(int num)

   {
      value += num;
   }
}
