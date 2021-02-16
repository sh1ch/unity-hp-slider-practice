using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpSampleDecrementor : MonoBehaviour
{
    [SerializeField]
    private Slider _Slider = null;
    
    [SerializeField]
    public bool IsEnabled = false;

    private float _Max = 1.0F;
    private float _Min = 0.0F;
    private float _Progress;
    private float _Step = 0.001F;

    // Start is called before the first frame update
    void Start()
    {
        Reset();
    }

    // Update is called once per frame
    void Update()
    {
        if (!IsEnabled) return;

        _Progress -= _Step;

        if (_Progress < _Min)
        {
            _Progress = _Min;
            IsEnabled = false;
        }

        _Slider.value = _Progress;
    }

    public void Reset()
    {
        _Progress = _Max;
    }

    public void Decrement(bool isEnabled)
    {
        IsEnabled = isEnabled;
    }
}
