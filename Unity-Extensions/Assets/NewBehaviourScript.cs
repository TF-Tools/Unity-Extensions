using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TFTools.Extensions;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] List<GameObject> objs = new ();
    [SerializeField] GameObject [] objs2;
    [SerializeField] float m_F1;

    [Percentage]
    [SerializeField] float m_F;
    [SerializeField] float m_F3;

    [SerializeField] MinMax mm;
    [SerializeField] MinMaxInt mmi;

    // Start is called before the first frame update
    void Start ()
    {

    }

    // Update is called once per frame
    void Update ()
    {

    }
}
