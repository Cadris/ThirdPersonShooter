using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MoveController))]


public class Player : MonoBehaviour
{  
    [System.Serializable]
    public class MouseInput {
        public Vector2 Damping;
        public Vector2 Sensitivity;
    }

    [SerializeField] float speed;
    [SerializeField]MouseInput MouseControl;

    private MoveController m_MoveController;
    public MoveController MoveController{
        get{
            if(m_MoveController == null)
                m_MoveController=GetComponent<MoveController>();
            return m_MoveController;
        }
    }

    InputController playerInput;
    void Awake()
    {
        playerInput=GameManager.Instance.InputController;
        GameManager.Instance.LocalPlayer=this;        
    }
    
    void Update()
    {
        Vector2 direction = new Vector2(playerInput.Vertical*speed, playerInput.Horizontal*speed);
        MoveController.Move(direction);
    }
}
