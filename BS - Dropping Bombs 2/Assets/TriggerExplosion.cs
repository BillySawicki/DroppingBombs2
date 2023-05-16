using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerExplosion : MonoBehaviour
{
    [Header("Explosion Parts")]
    public GameObject Explosion;

    private void OnCollisionEnter(Collision collision){
        Instantiate(Explosion, transform.position, transform.rotation);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
