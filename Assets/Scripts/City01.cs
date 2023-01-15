using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class City01 : MonoBehaviour
{
    #region fields

    public int minPieces = 5;
    public int maxPieces = 10;
    public GameObject[] baseParts;
    public GameObject[] middleParts;
    public GameObject[] topParts;

    [SerializeField]
    private int baseLengthSize = 17; // the number of cubes horizontally

    [SerializeField]
    private int baseDepthSize = 2;

    [SerializeField]
    private int basePavementLengthSize = 15;

    [SerializeField]
    private int basePavementDepthSize = 2;

    [SerializeField]
    private int basePavement01LengthSize = 15;

    [SerializeField]
    private int basePavement01DepthSize = 2;

    [SerializeField]
    private int baseInnerPavementLengthSize = 15;

    [SerializeField]
    private int baseInnerPavementDepthSize = 2;

    [SerializeField]
    private int baseStreetLineLengthSize = 15;

    [SerializeField]
    private int baseStreetLineDepthSize = 2;

    [SerializeField]
    private int baseBuildingLengthSize = 15;

    [SerializeField]
    private int baseBuildingDepthSize = 2;

    [SerializeField]
    private Vector3 baseCubeSize = new Vector3(1, 0.2f, 1);

    [SerializeField]
    private Vector3 baseBuildingCubeSize = new Vector3(1, 0.2f, 1);

    #endregion


    #region calling methods
    void Start()
    {
        CreateRoad1();

        CreateRoad2();

        CreateRoad3();

        CreateRoad4();

        CreatePavement();

        CreatePavement1();

        CreatePavement2();

        CreatePavement3();

        CreateInnerPavement();

        CreateInnerPavement1();

        CreateInnerPavement2();

        CreateInnerPavement3();

        CreateStreetLine();

        CreateStreetLine1();

        CreateStreetLine2();

        CreateStreetLine3();

        CreateStreetLine4();

        CreateStreetLine5();

        CreateStreetLine6();

        CreateStreetLine7();

        //Build();

        CreateBuilding(Random.Range(0, 30));

        CreateBuilding1(Random.Range(0, 30));

        CreateBuilding2(Random.Range(0, 30));

        CreateBuilding3(Random.Range(0, 36));

        CreateBuilding4(Random.Range(0, 14));

    }
    #endregion


    

    /*void Build()
    {
        for (int i = 0; i < 5;  i++)
        {
            GameObject building = new GameObject();
            building.name = "Building";

            int targetPieces = Random.Range(minPieces, maxPieces);
            float heightOffset = 0;
            heightOffset += SpawnPieceLayer(baseParts, heightOffset);

            for (int j = 2; j < targetPieces; j++)
            {
                heightOffset += SpawnPieceLayer(middleParts, heightOffset);
            }

            SpawnPieceLayer(topParts, heightOffset);
        }
    }

    float SpawnPieceLayer(GameObject[] pieceArray, float inputHeight)
    {
        Transform randomTransform = pieceArray[Random.Range(0, pieceArray.Length)].transform;
        GameObject clone = Instantiate(randomTransform.gameObject, this.transform.position + new Vector3(-7, inputHeight, 12), transform.rotation) as GameObject;
        Mesh cloneMesh = clone.GetComponentInChildren<MeshFilter>().mesh;
        Bounds bounds= cloneMesh.bounds;
        float heightOffset = bounds.size.y;

        clone.transform.SetParent(this.transform);

        return heightOffset;
    }*/

    #region roads
    private void CreateRoad1()
    {
        GameObject Road = new GameObject();
        Road.name = "Road1";
        Road.transform.parent = transform;

        Vector3 nextPosition = new Vector3(0, 0f, 0f);
        float cubeDepth = 0;

        for (int height = 0; height < baseDepthSize; height++)
        {
            for (int length = 0; length < baseLengthSize; length++)
            {

                GameObject cubeObject = new GameObject();
                cubeObject.name = "Cube " + height + "-" + length;
                cubeObject.AddComponent<Cube>();
                cubeObject.GetComponent<Cube>().UpdateCubeSize(baseCubeSize);
                cubeObject.GetComponent<Cube>().SetCubeColor(0);
                cubeObject.transform.parent = Road.transform;
                cubeObject.transform.position = nextPosition;
                nextPosition.x = nextPosition.x + (cubeObject.GetComponent<Cube>().CubeSize().x * 2);
                cubeDepth = (cubeObject.GetComponent<Cube>().CubeSize().z * 2);
            }
            nextPosition.x = 0;
            nextPosition.z = nextPosition.z + cubeDepth;
        }
        Vector3 rotation = new Vector3(0, 0f, 0);
        Road.transform.Rotate(rotation);
        Road.transform.position = new Vector3(-3.32f,3.29f,28.58f);
        Road.AddComponent<BoxCollider>();
    }

    private void CreateRoad2()
    {
        GameObject Road = new GameObject();
        Road.name = "Road2";
        Road.transform.parent = transform;

        Vector3 nextPosition = new Vector3(0, 0f, 0f);
        float cubeDepth = 0;

        for (int height = 0; height < baseDepthSize; height++)
        {
            for (int length = 0; length < baseLengthSize; length++)
            {

                GameObject cubeObject = new GameObject();
                cubeObject.name = "Cube " + height + "-" + length;
                cubeObject.AddComponent<Cube>();
                cubeObject.GetComponent<Cube>().UpdateCubeSize(baseCubeSize);
                cubeObject.GetComponent<Cube>().SetCubeColor(0);
                cubeObject.transform.parent = Road.transform;
                cubeObject.transform.position = nextPosition;
                nextPosition.x = nextPosition.x + (cubeObject.GetComponent<Cube>().CubeSize().x * 2);
                cubeDepth = (cubeObject.GetComponent<Cube>().CubeSize().z * 2);
            }
            nextPosition.x = 0;
            nextPosition.z = nextPosition.z + cubeDepth;
        }
        Vector3 rotation = new Vector3(0, 90f, 0);
        Road.transform.Rotate(rotation);
        Road.transform.position = new Vector3(26.68f, 3.29f, 26.58f);
        BoxCollider Collider = Road.AddComponent<BoxCollider>();
        Collider.size = new Vector3(70, 1, 75);
    }

    private void CreateRoad3()
    {
        GameObject Road = new GameObject();
        Road.name = "Road3";
        Road.transform.parent = transform;

        Vector3 nextPosition = new Vector3(0, 0f, 0f);
        float cubeDepth = 0;

        for (int height = 0; height < baseDepthSize; height++)
        {
            for (int length = 0; length < baseLengthSize; length++)
            {

                GameObject cubeObject = new GameObject();
                cubeObject.name = "Cube " + height + "-" + length;
                cubeObject.AddComponent<Cube>();
                cubeObject.GetComponent<Cube>().UpdateCubeSize(baseCubeSize);
                cubeObject.GetComponent<Cube>().SetCubeColor(0);
                cubeObject.transform.parent = Road.transform;
                cubeObject.transform.position = nextPosition;
                nextPosition.x = nextPosition.x + (cubeObject.GetComponent<Cube>().CubeSize().x * 2);
                cubeDepth = (cubeObject.GetComponent<Cube>().CubeSize().z * 2);
            }
            nextPosition.x = 0;
            nextPosition.z = nextPosition.z + cubeDepth;
        }
        Vector3 rotation = new Vector3(0, 90f, 0);
        Road.transform.Rotate(rotation);
        Road.transform.position = new Vector3(-3.32f, 3.29f, 30.58f);
    }

    private void CreateRoad4()
    {
        GameObject Road = new GameObject();
        Road.name = "Road4";
        Road.transform.parent = transform;

        Vector3 nextPosition = new Vector3(0, 0f, 0f);
        float cubeDepth = 0;

        for (int height = 0; height < baseDepthSize; height++)
        {
            for (int length = 0; length < baseLengthSize; length++)
            {

                GameObject cubeObject = new GameObject();
                cubeObject.name = "Cube " + height + "-" + length;
                cubeObject.AddComponent<Cube>();
                cubeObject.GetComponent<Cube>().UpdateCubeSize(baseCubeSize);
                cubeObject.GetComponent<Cube>().SetCubeColor(0);
                cubeObject.transform.parent = Road.transform;
                cubeObject.transform.position = nextPosition;
                nextPosition.x = nextPosition.x + (cubeObject.GetComponent<Cube>().CubeSize().x * 2);
                cubeDepth = (cubeObject.GetComponent<Cube>().CubeSize().z * 2);
            }
            nextPosition.x = 0;
            nextPosition.z = nextPosition.z + cubeDepth;
        }
        Vector3 rotation = new Vector3(0, 0f, 0);
        Road.transform.Rotate(rotation);
        Road.transform.position = new Vector3(-3.32f, 3.29f, -5.42f);
    }
    #endregion

    #region pavements
    private void CreatePavement()
    {
        GameObject Road = new GameObject();
        Road.name = "Pavement1";
        Road.transform.parent = transform;

        Vector3 nextPosition = new Vector3(0, 0f, 0f);
        float cubeDepth = 0;

        for (int height = 0; height < basePavement01DepthSize; height++)
        {
            for (int length = 0; length < basePavement01LengthSize; length++)
            {

                GameObject cubeObject = new GameObject();
                cubeObject.name = "Cube " + height + "-" + length;
                cubeObject.AddComponent<Cube>();
                cubeObject.GetComponent<Cube>().UpdateCubeSize(baseCubeSize);
                cubeObject.GetComponent<Cube>().SetCubeColor(1);
                cubeObject.transform.parent = Road.transform;
                cubeObject.transform.position = nextPosition;
                nextPosition.x = nextPosition.x + (cubeObject.GetComponent<Cube>().CubeSize().x * 2);
                cubeDepth = (cubeObject.GetComponent<Cube>().CubeSize().z * 2);
            }
            nextPosition.x = 0;
            nextPosition.z = nextPosition.z + cubeDepth;
        }
        Vector3 rotation = new Vector3(0, 0f, 0);
        Road.transform.Rotate(rotation);
        Road.transform.position = new Vector3(-5.32f, 3.49f, 32.54f);
    }

    private void CreatePavement1()
    {
        GameObject Road = new GameObject();
        Road.name = "Pavement2";
        Road.transform.parent = transform;

        Vector3 nextPosition = new Vector3(0, 0f, 0f);
        float cubeDepth = 0;

        for (int height = 0; height < basePavementDepthSize; height++)
        {
            for (int length = 0; length < basePavementLengthSize; length++)
            {

                GameObject cubeObject = new GameObject();
                cubeObject.name = "Cube " + height + "-" + length;
                cubeObject.AddComponent<Cube>();
                cubeObject.GetComponent<Cube>().UpdateCubeSize(baseCubeSize);
                cubeObject.GetComponent<Cube>().SetCubeColor(1);
                cubeObject.transform.parent = Road.transform;
                cubeObject.transform.position = nextPosition;
                nextPosition.x = nextPosition.x + (cubeObject.GetComponent<Cube>().CubeSize().x * 2);
                cubeDepth = (cubeObject.GetComponent<Cube>().CubeSize().z * 2);
            }
            nextPosition.x = 0;
            nextPosition.z = nextPosition.z + cubeDepth;
        }
        Vector3 rotation = new Vector3(0, 90f, 0);
        Road.transform.Rotate(rotation);
        Road.transform.position = new Vector3(-5.32f, 3.49f, 32.55f);
    }

    private void CreatePavement2()
    {
        GameObject Road = new GameObject();
        Road.name = "Pavement3";
        Road.transform.parent = transform;

        Vector3 nextPosition = new Vector3(0, 0f, 0f);
        float cubeDepth = 0;

        for (int height = 0; height < basePavement01DepthSize; height++)
        {
            for (int length = 0; length < basePavement01LengthSize; length++)
            {

                GameObject cubeObject = new GameObject();
                cubeObject.name = "Cube " + height + "-" + length;
                cubeObject.AddComponent<Cube>();
                cubeObject.GetComponent<Cube>().UpdateCubeSize(baseCubeSize);
                cubeObject.GetComponent<Cube>().SetCubeColor(1);
                cubeObject.transform.parent = Road.transform;
                cubeObject.transform.position = nextPosition;
                nextPosition.x = nextPosition.x + (cubeObject.GetComponent<Cube>().CubeSize().x * 2);
                cubeDepth = (cubeObject.GetComponent<Cube>().CubeSize().z * 2);
            }
            nextPosition.x = 0;
            nextPosition.z = nextPosition.z + cubeDepth;
        }
        Vector3 rotation = new Vector3(0, 0f, 0);
        Road.transform.Rotate(rotation);
        Road.transform.position = new Vector3(-5.32f, 3.49f, -7.42f);
    }

    private void CreatePavement3()
    {
        GameObject Road = new GameObject();
        Road.name = "Pavement4";
        Road.transform.parent = transform;

        Vector3 nextPosition = new Vector3(0, 0f, 0f);
        float cubeDepth = 0;

        for (int height = 0; height < basePavementDepthSize; height++)
        {
            for (int length = 0; length < basePavementLengthSize; length++)
            {

                GameObject cubeObject = new GameObject();
                cubeObject.name = "Cube " + height + "-" + length;
                cubeObject.AddComponent<Cube>();
                cubeObject.GetComponent<Cube>().UpdateCubeSize(baseCubeSize);
                cubeObject.GetComponent<Cube>().SetCubeColor(1);
                cubeObject.transform.parent = Road.transform;
                cubeObject.transform.position = nextPosition;
                nextPosition.x = nextPosition.x + (cubeObject.GetComponent<Cube>().CubeSize().x * 2);
                cubeDepth = (cubeObject.GetComponent<Cube>().CubeSize().z * 2);
            }
            nextPosition.x = 0;
            nextPosition.z = nextPosition.z + cubeDepth;
        }
        Vector3 rotation = new Vector3(0, 90f, 0);
        Road.transform.Rotate(rotation);
        Road.transform.position = new Vector3(30.68f, 3.49f, 32.58f);
    }

    private void CreateInnerPavement()
    {
        GameObject Road = new GameObject();
        Road.name = "InnerPavement1";
        Road.transform.parent = transform;

        Vector3 nextPosition = new Vector3(0, 0f, 0f);
        float cubeDepth = 0;

        for (int height = 0; height < baseInnerPavementDepthSize; height++)
        {
            for (int length = 0; length < baseInnerPavementLengthSize; length++)
            {

                GameObject cubeObject = new GameObject();
                cubeObject.name = "Cube " + height + "-" + length;
                cubeObject.AddComponent<Cube>();
                cubeObject.GetComponent<Cube>().UpdateCubeSize(baseCubeSize);
                cubeObject.GetComponent<Cube>().SetCubeColor(1);
                cubeObject.transform.parent = Road.transform;
                cubeObject.transform.position = nextPosition;
                nextPosition.x = nextPosition.x + (cubeObject.GetComponent<Cube>().CubeSize().x * 2);
                cubeDepth = (cubeObject.GetComponent<Cube>().CubeSize().z * 2);
            }
            nextPosition.x = 0;
            nextPosition.z = nextPosition.z + cubeDepth;
        }
        Vector3 rotation = new Vector3(0, 0f, 0);
        Road.transform.Rotate(rotation);
        Road.transform.position = new Vector3(0.68f, 3.49f, 26.58f);
    }

    private void CreateInnerPavement1()
    {
        GameObject Road = new GameObject();
        Road.name = "InnerPavement2";
        Road.transform.parent = transform;

        Vector3 nextPosition = new Vector3(0, 0f, 0f);
        float cubeDepth = 0;

        for (int height = 0; height < baseInnerPavementDepthSize; height++)
        {
            for (int length = 0; length < baseInnerPavementLengthSize; length++)
            {

                GameObject cubeObject = new GameObject();
                cubeObject.name = "Cube " + height + "-" + length;
                cubeObject.AddComponent<Cube>();
                cubeObject.GetComponent<Cube>().UpdateCubeSize(baseCubeSize);
                cubeObject.GetComponent<Cube>().SetCubeColor(1);
                cubeObject.transform.parent = Road.transform;
                cubeObject.transform.position = nextPosition;
                nextPosition.x = nextPosition.x + (cubeObject.GetComponent<Cube>().CubeSize().x * 2);
                cubeDepth = (cubeObject.GetComponent<Cube>().CubeSize().z * 2);
            }
            nextPosition.x = 0;
            nextPosition.z = nextPosition.z + cubeDepth;
        }
        Vector3 rotation = new Vector3(0, 90f, 0);
        Road.transform.Rotate(rotation);
        Road.transform.position = new Vector3(0.68f, 3.49f, 24.58f);
    }

    private void CreateInnerPavement2()
    {
        GameObject Road = new GameObject();
        Road.name = "InnerPavement3";
        Road.transform.parent = transform;

        Vector3 nextPosition = new Vector3(0, 0f, 0f);
        float cubeDepth = 0;

        for (int height = 0; height < baseInnerPavementDepthSize; height++)
        {
            for (int length = 0; length < baseInnerPavementLengthSize; length++)
            {

                GameObject cubeObject = new GameObject();
                cubeObject.name = "Cube " + height + "-" + length;
                cubeObject.AddComponent<Cube>();
                cubeObject.GetComponent<Cube>().UpdateCubeSize(baseCubeSize);
                cubeObject.GetComponent<Cube>().SetCubeColor(1);
                cubeObject.transform.parent = Road.transform;
                cubeObject.transform.position = nextPosition;
                nextPosition.x = nextPosition.x + (cubeObject.GetComponent<Cube>().CubeSize().x * 2);
                cubeDepth = (cubeObject.GetComponent<Cube>().CubeSize().z * 2);
            }
            nextPosition.x = 0;
            nextPosition.z = nextPosition.z + cubeDepth;
        }
        Vector3 rotation = new Vector3(0, 0f, 0);
        Road.transform.Rotate(rotation);
        Road.transform.position = new Vector3(0.68f, 3.49f, -1.42f);
    }

    private void CreateInnerPavement3()
    {
        GameObject Road = new GameObject();
        Road.name = "InnerPavement4";
        Road.transform.parent = transform;

        Vector3 nextPosition = new Vector3(0, 0f, 0f);
        float cubeDepth = 0;

        for (int height = 0; height < baseInnerPavementDepthSize; height++)
        {
            for (int length = 0; length < baseInnerPavementLengthSize; length++)
            {

                GameObject cubeObject = new GameObject();
                cubeObject.name = "Cube " + height + "-" + length;
                cubeObject.AddComponent<Cube>();
                cubeObject.GetComponent<Cube>().UpdateCubeSize(baseCubeSize);
                cubeObject.GetComponent<Cube>().SetCubeColor(1);
                cubeObject.transform.parent = Road.transform;
                cubeObject.transform.position = nextPosition;
                nextPosition.x = nextPosition.x + (cubeObject.GetComponent<Cube>().CubeSize().x * 2);
                cubeDepth = (cubeObject.GetComponent<Cube>().CubeSize().z * 2);
            }
            nextPosition.x = 0;
            nextPosition.z = nextPosition.z + cubeDepth;
        }
        Vector3 rotation = new Vector3(0, 90f, 0);
        Road.transform.Rotate(rotation);
        Road.transform.position = new Vector3(24.68f, 3.49f, 24.58f);
    }
    #endregion

    #region street line
    private void CreateStreetLine()
    {
        GameObject Road = new GameObject();
        Road.name = "StreetLine1";
        Road.transform.parent = transform;

        Vector3 nextPosition = new Vector3(0, 0f, 0f);
        float cubeDepth = 0;

        for (int height = 0; height < baseStreetLineDepthSize; height++)
        {
            for (int length = 0; length < baseStreetLineLengthSize; length++)
            {

                GameObject cubeObject = new GameObject();
                cubeObject.name = "Cube " + height + "-" + length;
                cubeObject.AddComponent<Cube>();
                cubeObject.GetComponent<Cube>().UpdateCubeSize(baseCubeSize);
                cubeObject.GetComponent<Cube>().SetCubeColor(2);
                cubeObject.transform.parent = Road.transform;
                cubeObject.transform.position = nextPosition;
                nextPosition.x = nextPosition.x + (cubeObject.GetComponent<Cube>().CubeSize().x * 2);
                cubeDepth = (cubeObject.GetComponent<Cube>().CubeSize().z * 2);
            }
            nextPosition.x = 0;
            nextPosition.z = nextPosition.z + cubeDepth;
        }
        Vector3 rotation = new Vector3(90f, 0f, -90f);
        Road.transform.Rotate(rotation);
        Road.transform.position = new Vector3(27.68f, 2.54f, 23.58f);
    }

    private void CreateStreetLine1()
    {
        GameObject Road = new GameObject();
        Road.name = "StreetLine2";
        Road.transform.parent = transform;

        Vector3 nextPosition = new Vector3(0, 0f, 0f);
        float cubeDepth = 0;

        for (int height = 0; height < baseStreetLineDepthSize; height++)
        {
            for (int length = 0; length < baseStreetLineLengthSize; length++)
            {

                GameObject cubeObject = new GameObject();
                cubeObject.name = "Cube " + height + "-" + length;
                cubeObject.AddComponent<Cube>();
                cubeObject.GetComponent<Cube>().UpdateCubeSize(baseCubeSize);
                cubeObject.GetComponent<Cube>().SetCubeColor(2);
                cubeObject.transform.parent = Road.transform;
                cubeObject.transform.position = nextPosition;
                nextPosition.x = nextPosition.x + (cubeObject.GetComponent<Cube>().CubeSize().x * 2);
                cubeDepth = (cubeObject.GetComponent<Cube>().CubeSize().z * 2);
            }
            nextPosition.x = 0;
            nextPosition.z = nextPosition.z + cubeDepth;
        }
        Vector3 rotation = new Vector3(90, 0f, -90);
        Road.transform.Rotate(rotation);
        Road.transform.position = new Vector3(27.68f, 2.54f, 7.58f);
    }

    private void CreateStreetLine2()
    {
        GameObject Road = new GameObject();
        Road.name = "StreetLine3";
        Road.transform.parent = transform;

        Vector3 nextPosition = new Vector3(0, 0f, 0f);
        float cubeDepth = 0;

        for (int height = 0; height < baseStreetLineDepthSize; height++)
        {
            for (int length = 0; length < baseStreetLineLengthSize; length++)
            {

                GameObject cubeObject = new GameObject();
                cubeObject.name = "Cube " + height + "-" + length;
                cubeObject.AddComponent<Cube>();
                cubeObject.GetComponent<Cube>().UpdateCubeSize(baseCubeSize);
                cubeObject.GetComponent<Cube>().SetCubeColor(2);
                cubeObject.transform.parent = Road.transform;
                cubeObject.transform.position = nextPosition;
                nextPosition.x = nextPosition.x + (cubeObject.GetComponent<Cube>().CubeSize().x * 2);
                cubeDepth = (cubeObject.GetComponent<Cube>().CubeSize().z * 2);
            }
            nextPosition.x = 0;
            nextPosition.z = nextPosition.z + cubeDepth;
        }
        Vector3 rotation = new Vector3(90f, 0f, 0);
        Road.transform.Rotate(rotation);
        Road.transform.position = new Vector3(15.68f, 2.54f, -4.42f);
    }

    private void CreateStreetLine3()
    {
        GameObject Road = new GameObject();
        Road.name = "StreetLine4";
        Road.transform.parent = transform;

        Vector3 nextPosition = new Vector3(0, 0f, 0f);
        float cubeDepth = 0;

        for (int height = 0; height < baseStreetLineDepthSize; height++)
        {
            for (int length = 0; length < baseStreetLineLengthSize; length++)
            {

                GameObject cubeObject = new GameObject();
                cubeObject.name = "Cube " + height + "-" + length;
                cubeObject.AddComponent<Cube>();
                cubeObject.GetComponent<Cube>().UpdateCubeSize(baseCubeSize);
                cubeObject.GetComponent<Cube>().SetCubeColor(2);
                cubeObject.transform.parent = Road.transform;
                cubeObject.transform.position = nextPosition;
                nextPosition.x = nextPosition.x + (cubeObject.GetComponent<Cube>().CubeSize().x * 2);
                cubeDepth = (cubeObject.GetComponent<Cube>().CubeSize().z * 2);
            }
            nextPosition.x = 0;
            nextPosition.z = nextPosition.z + cubeDepth;
        }
        Vector3 rotation = new Vector3(90f, 0f, 0);
        Road.transform.Rotate(rotation);
        Road.transform.position = new Vector3(3.68f, 2.54f, -4.41f);
    }

    private void CreateStreetLine4()
    {
        GameObject Road = new GameObject();
        Road.name = "StreetLine5";
        Road.transform.parent = transform;

        Vector3 nextPosition = new Vector3(0, 0f, 0f);
        float cubeDepth = 0;

        for (int height = 0; height < baseStreetLineDepthSize; height++)
        {
            for (int length = 0; length < baseStreetLineLengthSize; length++)
            {

                GameObject cubeObject = new GameObject();
                cubeObject.name = "Cube " + height + "-" + length;
                cubeObject.AddComponent<Cube>();
                cubeObject.GetComponent<Cube>().UpdateCubeSize(baseCubeSize);
                cubeObject.GetComponent<Cube>().SetCubeColor(2);
                cubeObject.transform.parent = Road.transform;
                cubeObject.transform.position = nextPosition;
                nextPosition.x = nextPosition.x + (cubeObject.GetComponent<Cube>().CubeSize().x * 2);
                cubeDepth = (cubeObject.GetComponent<Cube>().CubeSize().z * 2);
            }
            nextPosition.x = 0;
            nextPosition.z = nextPosition.z + cubeDepth;
        }
        Vector3 rotation = new Vector3(90f, 90f, 0);
        Road.transform.Rotate(rotation);
        Road.transform.position = new Vector3(-2.32f, 2.54f, 7.58f);
    }

    private void CreateStreetLine5()
    {
        GameObject Road = new GameObject();
        Road.name = "StreetLine6";
        Road.transform.parent = transform;

        Vector3 nextPosition = new Vector3(0, 0f, 0f);
        float cubeDepth = 0;

        for (int height = 0; height < baseStreetLineDepthSize; height++)
        {
            for (int length = 0; length < baseStreetLineLengthSize; length++)
            {

                GameObject cubeObject = new GameObject();
                cubeObject.name = "Cube " + height + "-" + length;
                cubeObject.AddComponent<Cube>();
                cubeObject.GetComponent<Cube>().UpdateCubeSize(baseCubeSize);
                cubeObject.GetComponent<Cube>().SetCubeColor(2);
                cubeObject.transform.parent = Road.transform;
                cubeObject.transform.position = nextPosition;
                nextPosition.x = nextPosition.x + (cubeObject.GetComponent<Cube>().CubeSize().x * 2);
                cubeDepth = (cubeObject.GetComponent<Cube>().CubeSize().z * 2);
            }
            nextPosition.x = 0;
            nextPosition.z = nextPosition.z + cubeDepth;
        }
        Vector3 rotation = new Vector3(90f, 90f, 0);
        Road.transform.Rotate(rotation);
        Road.transform.position = new Vector3(-2.32f, 2.54f, 23.58f);
    }

    private void CreateStreetLine6()
    {
        GameObject Road = new GameObject();
        Road.name = "StreetLine7";
        Road.transform.parent = transform;

        Vector3 nextPosition = new Vector3(0, 0f, 0f);
        float cubeDepth = 0;

        for (int height = 0; height < baseStreetLineDepthSize; height++)
        {
            for (int length = 0; length < baseStreetLineLengthSize; length++)
            {

                GameObject cubeObject = new GameObject();
                cubeObject.name = "Cube " + height + "-" + length;
                cubeObject.AddComponent<Cube>();
                cubeObject.GetComponent<Cube>().UpdateCubeSize(baseCubeSize);
                cubeObject.GetComponent<Cube>().SetCubeColor(2);
                cubeObject.transform.parent = Road.transform;
                cubeObject.transform.position = nextPosition;
                nextPosition.x = nextPosition.x + (cubeObject.GetComponent<Cube>().CubeSize().x * 2);
                cubeDepth = (cubeObject.GetComponent<Cube>().CubeSize().z * 2);
            }
            nextPosition.x = 0;
            nextPosition.z = nextPosition.z + cubeDepth;
        }
        Vector3 rotation = new Vector3(90f, 0f, 0);
        Road.transform.Rotate(rotation);
        Road.transform.position = new Vector3(3.68f, 2.54f, 29.58f);
    }

    private void CreateStreetLine7()
    {
        GameObject Road = new GameObject();
        Road.name = "StreetLine8";
        Road.transform.parent = transform;

        Vector3 nextPosition = new Vector3(0, 0f, 0f);
        float cubeDepth = 0;

        for (int height = 0; height < baseStreetLineDepthSize; height++)
        {
            for (int length = 0; length < baseStreetLineLengthSize; length++)
            {

                GameObject cubeObject = new GameObject();
                cubeObject.name = "Cube " + height + "-" + length;
                cubeObject.AddComponent<Cube>();
                cubeObject.GetComponent<Cube>().UpdateCubeSize(baseCubeSize);
                cubeObject.GetComponent<Cube>().SetCubeColor(2);
                cubeObject.transform.parent = Road.transform;
                cubeObject.transform.position = nextPosition;
                nextPosition.x = nextPosition.x + (cubeObject.GetComponent<Cube>().CubeSize().x * 2);
                cubeDepth = (cubeObject.GetComponent<Cube>().CubeSize().z * 2);
            }
            nextPosition.x = 0;
            nextPosition.z = nextPosition.z + cubeDepth;
        }
        Vector3 rotation = new Vector3(90f, 0f, 0);
        Road.transform.Rotate(rotation);
        Road.transform.position = new Vector3(15.68f, 2.54f, 29.58f);
    }
    #endregion

    #region buildings
    private void CreateBuilding(float randomNumber)
    {
        GameObject Road = new GameObject();
        Road.name = "Building1";
        Road.transform.parent = transform;

        Vector3 nextPosition = new Vector3(0, 0f, 0f);
        float cubeDepth = 0;

        for (int height = 0; height < baseBuildingDepthSize; height++)
        {
            for (int length = 0; length < baseBuildingLengthSize; length++)
            {

                GameObject cubeObject = new GameObject();
                cubeObject.name = "Cube " + height + "-" + length;
                cubeObject.AddComponent<Cube>();
                cubeObject.GetComponent<Cube>().UpdateCubeSize(baseBuildingCubeSize);
                cubeObject.GetComponent<Cube>().SetCubeColor(3);
                cubeObject.transform.parent = Road.transform;
                cubeObject.transform.position = nextPosition;
                nextPosition.x = nextPosition.x + (cubeObject.GetComponent<Cube>().CubeSize().x * 2);
                cubeDepth = (cubeObject.GetComponent<Cube>().CubeSize().z * 2);
            }
            nextPosition.x = 0;
            nextPosition.z = nextPosition.z + cubeDepth;
        }
        Vector3 rotation = new Vector3(90f, 0f, 0);
        Road.transform.Rotate(rotation);
        Road.transform.position = new Vector3(-4.16f + randomNumber, 12.51f, 36.6f);
    }

    private void CreateBuilding1(float randomNumber)
    {
        GameObject Road = new GameObject();
        Road.name = "Building2";
        Road.transform.parent = transform;

        Vector3 nextPosition = new Vector3(0, 0f, 0f);
        float cubeDepth = 0;

        for (int height = 0; height < baseBuildingDepthSize; height++)
        {
            for (int length = 0; length < baseBuildingLengthSize; length++)
            {

                GameObject cubeObject = new GameObject();
                cubeObject.name = "Cube " + height + "-" + length;
                cubeObject.AddComponent<Cube>();
                cubeObject.GetComponent<Cube>().UpdateCubeSize(baseBuildingCubeSize);
                cubeObject.GetComponent<Cube>().SetCubeColor(4);
                cubeObject.transform.parent = Road.transform;
                cubeObject.transform.position = nextPosition;
                nextPosition.x = nextPosition.x + (cubeObject.GetComponent<Cube>().CubeSize().x * 2);
                cubeDepth = (cubeObject.GetComponent<Cube>().CubeSize().z * 2);
            }
            nextPosition.x = 0;
            nextPosition.z = nextPosition.z + cubeDepth;
        }
        Vector3 rotation = new Vector3(90f, 0f, 0);
        Road.transform.Rotate(rotation);
        Road.transform.position = new Vector3(-4.25f + randomNumber, 9.2f, -11.4f);
    }
    private void CreateBuilding2(float randomNumber)
    {
        GameObject Road = new GameObject();
        Road.name = "Building3";
        Road.transform.parent = transform;

        Vector3 nextPosition = new Vector3(0, 0f, 0f);
        float cubeDepth = 0;

        for (int height = 0; height < baseBuildingDepthSize; height++)
        {
            for (int length = 0; length < baseBuildingLengthSize; length++)
            {

                GameObject cubeObject = new GameObject();
                cubeObject.name = "Cube " + height + "-" + length;
                cubeObject.AddComponent<Cube>();
                cubeObject.GetComponent<Cube>().UpdateCubeSize(baseBuildingCubeSize);
                cubeObject.GetComponent<Cube>().SetCubeColor(5);
                cubeObject.transform.parent = Road.transform;
                cubeObject.transform.position = nextPosition;
                nextPosition.x = nextPosition.x + (cubeObject.GetComponent<Cube>().CubeSize().x * 2);
                cubeDepth = (cubeObject.GetComponent<Cube>().CubeSize().z * 2);
            }
            nextPosition.x = 0;
            nextPosition.z = nextPosition.z + cubeDepth;
        }
        Vector3 rotation = new Vector3(90f, 0f, 0);
        Road.transform.Rotate(rotation);
        Road.transform.position = new Vector3(33.72f, 12.58f, -5.30f + randomNumber);
    }
    private void CreateBuilding3(float randomNumber)
    {
        GameObject Road = new GameObject();
        Road.name = "Building4";
        Road.transform.parent = transform;

        Vector3 nextPosition = new Vector3(0, 0f, 0f);
        float cubeDepth = 0;

        for (int height = 0; height < baseBuildingDepthSize; height++)
        {
            for (int length = 0; length < baseBuildingLengthSize; length++)
            {

                GameObject cubeObject = new GameObject();
                cubeObject.name = "Cube " + height + "-" + length;
                cubeObject.AddComponent<Cube>();
                cubeObject.GetComponent<Cube>().UpdateCubeSize(baseBuildingCubeSize);
                cubeObject.GetComponent<Cube>().SetCubeColor(3);
                cubeObject.transform.parent = Road.transform;
                cubeObject.transform.position = nextPosition;
                nextPosition.x = nextPosition.x + (cubeObject.GetComponent<Cube>().CubeSize().x * 2);
                cubeDepth = (cubeObject.GetComponent<Cube>().CubeSize().z * 2);
            }
            nextPosition.x = 0;
            nextPosition.z = nextPosition.z + cubeDepth;
        }
        Vector3 rotation = new Vector3(90f, 0f, 0);
        Road.transform.Rotate(rotation);
        Road.transform.position = new Vector3(-12.3f, 8f, -5.39f + randomNumber);
    }
    private void CreateBuilding4(float randomNumber)
    {
        GameObject Road = new GameObject();
        Road.name = "Building5";
        Road.transform.parent = transform;

        Vector3 nextPosition = new Vector3(0, 0f, 0f);
        float cubeDepth = 0;

        for (int height = 0; height < baseBuildingDepthSize; height++)
        {
            for (int length = 0; length < baseBuildingLengthSize; length++)
            {

                GameObject cubeObject = new GameObject();
                cubeObject.name = "Cube " + height + "-" + length;
                cubeObject.AddComponent<Cube>();
                cubeObject.GetComponent<Cube>().UpdateCubeSize(baseBuildingCubeSize);
                cubeObject.GetComponent<Cube>().SetCubeColor(4);
                cubeObject.transform.parent = Road.transform;
                cubeObject.transform.position = nextPosition;
                nextPosition.x = nextPosition.x + (cubeObject.GetComponent<Cube>().CubeSize().x * 2);
                cubeDepth = (cubeObject.GetComponent<Cube>().CubeSize().z * 2);
            }
            nextPosition.x = 0;
            nextPosition.z = nextPosition.z + cubeDepth;
        }
        Vector3 rotation = new Vector3(90f, 0f, 0);
        Road.transform.Rotate(rotation);
        Road.transform.position = new Vector3(3.72f + randomNumber, 11.57f, 2.61f);
    }
    #endregion

}