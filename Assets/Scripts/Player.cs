using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    public LayerMask LayerFloor;
    public Transform routeFather;
    int indexChildren;
    Vector3 destination;
    void Start()
    {
        destination = routeFather.GetChild(indexChildren).position;
        GetComponent<NavMeshAgent>().SetDestination(destination);
    }

    void Update()
    {
        /* Va a donde hagas click
        if (Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();
            if (Physics.Raycast(ray, out hit, 1000, LayerFloor))
            {
                GetComponent<NavMeshAgent>().SetDestination(hit.point);
            }
        }
        */

        /* RUTA POR PUNTOS DE RUTA
        if (Vector3.Distance(transform.position, destination) < 1.5f)
        {
            indexChildren++;
            if (indexChildren >= routeFather.childCount)
            {
                indexChildren = 0;
            }
            destination = routeFather.GetChild(indexChildren).position;
            GetComponent<NavMeshAgent>().SetDestination(destination);
        }
        */
    }
}
