using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    public List<Color> color;
    public MeshRenderer meshRenderer;
    public float delay;
    private void changeColor()
    {
        for (int i = 0; i < color.Count; i++)
        {
            meshRenderer.material.color = color[Random.Range(0, 6)];
        }
    }
    void Start()
    {


    }
    // Update is called once per frame
    void Update()
    {
   
        
    }
    private void OnEnable()
    {

    }
    private void OnDisable()
    {

    }

    private void OnMouseDown()
    {
        //changeColor();
        InvokeRepeating("changeColor", delay,5);
    }
    private void OnMouseEnter()
    {

    }
    private void OnMouseExit()
    {

    }
 
}
