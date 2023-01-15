using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{

    [SerializeField]
    private int baseLengthSize = 10; // the number of cubes horizontally

    [SerializeField]
    private int baseDepthSize = 15;

    [SerializeField]
    private Vector3 baseCubeSize = new Vector3(1, 0.2f, 1);

    // Start is called before the first frame update
    void Start()
    {
        CreateBase();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    private void CreateBase(){

        Vector3 nextPosition = new Vector3(0, -1.2f, -17f);
        float cubeDepth = 0;

        for(int height = 0; height < baseDepthSize; height++ ){
            for(int length = 0; length < baseLengthSize; length++){

                GameObject cubeObject = new GameObject(); 
                cubeObject.name = "Cube " + height + "-" + length;
                cubeObject.AddComponent<Cube>();
                cubeObject.GetComponent<Cube>().UpdateCubeSize(baseCubeSize);
                cubeObject.transform.parent = this.transform;
                cubeObject.transform.position = nextPosition; 
                nextPosition.x = nextPosition.x + (cubeObject.GetComponent<Cube>().CubeSize().x * 2);
                cubeDepth = (cubeObject.GetComponent<Cube>().CubeSize().z * 2);
            }
            nextPosition.x = 0;
            nextPosition.z = nextPosition.z + cubeDepth;
        }
    }
}
