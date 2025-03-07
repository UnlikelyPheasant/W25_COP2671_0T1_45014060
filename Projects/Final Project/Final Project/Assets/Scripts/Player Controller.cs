using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class PlayerController : MonoBehaviour
{
    static string Horizontal = nameof(Horizontal);
    static string Vertical = nameof(Vertical);

    NavMeshAgent navAgent;
    float forward => Input.GetAxis(Vertical);
    float turn => Input.GetAxis(Horizontal);

    void Awake()
    {
        navAgent = GetComponent<NavMeshAgent>();

    }

    void Update()
    {
        navAgent.Move(transform.forward * forward * navAgent.speed * Time.deltaTime);
        transform.Rotate(Vector3.up, turn * navAgent.angularSpeed * Time.deltaTime);
    }
}
