using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpSliderBehaviour : MonoBehaviour
{
    [SerializeField]
    private Slider _Slider = null;

    [SerializeField]
    private GameObject _Fill = null;

    [SerializeField]
    private Sprite _OverrideSprite = null;

    private Image _Progress;

    // Start is called before the first frame update
    void Start()
    {
        _Progress = _Fill.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_Slider == null || _Progress == null) return;

        if (_Slider.value <= 0.33F)
        {
            _Progress.overrideSprite = _OverrideSprite;
        }
        else
        {
            _Progress.overrideSprite = null;
        }
    }
}
