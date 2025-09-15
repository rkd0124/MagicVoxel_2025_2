using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoxelMaker : MonoBehaviour
{
    public GameObject voxleFactory;

    public int voxelPoolSize = 20;

    public static List<GameObject> voxelPool = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < voxelPoolSize; i++)
        {
            GameObject voxel = Instantiate(voxleFactory);

            voxel.SetActive(false);

            voxelPool.Add(voxel);
        }
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
                if (voxelPool.Count > 0)
                {
                    GameObject voxel = voxelPool[0]; //풀의 최상단꺼 가져옴
                    voxel.SetActive(true); //그거 활성화

                    voxel.transform.position = hitinfo.point; //클릭한 위치에 생성
                    voxelPool.RemoveAt(0); //풀 하나 삭제
                    
                }

            }
        }
    }
}
