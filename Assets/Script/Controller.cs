using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Controller : MonoBehaviour
{
    public float speed = 5.0f;
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            //RaycastHit 광선과 충돌한 오브젝트의 물체의 정보를 저장
            RaycastHit hit;
            //카메라로부터 스크린 공간의 마우스 포인터를 통해 위치정보를 설정
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            
            if(Physics.Raycast(ray,out hit, Mathf.Infinity))
            {
                Move(hit.point);
            }    
        }
    }
    public void Move(Vector3 Position)
    {
        agent.speed = speed;
        agent.SetDestination(Position);
    }
}
