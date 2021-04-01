using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperScript : MonoBehaviour
{
    [SerializeField]
    public float m_fSpringConst = 10000f;
    [SerializeField]
    public float m_fOriginalPos = 0f;
    [SerializeField]
    public float m_fPressedPos = 45f;
    [SerializeField]
    public float m_fFlipperSpringDamp = 150f;
    [SerializeField]
    public KeyCode m_flipperInput;

    private HingeJoint m_hingeJoint = null;
    private JointSpring m_jointSpring;
    // Start is called before the first frame update
    void Start()
    {
        m_hingeJoint = GetComponent<HingeJoint>();
        m_hingeJoint.useSpring = true;
        m_jointSpring = new JointSpring();
        m_jointSpring.spring = m_fSpringConst;
        m_jointSpring.damper = m_fFlipperSpringDamp;

        m_hingeJoint.spring = m_jointSpring;
    }
    private void OnFlipperPressedInternal()
    {
        m_jointSpring.targetPosition = m_fPressedPos;
        m_hingeJoint.spring = m_jointSpring;
    }

    private void OnFlipperReleasedInternal()
    {
        m_jointSpring.targetPosition = m_fOriginalPos;
        m_hingeJoint.spring = m_jointSpring;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(m_flipperInput))
        {
            OnFlipperPressedInternal();
        }

        if (Input.GetKeyUp(m_flipperInput))
        {
            OnFlipperReleasedInternal();
        }
    }
}
