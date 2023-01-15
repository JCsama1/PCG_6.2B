using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialsBuilder
{
    private List<Material> materialsList = new List<Material>();

    public MaterialsBuilder()
    {
        Material blackMaterial = new Material(Shader.Find("Specular"));
        blackMaterial.color = Color.black;

        Material greyMaterial = new Material(Shader.Find("Specular"));
        greyMaterial.color = Color.grey;

        Material whiteMaterial = new Material(Shader.Find("Specular"));
        whiteMaterial.color = Color.white;

        Material redMaterial = new Material(Shader.Find("Specular"));
        redMaterial.color = Color.red;

        Material blueMaterial = new Material(Shader.Find("Specular"));
        blueMaterial.color = Color.blue;

        Material greenMaterial = new Material(Shader.Find("Specular"));
        greenMaterial.color = Color.green;


        materialsList.Add(blackMaterial);
        materialsList.Add(greyMaterial);
        materialsList.Add(whiteMaterial);
        materialsList.Add(redMaterial);
        materialsList.Add(blueMaterial);
        materialsList.Add(greenMaterial);
    }

    public List<Material> MaterialsList(){
        return materialsList;
    }
}
