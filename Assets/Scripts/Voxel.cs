using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voxel : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5; //날라가는 속도

    public float destroyTime = 5.0f; //삭제되는 속도

    float currentTime = 0;

    void Start()
    {
        Vector3 direction = Random.insideUnitSphere; //크기 1/ 방향만 존재

        Rigidbody rb = gameObject.GetComponent<Rigidbody>();

        rb.velocity = direction * speed;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if(currentTime>destroyTime){
            Destroy(gameObject);
        }
    }
}
