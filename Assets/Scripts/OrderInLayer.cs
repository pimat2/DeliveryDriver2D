using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderInLayer : MonoBehaviour
{
    SpriteRenderer packageRenderer;
    // Start is called before the first frame update
    void Start()
    {
        packageRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        packageRenderer.sortingOrder = 3;
    }
}
