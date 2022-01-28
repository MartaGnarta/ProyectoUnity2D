using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FSM
{
    public class Controller : MonoBehaviour
    {
        public State currentState; // Apuntador al estado actual
        public State remainState;

        public bool ActivateAI { get; set; }

        private Animator _animatorController;
        private HealthSystem _healthSystem;

        void Start()
        {
            ActivateAI = true; // Para activar la IA
        }

        private void Awake()
        {
            _animatorController = GetComponent<Animator>();
            _healthSystem = GetComponent<HealthSystem>();
        }
        public void Update() // Se ejecutan las acciones del estado actual.
        {
            if (!ActivateAI) // El parámetro permite que los estados tengan una referencia al controlador para poder llamar a sus métodos.
                return;

            currentState.UpdateState(this);
        }

        public void Transition(State nextState)
        {
            if (nextState != remainState)
            {
                currentState = nextState;
            }
        }

        public void SetAnimation(string action, bool a)
        {
            _animatorController.SetBool(action, a);
        }

        public int GetCurrentHealth()
        {
            return _healthSystem.GetHP();            
        }
    }
}
