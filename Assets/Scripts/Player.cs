using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    public LayerMask LayerFloor;
    public Transform routeFather;
    int indexChildren;
    Vector3 destination;
    public Vector3 min, max;

    public Vector3 RandomDestination()
    {
        return new Vector3(Random.Range(min.x, max.x), Random.Range(min.z, max.z));
    }

//----------------------------------------------------------------------------------------------------------------------------------

    /* // VA A DONDE HAGAS CLICK
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();
            if (Physics.Raycast(ray, out hit, 1000, LayerFloor))
            {
                GetComponent<NavMeshAgent>().SetDestination(hit.point);
            }
        }
    }
    */

//-------------------------------------------------------------------------------------------------------------------------------

    /* // RUTA POR PUNTOS DE RUTA
    void Start()
    {
        destination = routeFather.GetChild(indexChildren).position;
        GetComponent<NavMeshAgent>().SetDestination(destination);

    }

    void Update(){
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
    
    }
    */

//---------------------------------------------------------------------------------------------------------------------------------

    /* // RUTA ALEATORIA POR PUNTOS DE RUTA
    void Start()
    {
        destination = routeFather.GetChild(indexChildren).position;
        GetComponent<NavMeshAgent>().SetDestination(destination);
    }
    void Update()
    {
        if (Vector3.Distance(transform.position, destination) < 1.5f)
        {
            indexChildren = Random.Range(0, routeFather.childCount);
            destination = routeFather.GetChild(indexChildren).position;
            GetComponent<NavMeshAgent>().SetDestination(destination);
        }
    }
    */

//------------------------------------------------------------------------------------------------------------------------------------

    /* // RUTA ALEATORIA DELIMITADA
    void Start()
    {
        destination = RandomDestination();
        GetComponent<NavMeshAgent>().SetDestination(destination);
    }
    
    void Update()
    {
        if (Vector3.Distance(transform.position, destination) < 1.5f)
        {
            destination = RandomDestination();
            GetComponent<NavMeshAgent>().SetDestination(destination);
        }
    */

//---------------------------------------------------------------------------------------------------------------------------------

    /* // IR A UN PUNTO ALEATORIO DEL NAV MESH 
    void Start()
    {
        destination = RandomDestination();
        GetComponent<NavMeshAgent>().SetDestination(destination);
    }

    void Update()
    {

        if (Vector3.Distance(transform.position, destination) < 1.5f)
        {
            NavMeshHit hit;
            Vector3 randomPoint = Random.insideUnitSphere * 50; //Nos va a dar un punto aleatorio del alrededor
            NavMesh.SamplePosition(randomPoint, out hit, 50, 1); //Da una posicion aleatoria desde un punto dado a una distancia dada y devuelve un NavMeshHit (punto en el NavMesh)  

            destination = hit.position;
            GetComponent<NavMeshAgent>().SetDestination(destination);
        }
    
    }
    */

//-----------------------------------------------------------------------------------------------------------------------------------
}
