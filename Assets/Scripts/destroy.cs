using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    // Start is called before the first frame update
 
    public GameObject player;
    public Vector3 pos;
    void Start()
    {
        pos = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
       // player = other.gameObject.transform;
        Debug.Log(other.name);
        // Destroy(other.gameObject);
        player.SetActive(false);
        Invoke("Respawn", 3f);
        //Respawn();
    }

    private void Respawn()
    {
        //GameObject p1 = Instantiate(player);
         player.transform.position=pos;
        player.SetActive(true);
       // p1.AddComponent()
       
    }
}
