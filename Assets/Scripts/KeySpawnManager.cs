using NUnit.Framework.Internal;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class KeySpawnManager : MonoBehaviour
{
    [SerializeField] GameObject keyObject;

    Vector3[] spawnPoints = new Vector3[]
    {
        new Vector3(12, 0.5f, 4),
        new Vector3(6, 0.5f, 4),
        new Vector3(-8, 0.5f, 12),
        new Vector3(-14, 0.5f, 2),
        new Vector3(12, 0.5f, -14),
        new Vector3(-8, 0.5f, -8),
        new Vector3(-14, 0.5f, -8),
        new Vector3(-12, 0.5f, -14)
    };
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnObject();
    }

    void SpawnObject()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(keyObject, spawnPoints[randomIndex], Quaternion.identity);
    }
}
