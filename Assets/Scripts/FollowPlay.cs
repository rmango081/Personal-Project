using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlay : MonoBehaviour
{
    public Transform[] targets;
    private Transform currentTarget;

    // Start is called before the first frame update
    void Start()
    {
        if (targets.Length > 0){
            currentTarget = targets[0];
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 offset = new Vector3(0,3,-10);
        if (targets.Length > 0){
            currentTarget = targets[0];
        }
        if (currentTarget !=null){
            transform.position = currentTarget.position + offset;
        }
    }
}
