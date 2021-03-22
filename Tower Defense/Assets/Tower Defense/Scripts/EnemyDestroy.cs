using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour
{

    public GameObject BigBadGuy;
    public GameObject SmallBadGuy;
    public int points = 0;

    
    // Start is called before the first frame update
    void Start()
    {
        BigBadGuy.GetComponent<GameObject>();
        SmallBadGuy.GetComponent<GameObject>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);


            if (Physics.Raycast(ray, out hit))
            {
                BoxCollider bc = hit.collider as BoxCollider;

                if (bc != null)
                {
                    Destroy(bc.gameObject);

                    if (bc.gameObject.tag == "BigBadGuy" || bc.gameObject.tag == "SmallBadGuy") 
                    {
                        points++;
                        Debug.Log("Enemy Killed, point scored");
                    }

                }
            }
        }
    }
}
