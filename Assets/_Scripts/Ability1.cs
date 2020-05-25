using UnityEngine;

public class Ability1 : MonoBehaviour
{
    Camera cam;

    public LayerMask groundLayer;

    void Awake()
    {
        cam = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            print("Lk");
            // playerAgent.SetDestination(GetPointUnderCurser());
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
