using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetInteraction : MonoBehaviour {
    private BoxCollider boxCol;
    public Renderer[] renderers;
    public AudioClip audioClip;
    public SequenceState seqState;
    public AudioManagerSingleton audioManager;

	// Use this for initialization
	void Start () {
        boxCol = GetComponent<BoxCollider>();
        renderers = GetComponentsInChildren<Renderer>();

        audioManager = AudioManagerSingleton.Instance;
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other) {
        Debug.Log("Triggered");
        foreach (Renderer renderer in renderers) {
            renderer.material.color = Color.green;
        }

        MessageGameController();
        PlayAudio();
    }

    public void PlayAudio() {

        //audioManager.SetClip(seqState.successClip);
        Debug.Log("playing audio");
        audioManager.PlayClipAt(seqState.successClip, this.transform.position);

    }

    public void MessageGameController() {
        Debug.Log("Tell GM trigger entered");
    }


}
