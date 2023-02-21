using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defense : MonoBehaviour
{
    bool isRetreating = false;
    bool isReturning = false;
    bool isDefending = false;
    private float totalSeconds = 0.8f;
    private float invulnerable = 0.4f;
    private float offset = 0.2f;

    [SerializeField] private float _totalSeconds = 0.8f;
    [SerializeField] private float _invulnerable = 0.4f;
    [SerializeField] private float _offset = 0.2f;
    [SerializeField] GameObject card;
    [SerializeField] Transform retreatedPos;
    [SerializeField] Transform originalPos;

    public float _TotalSeconds { get => _totalSeconds; set => _totalSeconds = value; }
    public float _Invulnerable { get => _invulnerable; set => _invulnerable = value; }
    public float _Offset { get => _offset; set => _offset = value; }
    public float TotalSeconds { get => totalSeconds; set => totalSeconds = value; }
    public float Invulnerable { get => invulnerable; set => invulnerable = value; }
    public float Offset { get => offset; set => offset = value; }

    // Start is called before the first frame update
    void Start()
    {
        _TotalSeconds = TotalSeconds;
        _Invulnerable = Invulnerable;
        _Offset = Offset;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
