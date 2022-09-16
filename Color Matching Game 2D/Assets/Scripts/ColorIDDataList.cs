using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu (fileName = "New ColorIDDataList", menuName = "ScriptableObjects/ColorIDDataList", order = 8)]
public class ColorIDDataList : ScriptableObject
{
   public List<ColorID> colorIDList;

   public ColorID currentColor;

   private int num;

   public void SetCurrentColorRandomly()
   {
      num = Random.Range(0, colorIDList.Count);
      currentColor = colorIDList[num];
   }
}
