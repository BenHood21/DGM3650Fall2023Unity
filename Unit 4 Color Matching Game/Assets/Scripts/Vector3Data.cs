using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Vector3Data", order = 1)]
public class Vector3Data : ScriptableObject
{
    public string prefabName;

    public int numberOfPrefabsToCreate;
    public Vector3[] spawnPoints;
}
