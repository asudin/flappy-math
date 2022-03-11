using System.Collections;
using UnityEngine;

public class PlayOnClick : MonoBehaviour
{
    [SerializeField] private AudioClip _clip;

    // Making sure the coroutine will be executed only once
    bool soundPlayed = false;

    private void Update()
    {
        PlayClickSound();
    }

    void PlayClickSound()
    {
        if (Input.GetMouseButton(0))
        {
            if (!soundPlayed)
            {
                StartCoroutine(DelaySound());
                soundPlayed = true;
            }
        }
    }
 
    IEnumerator DelaySound()
    {
        SoundManager.Instance.PlaySound(_clip);

        yield return new WaitForSeconds(_clip.length);
    }
}
