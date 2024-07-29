using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Z67 : MonoBehaviour
{
    [SerializeField] Sprite[] z51;
    [SerializeField] Image[] z52;
    [SerializeField] Image[] z53;
    [SerializeField] Image[] z54;
    [SerializeField] GameObject z60;
    [SerializeField] GameObject z61;
    [SerializeField] TextMeshProUGUI z62;
    [SerializeField] Z50 z63;
    private List<int> z55 = new List<int>();
    private List<int> z56 = new List<int>();
    private int z57;
    private bool z58;
    private int z59;

    public int Z60()
    {
        return z57;
    }

    public void Z61()
    {
        z63.Z31();
        z57 = 0;
        z55.Clear();
        for (int i = 0; i < z52.Length; i++)
        {
            var z68 = UnityEngine.Random.Range(0, z51.Length);
            z55.Add(z68);
            z52[i].sprite = z51[z68];
        }
    }

    public void Z62()
    {
        z63.Z31();
        z57 = 1;
        z55.Clear();
        for (int i = 0; i < z53.Length; i++)
        {
            var z69 = UnityEngine.Random.Range(0, z51.Length);
            z55.Add(z69);
            z53[i].sprite = z51[z69];
        }
    }

    public void Z63()
    {
        z63.Z31();
        z57 = 2;
        z55.Clear();
        for (int i = 0; i < z54.Length; i++)
        {
            var z70 = UnityEngine.Random.Range(0, z51.Length);
            z55.Add(z70);
            z54[i].sprite = z51[z70];
        }
    }

    public void Z64()
    {
        z63.Z31();
        Z50.z29 = true;
        z62.text = "Repeat the correct order";
        z60.SetActive(false);
        z61.SetActive(true);
        z56 = z55.OrderBy(_ => Guid.NewGuid()).ToList();
        if (z57 == 0)
        {
            for (int i = 0; i < z52.Length; i++)
            {
                z52[i].sprite = z51[z56[i]];
            }
        }

        if (z57 == 1)
        {
            for (int i = 0; i < z53.Length; i++)
            {
                z53[i].sprite = z51[z56[i]];
            }
        }

        if (z57 == 2)
        {
            for (int i = 0; i < z54.Length; i++)
            {
                z54[i].sprite = z51[z56[i]];
            }
        }
    }

    public void Z65(int itemNum)
    {
        if (Z50.z29)
        {
            if (z57 == 0)
            {
                if (z58)
                {
                    z52[itemNum].sprite = z51[z56[z59]];
                    var newCodeItemNum = z56[z59];
                    var newCodeSelectNum = z56[itemNum];
                    z52[z59].sprite = z51[z56[itemNum]];
                    z56[z59] = newCodeSelectNum;
                    z56[itemNum] = newCodeItemNum;
                    z58 = false;
                }
                else
                {
                    z58 = true;
                    z59 = itemNum;
                }
            }

            if (z57 == 1)
            {
                if (z58)
                {
                    z53[itemNum].sprite = z51[z56[z59]];
                    var newCodeItemNum = z56[z59];
                    var newCodeSelectNum = z56[itemNum];
                    z53[z59].sprite = z51[z56[itemNum]];
                    z56[z59] = newCodeSelectNum;
                    z56[itemNum] = newCodeItemNum;
                    z58 = false;
                }
                else
                {
                    z58 = true;
                    z59 = itemNum;
                }
            }

            if (z57 == 2)
            {
                if (z58)
                {
                    z54[itemNum].sprite = z51[z56[z59]];
                    var newCodeItemNum = z56[z59];
                    var newCodeSelectNum = z56[itemNum];
                    z54[z59].sprite = z51[z56[itemNum]];
                    z56[z59] = newCodeSelectNum;
                    z56[itemNum] = newCodeItemNum;
                    z58 = false;
                }
                else
                {
                    z58 = true;
                    z59 = itemNum;
                }
            }
        }
    }

    public bool Z66()
    {
        var str = string.Empty;
        for (int i = 0; i < z55.Count; i++)
        {
            str += z55[i];
        }

        var strNew = string.Empty;
        for (int i = 0; i < z56.Count; i++)
        {
            strNew += z56[i];
        }

        return string.Equals(str, strNew);
    }
}
