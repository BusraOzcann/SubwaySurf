using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    private GameObject player;
    private bool changedPos = false;
    private bool coroutineStarted = false;


    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }


    private void Update()
    {
        if (changedPos == false) CheckPos();
        

        if (changedPos && !coroutineStarted)
        {
            coroutineStarted = true;
            StartCoroutine(ChangePosition());
        }
    }

    void CheckPos()
    {
        if (player.transform.position.z > gameObject.transform.position.z + GroundManager.instance.groundZSize)
        {
            changedPos = true;
        }
    }

    IEnumerator ChangePosition()
    {
        yield return new WaitForSeconds(2f);
        Vector3 pos = new Vector3(transform.position.x, transform.position.y, GroundManager.instance.groundZSize * GroundManager.instance.groundStartedCount);
        transform.position = pos;
        GroundManager.instance.IncreaseGroundCount();
        changedPos = false;
        coroutineStarted = false;
        StopCoroutine(ChangePosition());
    }
}
