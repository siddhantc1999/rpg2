using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSelectedVisual : MonoBehaviour
{
    [SerializeField] private Unit unit;
    MeshRenderer meshRenderer;
    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
       
        UnityActionSystem.Instance.OnSelectedUnitChanged += UnityActionSystem_OnSelectedUnitChanged;
        UpdateVisual();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UnityActionSystem_OnSelectedUnitChanged(object obj, EventArgs Empty)
    {
        UpdateVisual();
    }

    private void UpdateVisual()
    {
        if (UnityActionSystem.Instance.GetSelectedUnit() == unit)
        {
            meshRenderer.enabled = true;
        }
        else
        {
            meshRenderer.enabled = false;
        }
    }
}
