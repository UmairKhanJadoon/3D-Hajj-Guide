using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SWS;

public class CharacterAnimationHandler : MonoBehaviour
{
    public Animator characterAnimator;
    public GameObject childCamera;



    private void Start()
    {
        characterAnimator = GetComponent<Animator>();
        


        if (PlayerPrefs.GetInt("Mina") == 1)
        {
            characterAnimator.SetBool("isIdle", true);
            StartCoroutine(characterAnimationDelay());
        }

        if (PlayerPrefs.GetInt("Mina2") == 1)
        {
            characterAnimator.SetBool("isIdle", true);
            StartCoroutine(characterAnimationDelay2());
        }

        if (PlayerPrefs.GetInt("JamaratUlUqbah") == 1)
        {
            //characterAnimator.SetBool("isWalkingPlace", true);
            characterAnimator.SetBool("isIdle", true);
            childCamera.SetActive(true);
            StartCoroutine(JamraatDelay());
        }
    }



    // Mina1 character starting Animation delays...............

    IEnumerator characterAnimationDelay()
    {
        yield return new WaitForSeconds(2f);
        characterAnimator.SetBool("isIdle", false);
        characterAnimator.SetBool("isWalking", true);
        GamePlay.GP.source.PlayOneShot(GamePlay.GP.MyClips[0], 2f);
        yield return new WaitForSeconds(15f);
        characterAnimator.SetBool("isWalking", false);
        characterAnimator.SetBool("isIdle", true);

    }

    // Mina2 character starting Animation delays...............

    IEnumerator characterAnimationDelay2()
    {
        yield return new WaitForSeconds(2f);
        characterAnimator.SetBool("isIdle", false);
        characterAnimator.SetBool("isWalking", true);
        //GamePlay.GP.source.PlayOneShot(GamePlay.GP.MyClips[0], 2f);
        yield return new WaitForSeconds(15f);
        characterAnimator.SetBool("isWalking", false);
        characterAnimator.SetBool("isIdle", true);

    }

    // Jamraat character starting Animation delays...............

    IEnumerator JamraatDelay()
    {
       
        this.gameObject.GetComponent<splineMove>().moveToPath = true;
        this.gameObject.GetComponent<splineMove>().pathContainer = GameObject.FindObjectOfType<PathManager>();
        characterAnimator.SetBool("isIdle", false);
        characterAnimator.SetBool("isWalkingPlace", true);
        yield return new WaitForSeconds(10f);
        characterAnimator.SetBool("isWalkingPlace", false);
        characterAnimator.SetBool("isThrow", true);
        characterAnimator.SetBool("isIdle", false);
        GamePlay.GP.source.PlayOneShot(GamePlay.GP.MyClips[0], 2f);
        StartCoroutine(StoneThrow());



    }
    int stoneCount = 1;
    IEnumerator StoneThrow()
    {
       
        yield return new WaitForSeconds(2.23f);
        characterAnimator.SetBool("isThrow", false);
        characterAnimator.SetBool("isIdle", true);
        yield return new WaitForSeconds(2f);
        characterAnimator.SetBool("isIdle", false);
        characterAnimator.SetBool("isThrow", true);

        stoneCount += 1;
        
       
        if (stoneCount <= 7)
        {
            GamePlay.GP.source.PlayOneShot(GamePlay.GP.MyClips[0], 2f);
            StartCoroutine(StoneThrow());

            Debug.Log("Anim continued");
        }
        else
        {
            StopCoroutine(StoneThrow());
            characterAnimator.SetBool("isIdle", true);
            characterAnimator.SetBool("isThrow", false);
            Debug.Log("Anim finished");
        }
        

    }





        public void IhramAction()
    {
        StopCoroutine(IhraamAnimationDelay());
        StartCoroutine(IhraamAnimationDelay());

    }


    // Ihraam Guide Animations.....
    IEnumerator IhraamAnimationDelay()
    {
        GamePlay.GP.ihraamInstructions.SetActive(true);
        characterAnimator.SetBool("isIhram", true);
        characterAnimator.SetBool("isIdle", false);
        yield return new WaitForSeconds(2.26f);
        characterAnimator.SetBool("isIhram", false);
        characterAnimator.SetBool("isIdle", true);
        GamePlay.GP.ihraamInstructions.SetActive(false);
        StopCoroutine(IhraamAnimationDelay());
    }

}
