using System.Collections;
using UnityEngine;

public class PlayOnClick : MonoBehaviour
{
    [SerializeField] private AudioClip _clip;

    // Making sure the coroutine will be executed only once
    bool SoundPlayed = false;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (!SoundPlayed)
            {
                StartCoroutine(PlaySound());
                SoundPlayed = true;
            }
        }
    }

    IEnumerator PlaySound()
    {
        SoundManager.Instance.PlaySound(_clip);

        yield return new WaitForSeconds(_clip.length);
    }
}
