
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

public class PointandClick : MonoBehaviour
{
    [SerializeField] Camera cam;
    [SerializeField] NavMeshAgent agent;

    void Update()
    {
        if (Mouse.current != null &&
            Mouse.current.leftButton.wasPressedThisFrame) //putting left button rn
        {
            Vector2 mousePosition = Mouse.current.position.ReadValue(); // mouse position

            Ray ray = cam.ScreenPointToRay(mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point); // use ai agent to move charcater
            }
        }
    }
}
