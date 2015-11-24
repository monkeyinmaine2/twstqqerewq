using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Instantiation : MonoBehaviour
{
    List<GameObject> cubes = new List<GameObject>();

    void Start()
    {
        for (int y = 0; y < 5; y++)
        {
            for (int x = 0; x < 5; x++)
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.AddComponent<Rigidbody>();
                cube.transform.position = new Vector3(x, y, 0);
                cubes.Add(cube);

            }
        }


    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (GameObject item in cubes)
            {
                Destroy(item);
            }
            print("All Clear Scene Code 4");  
        }
    }
}

