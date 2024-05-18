using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class SelectionScreen : MonoBehaviour
{
    public GameObject[] characters;
    public Transform spawn;
    public GameObject cam;
    public GameObject cam2;
    public Button button;
    public Button buttonagain;
    public Button buttontwice;
    public GameObject animalone;
    public GameObject animaltwo;
    public GameObject animalthree;
    public GameObject animalfour;
    public GameObject animalfive;
    public GameObject animalsix;
    public GameObject selectionscreen;
    public GameObject text;

    private int selectedCharacter = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Next()
    {
        selectedCharacter = (selectedCharacter + 1) % characters.Length;
        if (selectedCharacter == 0)
        {
            animalone.SetActive(true);
            animaltwo.SetActive(false);
            animalthree.SetActive(false);
            animalfour.SetActive(false);
            animalfive.SetActive(false);
            animalsix.SetActive(false);
        }
        if (selectedCharacter == 1)
        {
            animalone.SetActive(false);
            animaltwo.SetActive(true);
            animalthree.SetActive(false);
            animalfour.SetActive(false);
            animalfive.SetActive(false);
            animalsix.SetActive(false);
        }
        if (selectedCharacter == 2)
        {
            animalone.SetActive(false);
            animaltwo.SetActive(false);
            animalthree.SetActive(true);
            animalfour.SetActive(false);
            animalfive.SetActive(false);
            animalsix.SetActive(false);
        }
        if (selectedCharacter == 3)
        {
            animalone.SetActive(false);
            animaltwo.SetActive(false);
            animalthree.SetActive(false);
            animalfour.SetActive(true);
            animalfive.SetActive(false);
            animalsix.SetActive(false);
        }
        if (selectedCharacter == 4)
        {
            animalone.SetActive(false);
            animaltwo.SetActive(false);
            animalthree.SetActive(false);
            animalfour.SetActive(false);
            animalfive.SetActive(true);
            animalsix.SetActive(false);
        }
        if (selectedCharacter == 5)
        {
            animalone.SetActive(false);
            animaltwo.SetActive(false);
            animalthree.SetActive(false);
            animalfour.SetActive(false);
            animalfive.SetActive(false);
            animalsix.SetActive(true);
        }
    }

    public void Previous()
    {
        selectedCharacter = (selectedCharacter - 1 + characters.Length) % characters.Length;
        if (selectedCharacter == 0)
        {
            animalone.SetActive(true);
            animaltwo.SetActive(false);
            animalthree.SetActive(false);
            animalfour.SetActive(false);
            animalfive.SetActive(false);
            animalsix.SetActive(false);
        }
        if (selectedCharacter == 1)
        {
            animalone.SetActive(false);
            animaltwo.SetActive(true);
            animalthree.SetActive(false);
            animalfour.SetActive(false);
            animalfive.SetActive(false);
            animalsix.SetActive(false);
        }
        if (selectedCharacter == 2)
        {
            animalone.SetActive(false);
            animaltwo.SetActive(false);
            animalthree.SetActive(true);
            animalfour.SetActive(false);
            animalfive.SetActive(false);
            animalsix.SetActive(false);
        }
        if (selectedCharacter == 3)
        {
            animalone.SetActive(false);
            animaltwo.SetActive(false);
            animalthree.SetActive(false);
            animalfour.SetActive(true);
            animalfive.SetActive(false);
            animalsix.SetActive(false);
        }
        if (selectedCharacter == 4)
        {
            animalone.SetActive(false);
            animaltwo.SetActive(false);
            animalthree.SetActive(false);
            animalfour.SetActive(false);
            animalfive.SetActive(true);
            animalsix.SetActive(false);
        }
        if (selectedCharacter == 5)
        {
            animalone.SetActive(false);
            animaltwo.SetActive(false);
            animalthree.SetActive(false);
            animalfour.SetActive(false);
            animalfive.SetActive(false);
            animalsix.SetActive(true);
        }
    }

    public void select()
    {
        GameObject selected = Instantiate(characters[selectedCharacter], spawn);
        cam.SetActive(true);
        cam2.SetActive(false);
        animalone.SetActive(false);
        animaltwo.SetActive(false);
        animalthree.SetActive(false);
        animalfour.SetActive(false);
        animalfive.SetActive(false);
        animalsix.SetActive(true);
        selectionscreen.SetActive(false);
        text.SetActive(true);
    }

}
