using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridDisplay : MonoBehaviour
{
    GridSystem gridSystem;
    public Vector3 gridPos;
    public float xpos;
    public Vector3 mousePos;
    [SerializeField] GameObject instantiatetext;
    // Start is called before the first frame update
    void Start()
    {
        gridSystem = new GridSystem(10,10,2);
        gridSystem.instantiatingtextobjects(instantiatetext.transform);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("length "+gridSystem.gridObjects[1,0].gridPosition);
        /* mousePos = Mouseworldpos.GetMousepos();

         gridPos = new Vector3(gridSystem.GetGridPosition(Mouseworldpos.GetMousepos()).x, 0f, gridSystem.GetGridPosition(Mouseworldpos.GetMousepos()).z);*/

    }
}
