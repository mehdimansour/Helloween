using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePivot : MonoBehaviour
{

    [SerializeField] private GameObject pivotGameObject;
    [SerializeField] private SpriteRenderer arm;

    [SerializeField] private float rotateSpeedMin;
    [SerializeField] private float rotateSpeedMax;
    [SerializeField] private float rotateAngleMin;
    [SerializeField] private float rotateAngleMax;

    private float rotateAngle;
    private float rotateSpeed;

    private float time;

    private void Start()
    {

        arm.flipY = randomBool();
        float scale = Random.Range(0.08f, 0.12f);
        pivotGameObject.transform.localScale = new Vector3(scale, scale, scale);

        rotateAngle = Random.Range(rotateAngleMin, rotateAngleMax);
        rotateSpeed = Random.Range(rotateSpeedMin, rotateSpeedMax);


    }
    private void FixedUpdate()
    {
        time = Mathf.Sin(Time.fixedTime * rotateSpeed) * rotateAngle;
        pivotGameObject.transform.rotation = Quaternion.Euler(0f, 0f, time);
        //print(time);

    }
    
    private bool randomBool()
    {

        if (Random.value >= 0.5)
        {
            return true;
        }
        return false;

    }
}
