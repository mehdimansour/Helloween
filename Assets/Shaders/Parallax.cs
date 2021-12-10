using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{

    [SerializeField] float parallax;
    private Vector2 offsetbase;

    [SerializeField] Vector2 offsetdif;

    private void Start()
    {

        MeshRenderer Mesh = GetComponent<MeshRenderer>();
        Material Mat = Mesh.material;
        offsetbase = Mat.mainTextureOffset;

    }
    void Update()
    {

        MeshRenderer Mesh = GetComponent<MeshRenderer>();
        Material Mat = Mesh.material;
        Vector2 offset = Mat.mainTextureOffset;

        offset.x = transform.position.x / transform.localScale.x / parallax;
        offset.y = transform.position.y / transform.localScale.y / parallax;

        Mat.mainTextureOffset = offset + offsetbase + offsetdif;  
    }
}
