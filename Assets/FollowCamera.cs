using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollowing;

    // Update is called once per frame
    void Update()
    {
        transform.position = thingToFollowing.transform.position + new Vector3(8, 1.5f, -10);
    }
}
