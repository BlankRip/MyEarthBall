using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkScript : MonoBehaviour
{
    MeshRenderer meshRender;
    [SerializeField] ParticleSystem whitBlast;
    [SerializeField] GameObject mainCamera;
    [SerializeField] GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        meshRender = GetComponent<MeshRenderer>();
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "MovingThing")
        {
            StartCoroutine(ChangeCam());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ChangeCam()
    {
        yield return new WaitForSeconds(1f);
        mainCamera.SetActive(false);
        camera.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        whitBlast.Play();
        meshRender.enabled = false;
    }
}
