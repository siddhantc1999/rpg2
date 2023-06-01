using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityActionSystem : MonoBehaviour
{
    public event EventHandler OnSelectedUnitChanged;
    [SerializeField] private LayerMask unitlayermask;
    [SerializeField] private Unit selectedUnit;
    public static UnityActionSystem Instance
    { 
     get;
     private set;
    }
    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
    
        if(Input.GetMouseButtonDown(1))
        {
            if (TryHandleUnitSelection())
                return;
            selectedUnit.Settargetpos(Mouseworldpos.GetMousepos());
        }
    }

    private bool TryHandleUnitSelection()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit raycasthit, float.MaxValue, unitlayermask))
        {
            if (raycasthit.transform.TryGetComponent<Unit>(out Unit unit))
            {
                SetSelectedUnit(unit);
                return true;
            }
        }
        return false;
    }
    public void SetSelectedUnit(Unit unit)
    {
        selectedUnit = unit;
        OnSelectedUnitChanged?.Invoke(this,EventArgs.Empty); 
    }
    public Unit GetSelectedUnit()
    {
        return selectedUnit;
    }
}
