using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicker : MonoBehaviour
{
    private int _score;
    private Camera _camera;


    private void Awake()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = _camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out var hit, 100))
            {
                if (hit.transform.TryGetComponent(out Clicker clicker))
                {
                    ++_score;
                    Debug.Log($"Clicked {_score} ");
                }
            }
        }
    }
}