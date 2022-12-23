using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PascalCaseClass : MonoBehaviour
{
    protected int _camelMemberField = 0;//null or default in 7.1
    [SerializeField] private int _camelMemberFieldSerialized;
    private const int UPPERCASE_CONSTANT = 21;

    void Start()
    {
        Debug.Log("Starting");
    }

    void Awake()
    {
        Debug.Log("Awake!!");
    }

    void OnEnable()
    {
        Debug.Log("Enabled=1");
    }

    void OnDisable()
    {
        Debug.Log("Enabled=00");
    }

    void Update()
    {
        Debug.Log("Updating...");
    }

    void FixedUpdate()
    {
        Debug.Log(Time.deltaTime);
    }

    void OnMouseDown()
    {
        _camelMemberFieldSerialized++;
        Debug.Log("ClickedWithMouse:" + _camelMemberFieldSerialized);
    }

    void Reset()
    {
        Debug.Log("Reseted :)");
        _camelMemberFieldSerialized = -1;
    }

    public void PascalCaseMethod()
    {
        int camelField = 13;
        _camelMemberField = camelField + UPPERCASE_CONSTANT - _camelMemberFieldSerialized;
    }

}
