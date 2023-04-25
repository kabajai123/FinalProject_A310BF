using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deadbody : MonoBehaviour
{
    AudioSource audio;
    public GameObject deadbd;
    // Start is called before the first frame update
    void Start()
    {
        audio = deadbd.GetComponent<AudioSource>();

    }
    bool doOne = true;

    private void OnTriggerEnter(Collider collision)
    {
        if (doOne && collision.gameObject.tag == "death")
        {

            audio.Play();
            doOne = false;

        }
    }

}
