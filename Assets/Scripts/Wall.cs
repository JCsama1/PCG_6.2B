using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{

    [SerializeField]
    private int wallLengthSize = 1; // the number of cubes horizontally

    [SerializeField]
    private int wallHeightSize = 1;

    [SerializeField]
    private Vector3 wallCubeSize = new Vector3(5, 5, 0.2f);

    [SerializeField]
    private Vector3 initialPosition = Vector3.zero;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InitialiseWall(int newWallLengthSize, int newWallHeightSize, Vector3 newInitialPosition, Vector3 newWallCubeSize){
            wallLengthSize = newWallLengthSize;
            wallHeightSize = newWallHeightSize;
            wallCubeSize = newWallCubeSize;
            initialPosition = newInitialPosition;

            CreateWall();
    }

    private void CreateWall(){

        Vector3 nextPosition = initialPosition; //initial position
        float cubeHeight = 5;

        for(int height = 0; height < wallHeightSize; height++ ){
            for(int length = 0; length < wallLengthSize; length++){

                GameObject cubeObject = new GameObject(); 
                cubeObject.name = "Cube " + height + "-" + length;
                cubeObject.AddComponent<Cube>();
                cubeObject.GetComponent<Cube>().UpdateCubeSize(wallCubeSize);
                cubeObject.transform.parent = this.transform;
                cubeObject.transform.position = nextPosition; 
                nextPosition.x = nextPosition.x + (cubeObject.GetComponent<Cube>().CubeSize().x * 2);
                cubeHeight = (cubeObject.GetComponent<Cube>().CubeSize().y * 2);
            }
            nextPosition.x = initialPosition.x;
            nextPosition.y = nextPosition.y + cubeHeight;
        }
    }
}
