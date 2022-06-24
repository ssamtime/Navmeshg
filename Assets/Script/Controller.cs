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
            //RaycastHit ������ �浹�� ������Ʈ�� ��ü�� ������ ����
            RaycastHit hit;
            //ī�޶�κ��� ��ũ�� ������ ���콺 �����͸� ���� ��ġ������ ����
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
