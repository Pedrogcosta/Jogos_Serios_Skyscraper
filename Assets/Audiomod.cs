using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audiomod : MonoBehaviour
{
    [SerializeField]AudioSource src;
    public GameObject player;

    private void Start()
    {
        src = GetComponent<AudioSource>();
        ChangeVolume(0.3f);
    }

    void Update()
    {
        ChangeVolume(0.3f + 0.7f * ((player.transform.position.y-10)/70));
    }

    public void ChangeVolume(float value)
    {
        Debug.Log("Aqui" + value);
        src.volume = value;
    }
}
