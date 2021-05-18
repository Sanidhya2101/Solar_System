using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public Transform[] planets;
    public float[] speed;

    int currplanet = 0;

    Transform selftransform;

    // Start is called before the first frame update
    void Start()
    {
        selftransform = transform;   
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(selftransform.position, planets[currplanet].position, speed[currplanet] * Time.deltaTime);
        transform.RotateAround(planets[currplanet].position, Vector3.up, speed[currplanet] * Time.deltaTime);


        if(Input.GetKeyDown(KeyCode.S))
        {
            switchPlanet();
        }
    }

    void switchPlanet()
    {
        currplanet += 1;
        if(currplanet == planets.Length)
        {
            currplanet = 0;
        }
    }
}
