using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundManager : MonoBehaviour
{
    public static GroundManager instance { get; private set; }

    public GameObject groundPrefab;

    public int groundStartedCount = 3; // 3tane sahnede hazýr
    public float groundZSize = 100;

    private void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(this);
        }else
        {
            instance = this;
        }
    }

    private void Start()
    {
    }

    public void IncreaseGroundCount()
    {
        groundStartedCount++;
    }
}
