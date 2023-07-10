using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieOnClick : MonoBehaviour {
    public GameObject ragdollPrefab;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject ragdoll = Instantiate(ragdollPrefab, transform.position, transform.rotation);
            playSameClip(GetComponent<Animator>(), ragdoll.GetComponent<Animator>());
            Destroy(gameObject);
        }
	}

    void playSameClip(Animator sourceAnim, Animator targetAnim)
    {
        AnimatorClipInfo[] clipInfos =  sourceAnim.GetCurrentAnimatorClipInfo(0);
        AnimatorStateInfo stateInfo = sourceAnim.GetCurrentAnimatorStateInfo(0);
        AnimationClip clip = clipInfos[0].clip;
        targetAnim.Play(clip.name, 0, stateInfo.normalizedTime);
    }
}
