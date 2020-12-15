using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DivisionUI
{
    public class Container : MonoBehaviour
    {
        public bool hidden;
        public List<Container> children;
        public UITransform uiTransform;

        void Update()
        {
            if (hidden)
                return;

            foreach (var child in children)
            {
                child.Render();
            }
        }

        protected virtual void Render()
        {
            
        }
    }
}