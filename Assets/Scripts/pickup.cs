using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickup : MonoBehaviour
{
    //public GameObject textObj;
    scrupdate so;
   
    public Text scoreText;

   
    // Start is called before the first frame update
    void Start()
    {
        so = scoreText.GetComponent<scrupdate>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
        so.score++;
        scoreText.text = "Score:" + so.score.ToString();
    }
}
