using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class HpSampleButton : MonoBehaviour
{
    [SerializeField]
    private GameObject _Button = null;

    [SerializeField]
    private Slider _Slider = null;

    private HpSampleDecrementor _Decrement = null;

    void Start()
    {
        _Decrement = _Button.GetComponent<HpSampleDecrementor>();

    }

    public void InitDecrement()
    {
        if (_Decrement == null || _Slider == null) return;

        _Slider.value = 1.0F;
        _Decrement.Reset();
    }

    public bool IsCompleted()
    {
        return (_Slider?.value ?? 0.0f) <= 0.0F;
    }

    public void StartDecrement()
    {
        if (IsCompleted())
        {
            _Decrement.Reset();
        }

        _Decrement.IsEnabled = true;
    }

    public void StopDecrement()
    {
        _Decrement.IsEnabled = false;
    }
}
