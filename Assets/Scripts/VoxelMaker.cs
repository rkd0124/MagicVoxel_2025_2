using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoxelMaker : MonoBehaviour
{
    public GameObject voxleFactory;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))  //사용자가 버튼을 누르면
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitinfo = new RaycastHit();

            if (Physics.Raycast(ray, out hitinfo)) //마우스 클릭한 곳이 바닥이면
            {
                GameObject voxel = Instantiate(voxleFactory);
                voxel.transform.position = hitinfo.point;
            }
        }
    }
}
