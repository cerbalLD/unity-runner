using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialTiling : MonoBehaviour
{
    public float slideSpeed = 0.5f; // Speed at which the material slides
    public Vector2 initialOffset = Vector2.zero; // Initial offset of the material

    private Renderer renderer;
    private Material material;
    private Vector2 offset;

    void Start()
    {
        renderer = GetComponent<Renderer>();
        material = renderer.material;
        offset = initialOffset;
    }

    void Update()
    {
        offset.y -= slideSpeed * Time.deltaTime; // Update the offset of the material
        material.mainTextureOffset = offset; // Set the offset of the material
    }
}