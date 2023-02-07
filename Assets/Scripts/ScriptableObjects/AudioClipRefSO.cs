using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class AudioClipRefSO : ScriptableObject
{
    public AudioClip stoveSizzle; // since it's just one audioClip for this one
    public AudioClip[] chop;
    public AudioClip[] deliveryFail;
    public AudioClip[] deliverySucces;
    public AudioClip[] footstep;
    public AudioClip[] objectDrop;
    public AudioClip[] objectPickup;
    public AudioClip[] trash;
    public AudioClip[] warning;

}
