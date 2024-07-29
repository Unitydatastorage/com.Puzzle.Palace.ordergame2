using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Z50 : MonoBehaviour
{
    [SerializeField] GameObject z1;
    [SerializeField] GameObject z2;
    [SerializeField] GameObject z3;
    [SerializeField] GameObject z4;
    [SerializeField] GameObject z5;
    [SerializeField] GameObject z6;
    [SerializeField] GameObject z7;
    [SerializeField] GameObject z8;
    [SerializeField] GameObject[] z9;
    [SerializeField] TextMeshProUGUI z10;
    [SerializeField] TextMeshProUGUI z11;
    [SerializeField] GameObject z12;
    [SerializeField] GameObject z13;
    [SerializeField] Z67 z16;
    [SerializeField] TextMeshProUGUI z17;
    [SerializeField] TextMeshProUGUI z18;
    [SerializeField] TextMeshProUGUI z19;
    [SerializeField] Color z20;
    [SerializeField] Color z21;
    [SerializeField] Image z22;
    [SerializeField] Image z23;
    [SerializeField] AudioSource z26;
    [SerializeField] AudioClip z27;
    [SerializeField] AudioClip z28;
    private bool z14;
    private bool z15;
    private int z24;
    private int z25;
    public static bool z29;

    private void Start()
    {
        var z30 = PlayerPrefs.GetInt("z30", 0);
        z24 = PlayerPrefs.GetInt("z24", 1);
        z25 = PlayerPrefs.GetInt("z25", 1);
        if (z25 == 1)
        {
            z23.color = z21;
            z26.clip = z27;
            z26.Play();
        }
        else
        {
            z23.color = z20;
            z26.Stop();
        }

        if (z24 == 1)
        {
            z22.color = z21;
        }
        else
        {
            z22.color = z20;
        }

        if (z30 == 0)
        {
            z2.SetActive(true);
            z1.SetActive(false);
        }
        else
        {
            z1.SetActive(true);
            z2.SetActive(false);
        }

        z3.SetActive(false);
        z4.SetActive(false);
        z5.SetActive(false);
        z6.SetActive(false);
        z7.SetActive(false);
        z8.SetActive(false);
    }

    public void Z31()
    {
        if (z24 == 1)
        {
            z26.PlayOneShot(z28, 1f);
        }
    }

    public void Z32()
    {
        Z31();
        PlayerPrefs.SetInt("z30", 1);
        PlayerPrefs.Save();
        z2.SetActive(false);
        z1.SetActive(true);
    }

    public void Z33()
    {
        Z31();
        z4.SetActive(true);
        z2.SetActive(false);
        z14 = true;
    }

    public void Z34()
    {
        Z31();
        z4.SetActive(false);
        if (z14)
        {
            z14 = false;
            z2.SetActive(true);
        }
        else
        {
            z1.SetActive(true);
        }
    }

    public void Z35()
    {
        Z31();
        z4.SetActive(true);
        z1.SetActive(false);
    }

    public void Z36()
    {
        Z31();
        z3.SetActive(true);
        z1.SetActive(false);
    }

    public void Z37()
    {
        Z31();
        z15 = true;
        z3.SetActive(true);
        z7.SetActive(false);
    }

    public void Z38()
    {
        Z31();
        z3.SetActive(false);
        if (z15)
        {
            z15 = false;
            z7.SetActive(true);
        }
        else
        {
            z1.SetActive(true);
        }
    }

    public void Z39()
    {
        Z31();
        z6.SetActive(true);
        z1.SetActive(false);
    }

    public void Z40()
    {
        Z31();
        z6.SetActive(true);
        z8.SetActive(false);
    }

    public void Z41()
    {
        Z31();
        z5.SetActive(true);
        z1.SetActive(false);
    }

    public void Z42()
    {
        Z31();
        z5.SetActive(false);
        z1.SetActive(true);
    }

    public void Z43()
    {
        Z31();
        Application.Quit();
    }

    public void Z44()
    {
        Z31();
        z1.SetActive(true);
        z6.SetActive(false);
    }

    public void Z45(int num)
    {
        Z31();
        z11.text = "Remember the order";
        z12.SetActive(true);
        z13.SetActive(false);
        z6.SetActive(false);
        z7.SetActive(true);
        for (int i = 0; i < z9.Length; i++)
        {
            if (i == num)
            {
                z9[i].SetActive(true);
                if (num == 0)
                {
                    z10.text = "EASY";
                    z16.Z61();
                }
                if (num == 1)
                {
                    z10.text = "MEDIUM";
                    z16.Z62();
                }
                if (num == 2)
                {
                    z10.text = "HARD";
                    z16.Z63();
                }
            }
            else
            {
                z9[i].SetActive(false);
            }
        }
    }

    public void Z46()
    {
        Z31();
        z29 = false;
        z6.SetActive(true);
        z7.SetActive(false);
    }

    public void Z47()
    {
        Z31();
        z29 = false;
        z7.SetActive(false);
        z8.SetActive(true);
        if (z16.Z66())
        {
            z17.text = "WIN!";
            if (z16.Z60() == 0)
            {
                z18.text = "EASY Level\npassed";
            }
            if (z16.Z60() == 1)
            {
                z18.text = "MEDIUM Level\npassed";
            }
            if (z16.Z60() == 2)
            {
                z18.text = "HARD Level\npassed";
            }
            z19.text = "Next Level";
        }
        else
        {
            z17.text = "LOSE!";
            z18.text = "Wrong Order";
            z19.text = "Next";
        }
    }

    public void Z48()
    {
        if (z25 == 1)
        {
            z25 = 0;
            z26.Stop();
            z23.color = z20;
        }
        else
        {
            z25 = 1;
            z23.color = z21;
            z26.clip = z27;
            z26.Play();
        }
        PlayerPrefs.SetInt("z25", z25);
        PlayerPrefs.Save();
    }

    public void Z49()
    {
        if (z24 == 1)
        {
            z24 = 0;
            z22.color = z20;
        }
        else
        {
            z24 = 1;
            z22.color = z21;
        }
        PlayerPrefs.SetInt("z24", z24);
        PlayerPrefs.Save();
    }
}