using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Events : MonoBehaviour
{
  public GameObject Astronaut;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeColor()
    {
      Astronaut.GetComponent<Renderer>().material.color = Random.ColorHSV();
    Debug.Log("Cambiando color");
    }
}
