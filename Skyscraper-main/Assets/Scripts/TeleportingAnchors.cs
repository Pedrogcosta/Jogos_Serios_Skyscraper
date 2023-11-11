using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TeleportingAnchors : MonoBehaviour
{
    int currAnchor = 0;
    TeleportationAnchor currTeleportationAnchor;

    void Start()
    {
        currTeleportationAnchor = GetComponent<TeleportationAnchor>();
        currTeleportationAnchor.teleporting.AddListener(Teleporting);

        string tag = currTeleportationAnchor.gameObject.tag;
        int.TryParse(tag.Substring(6), out currAnchor);
        if (currAnchor != 1)
        {
            currTeleportationAnchor.enabled = false;
            currTeleportationAnchor.gameObject.GetComponent<MeshRenderer>().enabled = false;
        }
    }

    void Teleporting(TeleportingEventArgs args)
    {
        currTeleportationAnchor.enabled = false;
        currTeleportationAnchor.gameObject.GetComponent<MeshRenderer>().enabled = false;

        try
        {
            string nextAnchor = "anchor" + (currAnchor + 1);
            TeleportationAnchor nextTeleportationAnchor = GameObject.FindWithTag(nextAnchor).GetComponent<TeleportationAnchor>();
            if (nextTeleportationAnchor)
            {
                nextTeleportationAnchor.enabled = true;
                nextTeleportationAnchor.gameObject.GetComponent<MeshRenderer>().enabled = true;
            }
        }
        catch (System.Exception e)
        {
            Debug.LogError("Error: " + e.Message);
        }
    }
}
