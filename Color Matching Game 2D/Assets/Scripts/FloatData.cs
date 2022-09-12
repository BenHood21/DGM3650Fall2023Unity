using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/FloatData", order = 2)]
public class FloatData : ScriptableObject
{
 public float value;

 public void UpdateValue(float numb)
 {
  value += numb;
 }
}
