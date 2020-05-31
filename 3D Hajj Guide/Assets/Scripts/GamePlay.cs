using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets;


public class GamePlay : MonoBehaviour
{
    int count = 0;
    int counttwo = 0;
    public GameObject[] buttons;

    public GameObject[] Camera;
    public GameObject ihraamInstructions;
    public GameObject MinaInstruction;
    public GameObject Mina2Instruction;
    public GameObject JamratUlUqbahInstruction;
    public GameObject JamaratInstruction;
    public GameObject QurbaniInstruction;
    public GameObject HalqInstruction;
    public GameObject ArafatInstruction;
    public GameObject MuzalifahInstruction;


    public GameObject Makkah, Mina, ArafatANDMasjidNimra, Muzdalifah, Mina2, JamaratUlUqbah, Qurbani, Halq, Jamarat1,tawaafeZiyaraa, Jamarat2, TawafWida;

    public bool isEight, isNine, isTen, isEleven, isTweleth;


    public AudioSource source;
    public AudioClip[] MyClips;

    public Transform[] spawnPoints;

    public GameObject Player;

    public static GamePlay GP;


    // Start is called before the first frame update
    void Awake()
    {

        GP = this;

        if (PlayerPrefs.GetInt("Makkah") == 1)
        {
            Makkah.SetActive(true);
            Instantiate(Player, spawnPoints[0].transform.position, spawnPoints[0].transform.rotation);
            counttwo += 1;
           
            //if (count % 2 != 0)
            //{
                buttons[5].SetActive(true);
                buttons[6].SetActive(true);
                buttons[8].SetActive(true);
                buttons[9].SetActive(true);
                buttons[10].SetActive(true);
                buttons[11].SetActive(true);
                buttons[12].SetActive(true);
           // }
           
        }

        if (PlayerPrefs.GetInt("Mina") == 1)
        {
            Mina.SetActive(true);
            MinaInstruction.SetActive(true);
            Instantiate(Player, spawnPoints[1].transform.position, spawnPoints[1].transform.rotation);
        }
        if (PlayerPrefs.GetInt("ArafatANDMasjidNimra") == 1)
        {
            ArafatANDMasjidNimra.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Muzdalifah") == 1)
        {
            Muzdalifah.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Mina2") == 1)
        {
            Mina2.SetActive(true);
            Instantiate(Player, spawnPoints[0].transform.position, spawnPoints[0].transform.rotation);
            Mina2Instruction.SetActive(true);
        }

        if (PlayerPrefs.GetInt("JamaratUlUqbah") == 1)
        {
            JamaratUlUqbah.SetActive(true);
            //GameObject temp = Player.gameObject;
            Instantiate(Player, spawnPoints[1].transform.position, spawnPoints[1].transform.rotation);
            //GameObject.FindGameObjectWithTag("Player").transform.GetComponentInChildren<Camera>().enabled = true;
           // temp.gameObject.transform.GetChild(9).gameObject.SetActive(true);

            JamratUlUqbahInstruction.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Qurbani") == 1)
        {
            Qurbani.SetActive(true);
            QurbaniInstruction.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Halq") == 1)
        {
            Halq.SetActive(true);
            HalqInstruction.SetActive(true);
        }

        if (PlayerPrefs.GetInt("Jamarat1") == 1)
        {
            Jamarat1.SetActive(true);
            JamaratInstruction.SetActive(true);
        }

        if (PlayerPrefs.GetInt("Tawaaf") == 1)
        {
            tawaafeZiyaraa.SetActive(true);
        }
        
        if (PlayerPrefs.GetInt("Jamarat2") == 1)
        {
            Jamarat2.SetActive(true);
            JamaratInstruction.SetActive(true);
        }

        if (PlayerPrefs.GetInt("TawafWida") == 1)
        {
            TawafWida.SetActive(true);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void cameratoggle()
    {
        if (isEight && PlayerPrefs.GetInt("Mina") == 1)
        {
            count += 1;
            if (count % 2 == 0)
            {
                Camera[0].SetActive(true);
                Camera[1].SetActive(false);
            }
            else
            {
                Camera[0].SetActive(false);
                Camera[1].SetActive(true);
            }
        }
        if (isEight && PlayerPrefs.GetInt("Makkah") == 1)
        {
            count += 1;
            if (count % 2 == 0)
            {
                Camera[2].SetActive(true);
                Camera[3].SetActive(false);
            }
            else
            {
                Camera[2].SetActive(false);
                Camera[3].SetActive(true);
            }
        }
        //Day 9th of Zull Hajj
        if (isNine && PlayerPrefs.GetInt("ArafatANDMasjidNimra") == 1)
        {
            count += 1;
            if (count % 2 == 0)
            {
                Camera[0].SetActive(true);
                Camera[1].SetActive(false);
            }
            else
            {
                Camera[0].SetActive(false);
                Camera[1].SetActive(true);
            }
        }
        if (isNine && PlayerPrefs.GetInt("Muzdalifah") == 1)
        {
            count += 1;
            if (count % 2 == 0)
            {
                Camera[2].SetActive(true);
                Camera[3].SetActive(false);
            }
            else
            {
                Camera[2].SetActive(false);
                Camera[3].SetActive(true);
            }
        }
        //Day 10th of zull Hajj
        if (isTen && PlayerPrefs.GetInt("Mina2") == 1)
        {
            count += 1;
            if (count % 2 == 0)
            {
                Camera[0].SetActive(true);
                Camera[1].SetActive(false);
            }
            else
            {
                Camera[0].SetActive(false);
                Camera[1].SetActive(true);
            }
        }
        if (isTen && PlayerPrefs.GetInt("JamaratUlUqbah") == 1)
        {
            count += 1;
            if (count % 2 == 0)
            {
                Camera[2].SetActive(true);
                Camera[3].SetActive(false);
            }
            else
            {
                Camera[2].SetActive(false);
                Camera[3].SetActive(true);
            }
        }
        if (isTen && PlayerPrefs.GetInt("Qurbani") == 1)
        {
            count += 1;
            if (count % 2 == 0)
            {
                Camera[4].SetActive(true);
                Camera[5].SetActive(false);
            }
            else
            {
                Camera[4].SetActive(false);
                Camera[5].SetActive(true);
            }
        }
        if (isTen && PlayerPrefs.GetInt("Halq") == 1)
        {
            count += 1;
            if (count % 2 == 0)
            {
                Camera[6].SetActive(true);
                Camera[7].SetActive(false);
            }
            else
            {
                Camera[6].SetActive(false);
                Camera[7].SetActive(true);
            }
        }

        //Day11th of Zull Hajj
        if (isEleven && PlayerPrefs.GetInt("Jamarat1") == 1)
        {
            count += 1;
            if (count % 2 == 0)
            {
                Camera[0].SetActive(true);
                Camera[1].SetActive(false);
            }
            else
            {
                Camera[0].SetActive(false);
                Camera[1].SetActive(true);
            }
        }

        //Day 12th Of Hajj
        if (isTweleth && PlayerPrefs.GetInt("Jamarat2") == 1)
        {
            count += 1;
            if (count % 2 == 0)
            {
                Camera[0].SetActive(true);
                Camera[1].SetActive(false);
            }
            else
            {
                Camera[0].SetActive(false);
                Camera[1].SetActive(true);
            }
        }
        if (isTweleth && PlayerPrefs.GetInt("TawafWida") == 1)
        {
            count += 1;
            if (count % 2 == 0)
            {
                Camera[2].SetActive(true);
                Camera[3].SetActive(false);
            }
            else
            {
                Camera[2].SetActive(false);
                Camera[3].SetActive(true);
            }
        }




    }


    public void arrow()

    {
        if (isEight && PlayerPrefs.GetInt("Mina") == 1)
        {


            counttwo += 1;
            if (counttwo % 2 == 0)
            {
                buttons[5].SetActive(false);

                buttons[7].SetActive(false);
            }
            else
            {
                buttons[5].SetActive(true);

                buttons[7].SetActive(true);
            }
        }
        if (isEight && PlayerPrefs.GetInt("Makkah") == 1)
        {
            
            counttwo += 1;
           
            if (counttwo % 2 == 0)
            {
                buttons[5].SetActive(false);
                buttons[6].SetActive(false);
                buttons[8].SetActive(false);
                buttons[9].SetActive(false);
                buttons[10].SetActive(false);
                buttons[11].SetActive(false);
                buttons[12].SetActive(false);
            }

            else
            {
                buttons[5].SetActive(true);
                buttons[6].SetActive(true);
                buttons[8].SetActive(true);
                buttons[9].SetActive(true);
                buttons[10].SetActive(true);
                buttons[11].SetActive(true);
                buttons[12].SetActive(true);
            }

        }
        //Day 9th of Hajj
        if (isNine && PlayerPrefs.GetInt("ArafatANDMasjidNimra") == 1)
        {
            counttwo += 1;
            if (counttwo % 2 == 0)
            {
                buttons[0].SetActive(false);
                buttons[1].SetActive(false);
                buttons[5].SetActive(false);
            }
            else
            {
                buttons[0].SetActive(true);
                buttons[1].SetActive(true);
                buttons[5].SetActive(true);
            }
        }
        if (isNine && PlayerPrefs.GetInt("Muzdalifah") == 1)
        {
            counttwo += 1;
            if (counttwo % 2 == 0)
            {
                buttons[0].SetActive(false);
                buttons[1].SetActive(false);
                buttons[5].SetActive(false);
            }
            else
            {
                buttons[0].SetActive(true);
                buttons[1].SetActive(true);
                buttons[5].SetActive(true);
            }
        }
        //Day 10th of Hajj
        if (isTen && PlayerPrefs.GetInt("Mina2") == 1)
        {
            counttwo += 1;
            if (counttwo % 2 == 0)
            {
                buttons[0].SetActive(false);
                buttons[1].SetActive(false);
                buttons[2].SetActive(false);
            }
            else
            {
                buttons[0].SetActive(true);
                buttons[1].SetActive(true);
                buttons[2].SetActive(true);
            }
        }

        if (isTen && PlayerPrefs.GetInt("JamaratUlUqbah") == 1)
        {
            counttwo += 1;
            if (counttwo % 2 == 0)
            {
                buttons[0].SetActive(false);
                buttons[1].SetActive(false);
                buttons[2].SetActive(false);
            }
            else
            {
                buttons[0].SetActive(true);
                buttons[1].SetActive(true);
                buttons[2].SetActive(true);
            }
        }

        //if (isTen && PlayerPrefs.GetInt("Muzdalifah") == 1)
        //{
        //    counttwo += 1;
        //    if (counttwo % 2 == 0)
        //    {
        //        buttons[].SetActive(false);
        //        buttons[].SetActive(false);
        //        buttons[].SetActive(false);
        //    }
        //    else
        //    {
        //        buttons[].SetActive(true);
        //        buttons[].SetActive(true);
        //        buttons[].SetActive(true);
        //    }
        //}

        //if (isTen && PlayerPrefs.GetInt("Muzdalifah") == 1)
        //{
        //    counttwo += 1;
        //    if (counttwo % 2 == 0)
        //    {
        //        buttons[].SetActive(false);
        //        buttons[].SetActive(false);
        //        buttons[].SetActive(false);
        //    }
        //    else
        //    {
        //        buttons[].SetActive(true);
        //        buttons[].SetActive(true);
        //        buttons[].SetActive(true);
        //    }
        //}
        //    //Day 11 of Hajj
        if (isEleven && PlayerPrefs.GetInt("Jamarat1") == 1)
        {
            counttwo += 1;
            if (counttwo % 2 == 0)
            {
                buttons[0].SetActive(false);
                buttons[1].SetActive(false);


            }
            else
            {
                buttons[0].SetActive(true);
                buttons[1].SetActive(true);

            }
        }
        //Day 12 of Hajj
        if (isTweleth && PlayerPrefs.GetInt("Jamarat2") == 1)
        {
            counttwo += 1;
            if (counttwo % 2 == 0)
            {
                buttons[0].SetActive(false);
                buttons[1].SetActive(false);

            }
            else
            {
                buttons[0].SetActive(true);
                buttons[1].SetActive(true);

            }
        }
        if (isTweleth && PlayerPrefs.GetInt("Tawaf Wida") == 1)
        {
            counttwo += 1;
            if (counttwo % 2 == 0)
            {
                buttons[0].SetActive(false);
                buttons[1].SetActive(false);
                buttons[4].SetActive(false);


            }
            else
            {
                buttons[0].SetActive(true);
                buttons[1].SetActive(true);
                buttons[4].SetActive(true);
            }
        }

    }

    public void MovetoMenu()
    {

        SceneManager.LoadScene("MainMenu");
    }


    public void EightDay()
    {
        buttons[0].SetActive(true);
        buttons[1].SetActive(true);



    }

    public void NinthDay()
    {
        if (isEight)
        {
            buttons[2].SetActive(true);
            buttons[3].SetActive(true);
            buttons[4].SetActive(true);
        }
        if (isNine)
        {
            buttons[2].SetActive(true);
            buttons[3].SetActive(true);
            buttons[4].SetActive(true);
        }

    }
    public void TenthDay()
    {
        if (isNine)
        {
            buttons[6].SetActive(true);
            buttons[7].SetActive(true);
            buttons[8].SetActive(true);
            buttons[9].SetActive(true);
        }
        if (isTen)
        {
            buttons[3].SetActive(true);
            buttons[4].SetActive(true);
            buttons[5].SetActive(true);
            buttons[6].SetActive(true);

        }

    }

    public void EleventhDay()
    {
        if (isTen)
        {
            {
                buttons[7].SetActive(true);

            }
        }


    }


    public void TwelvethDay()
    {
        if (isEleven)
        {

            buttons[2].SetActive(true);
            buttons[3].SetActive(true);
        }
        if (isTweleth)
        {
            buttons[2].SetActive(true);
            buttons[3].SetActive(true);
        }
    }


    //scene changingn to 8thday of HAJJ

    public void MovetoMakkah()
    {

        SceneManager.LoadScene("8thDay");
        PlayerPrefs.SetInt("Makkah", 1);
        PlayerPrefs.SetInt("Mina", 0);
    }
    public void MovetoMina()
    {

        SceneManager.LoadScene("8thDay");
        PlayerPrefs.SetInt("Mina", 1);
        PlayerPrefs.SetInt("Makkah", 0);

    }
    //Scene changing to 9th day of HAjj
    public void MovetoArafatAndMasjidNimra()
    {

        SceneManager.LoadScene("9thDay");
        PlayerPrefs.SetInt("ArafatANDMasjidNimra", 1);
        PlayerPrefs.SetInt("Muzdalifa", 0);
    }



    public void MovetoMuzdalifa()
    {
        SceneManager.LoadScene("9thDay");
        PlayerPrefs.SetInt("Muzdalifa", 1);
        PlayerPrefs.SetInt("ArafatANDMasjidNimra", 0);
    }


    //Scnene Changing to 10th day of Hajj
    public void MovetoMina2()
    {
        SceneManager.LoadScene("10thDay");
        PlayerPrefs.SetInt("Mina2", 1);
        PlayerPrefs.SetInt("JamaratUlUqbah", 0);
        PlayerPrefs.SetInt("Qurbani", 0);
        PlayerPrefs.SetInt("Halq", 0);
    }

    public void MovetoJamaratUlUqbah()
    {
        SceneManager.LoadScene("10thDay");
        PlayerPrefs.SetInt("JamaratUlUqbah", 1);
        PlayerPrefs.SetInt("Mina2", 0);
        PlayerPrefs.SetInt("Qurbani", 0);
        PlayerPrefs.SetInt("Halq", 0);
    }

    public void MovetoQurbani()
    {
        SceneManager.LoadScene("10thDay");
        PlayerPrefs.SetInt("Qurbani", 1);
        PlayerPrefs.SetInt("Mina2", 0);
        PlayerPrefs.SetInt("JamaratUlUqbah", 0);
        PlayerPrefs.SetInt("Halq", 0);
    }

    public void MovetoHalq()
    {
        SceneManager.LoadScene("10thDay");
        PlayerPrefs.SetInt("Halq", 1);
        PlayerPrefs.SetInt("Mina2", 0);
        PlayerPrefs.SetInt("JamaratUlUqbah", 0);
        PlayerPrefs.SetInt("Qurbani", 0);
    }


    //Scene changing to 11th day of hajj
    public void MovetoJamarat()
    {
        SceneManager.LoadScene("11thDay");
        PlayerPrefs.SetInt("Jamarat1", 1);
    }

    // Scene changes to 12th Day of Hajj
    public void MovetoJamarat2()
    {
        SceneManager.LoadScene("12thDay");
        PlayerPrefs.SetInt("Jamarat2", 1);
        PlayerPrefs.SetInt("TawafWida", 0);
    }

    public void MovetoTawafWida()
    {
        SceneManager.LoadScene("12thDay");
        PlayerPrefs.SetInt("TawafWida", 1);
        PlayerPrefs.SetInt("Jamarat2", 0);

    }



    public void IhraamBtn()
    {
        GameObject.FindWithTag("Player").GetComponent<CharacterAnimationHandler>().IhramAction();
    }
}