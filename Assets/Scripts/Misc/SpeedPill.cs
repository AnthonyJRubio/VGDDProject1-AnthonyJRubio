using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPill : MonoBehaviour
{
    #region Editor Variables
    [SerializeField]
    [Tooltip("The amount of speed that this pill boosts")]
    private float m_SpeedGain;
    public float SpeedGain
    {
        get
        {
            return m_SpeedGain;
        }
    }
    #endregion
}

