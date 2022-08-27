using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainController : MonoBehaviour
{  
	AudioSource audioSource;
    
    public AudioClip collectedClipOn;
    // Start is called before the first frame update


    // Update is called once per frame 

	 void Start()
    {
        audioSource =GetComponent<AudioSource>();
    }

       public void PlaySound(AudioClip clip) 
   {
      audioSource.PlayOneShot(clip);
   }   


}
