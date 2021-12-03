using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnPrefab : MonoBehaviour
{

    public GameObject armPrefab;

    [SerializeField] private GameObject origin;

    [SerializeField] private int armCount;
    [SerializeField] private float offsetMin;
    [SerializeField] private float offsetMax;

    private void Start()
    {
        
        for(int i = 0; i < armCount; i++)
        {

            SpawnArm();

        }

    }
    private void SpawnArm()
    {

        GameObject a = Instantiate(armPrefab) as GameObject;
        a.transform.position = new Vector3(Random.Range(offsetMin, offsetMax) + origin.transform.position.x, origin.transform.position.y , origin.transform.position.z - Random.Range(-0.25f, 0.25f));

    }

}
