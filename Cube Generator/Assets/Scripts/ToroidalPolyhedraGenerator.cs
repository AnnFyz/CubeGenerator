using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToroidalPolyhedraGenerator : MonoBehaviour
{
    [SerializeField] Material myMaterial;
    MeshFilter myMeshFilter;
    MeshRenderer myRenderer;
    void Start()
    {
        myRenderer = gameObject.AddComponent<MeshRenderer>();
        myMeshFilter = gameObject.AddComponent<MeshFilter>();
        GenerateToroidalPolyhedra();
    }


    void GenerateToroidalPolyhedra()
    {
        Mesh myMesh = new Mesh();

        Vector3[] vL = new Vector3[6]
       {
            new Vector3 (0,0,0),
            new Vector3 (-1,1,-1),
            new Vector3 (0,2,-1),
            new Vector3 (2,2,0),
            new Vector3 (2,1,0),
            new Vector3 (2,0,0)
       };

        //Vector3[] myVertices = new Vector3[24]
        //  {
        //      //
        //      vL[0], vL[1], vL[2], vL[3],
        //      vL[1], vL[4], vL[5], vL[2],
        //      vL[1], vL[4], vL[5], vL[2],

        //  };

        }

}
