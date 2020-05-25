using UnityEngine;
using UnityEngine.AI;

public class Playercontroller : MonoBehaviour
{
    Camera cam;

    public LayerMask groundLayer;
    public NavMeshAgent playerAgent;

    void Awake()
    {
        cam = Camera.main;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            playerAgent.SetDestination(GetPointUnderCurser());
        }
    }

    private Vector3 GetPointUnderCurser()
    {
        //Vector2 screenPosition = Input.mousePosition;
        //Vector3 mouseWorldPosition = cam.ScreenToWorldPoint(screenPosition);

        RaycastHit hitPosition;
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        Physics.Raycast(ray ,out hitPosition, 100, groundLayer);
        Debug.Log(hitPosition.point);

        return hitPosition.point;
    }

}
