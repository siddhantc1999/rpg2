using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GridDebugObject : MonoBehaviour
{

    [SerializeField] TextMeshPro gridtext;
   public GridObject gridObject;
    public float xcheck;
    public float zcheck;
    public Vector3 realpos;
    public Vector3 transformpos;
    bool istart=false;
    // Start is called before the first frame update
    void Start()
    {
       /* Debug.Log(returngridobject());*/
    }
    void Update()
    {
        //Debug.Log("gridobject "+ gridObject.gridPosition);
        //gridtext.text = gridObject.ToString();
        // if (zcheck == 9)
        //{
        //    Debug.Log(xcheck);
        //    Debug.Log(realpos);
        //    //Debug.Log(gridObject.gridPosition +" and pos"+ realpos + "and the realppos "+transform.position);
        //}
        //if (zcheck >= 8f && !istart)
        //{
        //    istart = true;
        //    Debug.Log("gridposition " + gridObject.gridPosition);
        //    Debug.Log("transform positio " + gameObject.transform.position);
        //}
        //if (xcheck == 9 && zcheck == 9)
        //{
        //    gameObject.transform.position = realpos;
        //}
    }
    public void SetGridObject(GridObject gridObject,Vector3 pos)
    {

        //Debug.Log("gridposition " + gridObject.gridPosition);
        //Debug.Log("position " + pos);
        this.gridObject = gridObject;
        xcheck = gridObject.gridPosition.x;
        zcheck = gridObject.gridPosition.z;
        gridtext.text = gridObject.ToString();
        gameObject.name= gridObject.ToString();
        realpos = pos;
        
        //if (xcheck==9 && zcheck==9)
        //{
        //    Debug.Log("the check name "+gameObject.name);
        //    Debug.Log("9 gameobject positionm "+transform.position);
        //}
       
    }
    public GridObject returngridobject()
    {
      
        return gridObject;
    }

    // Update is called once per frame
   

}
