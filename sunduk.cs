using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class sunduk : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnControllerColliderHit(ControllerColliderHit col){
        if(col.gameObject.tag == "sunduk"){
            Destroy(col.gameObject);
            score = score + 1;
            text.text = score + "";
        
        }
    }
}
