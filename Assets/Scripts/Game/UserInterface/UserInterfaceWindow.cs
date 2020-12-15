// Project:         Daggerfall Tools For Unity
// Copyright:       Copyright (C) 2009-2020 Daggerfall Workshop
// Web Site:        http://www.dfworkshop.net
// License:         MIT License (http://www.opensource.org/licenses/mit-license.php)
// Source Code:     https://github.com/Interkarma/daggerfall-unity
// Original Author: Gavin Clayton (interkarma@dfworkshop.net)
// Contributors:    
// 
// Notes:
//

using UnityEngine;
using DaggerfallWorkshop.Game.UserInterfaceWindows;
using System;
using UnityEngine.InputSystem;
using System.Collections.Generic;

namespace DaggerfallWorkshop.Game.UserInterface
{
    /*public interface UserInterfaceWindow
    {
        UserInterfaceWindow Value { get; }
        string Name { get; }
        bool Enabled { get; set; }
        bool PauseWhileOpen { get; set; }
        Panel ParentPanel { get; }
        BaseScreenComponent FocusControl { get; }
        void SetFocus(BaseScreenComponent control);
        void Update();
        void Draw();
        void ProcessMessages();
        void OnPush();
        void OnPop();
        void OnReturn();
        void HandleClick();
    }*/

    /// <summary>
    /// UserInterfaceWindow abstract base class.
    /// Each window is a unique state managed by UserInterfaceManager.
    /// All subordinate controls should be added to ParentPanel.
    /// </summary>
    public abstract class UserInterfaceWindow
    {
        protected Panel parentPanel = new Panel();      // Parent panel fits to entire viewport
        protected IUserInterfaceManager uiManager;
        protected bool enabled = true;
        protected bool pauseWhileOpened = true;
        protected BaseScreenComponent focusControl = null;
        protected BaseScreenComponent hoveredComponent;
        public bool Enabled
        {
            get { return enabled; }
            set { enabled = value; }
        }

        public Panel ParentPanel
        {
            get { return parentPanel; }
        }

        public BaseScreenComponent FocusControl
        {
            get { return focusControl; }
        }

        public UserInterfaceWindow()
        {
            this.uiManager = DaggerfallUI.UIManager;
        }

        public UserInterfaceWindow(IUserInterfaceManager uiManager)
        {
            this.uiManager = uiManager;
        }

        public virtual void Update()
        {
            if (enabled)
            {
                parentPanel.Update();
            }
        }

        public virtual void Draw()
        {
            if (enabled)
            {
                parentPanel.Draw();
            }
        }

        public virtual void ProcessMessages()
        {
            if (uiManager != null)
            {
                string message = uiManager.PeekMessage();
                if (message == WindowMessages.wmCloseWindow)
                {
                    uiManager.GetMessage();     // Eat message
                    CloseWindow();
                }
            }
        }

        public void HandleHover()
        {
            Vector2 mousePosition = Mouse.current.position.ReadValue();

            DaggerfallBaseWindow window = (DaggerfallBaseWindow)this;

            foreach (var component in window.NativePanel.Components)
            {
                //Debug.Log(component.Position.ToString());
                //Debug.Log(mousePosition.x - scr);

                if (component.IsHovered(mousePosition))
                {
                    //component.
                    
                        Debug.Log(component.Name);
                    hoveredComponent = component;
                    hoveredComponent.MouseEnter();
                }

                //if (focusControl != component)
                  //  focusControl.MouseLeave();
            }
        }

        public virtual void HandleMouseClick(Vector2 position)
        {
            if (hoveredComponent != null)
                hoveredComponent.MouseClick(position);
        }

        public void HandleMouseMove(Vector2 movement)
        {
            if (focusControl != null)
                focusControl.MouseMove(movement);
        }

        /// <summary>
        /// Called when this window is pushed to stack.
        /// </summary>
        public virtual void OnPush()
        {
        }

        /// <summary>
        /// Called when this window pops off from stack.
        /// </summary>
        public virtual void OnPop()
        {
        }

        /// <summary>
        /// Called when returning to this window after popping back from another window.
        /// </summary>
        public virtual void OnReturn()
        {
        }

        public virtual void OpenWindow()
        {

        }

        public void CloseWindow()
        {
            uiManager.PopWindow();
            RaiseOnCloseHandler();
            DaggerfallGC.ThrottledUnloadUnusedAssets();
        }

        public void PopWindow()
        {
            uiManager.PopWindow();
        }

        public virtual bool PauseWhileOpen
        {
            get { return pauseWhileOpened; }
            set { pauseWhileOpened = value; }
        }

        public virtual void SetFocus(BaseScreenComponent control)
        {
            // Old control losing focus
            if (focusControl != null)
                focusControl.LostFocus();

            // New control gaining focus
            if (control != null)
                control.GotFocus();

            // Cache focus control
            focusControl = control;
        }

        //internal protected virtual void WindowChanged(object sender, EventArgs e)
        //{
        //    if (uiManager.TopWindow == this.Value)
        //    {
        //    }
        //}

        #region Event Handlers

        // OnClose
        public delegate void OnCloseHandler();
        public event OnCloseHandler OnClose;
        protected virtual void RaiseOnCloseHandler()
        {
            if (OnClose != null)
                OnClose();
        }

        #endregion
    }
}
