using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearingPlatform : MonoBehaviour
{

    bool flag1 = true;
    bool flag2 = true;
    bool flag3 = true;
    [SerializeField] GameObject platform1;
    [SerializeField] float time1;
    [SerializeField] GameObject platform2;
    [SerializeField] float time2;
    [SerializeField] GameObject platform3;
    [SerializeField] float time3;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Blink1());
        StartCoroutine(Blink2());
        StartCoroutine(Blink3());
    }

    private IEnumerator Blink1()
    {
        while (true)
        {
            platform1.gameObject.SetActive(flag1);
            flag1 = !flag1;
            yield return new WaitForSeconds(time1);
        }
    }

    private IEnumerator Blink2()
    {
        while (true)
        {
            platform2.gameObject.SetActive(flag2);
            flag2 = !flag2;
            yield return new WaitForSeconds(time2);
        }
    }

    private IEnumerator Blink3()
    {
        while (true)
        {
            platform3.gameObject.SetActive(flag3);
            flag3 = !flag3;
            yield return new WaitForSeconds(time3);
        }
    }
}
