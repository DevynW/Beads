using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beadRotator : MonoBehaviour
{
    [SerializeField] GameObject beadChain;
    [SerializeField] float rotationFactor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = new Vector3 (beadChain.transform.rotation.x, beadChain.transform.rotation.y + rotationFactor, beadChain.transform.rotation.z);
        beadChain.transform.Rotate(rot * Time.deltaTime);
    }
}
