﻿using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Templates.ActionControls;
using DevExpress.ExpressApp.Win.Controls;
using DevExpress.ExpressApp.Win.SystemModule;
using DevExpress.ExpressApp.Win.Templates;
using DevExpress.ExpressApp.Win.Templates.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraBars.Helpers;

namespace QLNS1.GUI
{
    public partial class Main_Admin : RibbonForm, IActionControlsSite, IContextMenuHolder, IWindowTemplate, IBarManagerHolder, ISupportViewChanged, ISupportUpdate, IViewSiteTemplate, ISupportStoreSettings, IViewHolder
    {
        private static readonly object viewChanged = new object();
        private static readonly object settingsReloaded = new object();
        private StatusMessagesHelper statusMessagesHelper;

        protected virtual void RaiseViewChanged(DevExpress.ExpressApp.View view)
        {
            EventHandler<TemplateViewChangedEventArgs> handler = (EventHandler<TemplateViewChangedEventArgs>)Events[viewChanged];
            if (handler != null)
            {
                handler(this, new TemplateViewChangedEventArgs(view));
            }
        }
        protected virtual void RaiseSettingsReloaded()
        {
            EventHandler handler = (EventHandler)Events[settingsReloaded];
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }
        protected override FormShowMode ShowMode
        {
            get { return FormShowMode.AfterInitialization; }
        }
        public Main_Admin()
        {
               InitializeComponent();
               ribbonControl.Manager.ForceLinkCreate();
               DevExpress.UserSkins.BonusSkins.Register();
               DevExpress.Skins.SkinManager.EnableFormSkins();
               DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(skinRibbon, true, true);
          }

        #region IActionControlsSite Members
        IEnumerable<IActionControlContainer> IActionControlsSite.ActionContainers
        {
            get { return ribbonControl.ActionContainers; }
        }
        IEnumerable<IActionControl> IActionControlsSite.ActionControls
        {
            get { return ribbonControl.ActionControls; }
        }
        IActionControlContainer IActionControlsSite.DefaultContainer
        {
            get { return barActionContainerView; }
        }
        #endregion

        #region IFrameTemplate Members
        void IFrameTemplate.SetView(DevExpress.ExpressApp.View view)
        {
            viewSiteManager.SetView(view);
            RaiseViewChanged(view);
        }
        ICollection<IActionContainer> IFrameTemplate.GetContainers()
        {
            return new IActionContainer[] { };
        }
        IActionContainer IFrameTemplate.DefaultContainer
        {
            get { return null; }
        }
        #endregion

        #region IWindowTemplate Members
        void IWindowTemplate.SetCaption(string caption)
        {
            Text = caption;
        }
        void IWindowTemplate.SetStatus(ICollection<string> statusMessages)
        {
            statusMessagesHelper.SetMessages(statusMessages);
        }
        bool IWindowTemplate.IsSizeable
        {
            get { return FormBorderStyle == FormBorderStyle.Sizable; }
            set { FormBorderStyle = (value ? FormBorderStyle.Sizable : FormBorderStyle.FixedDialog); }
        }
        #endregion

        #region IBarManagerHolder Members
        BarManager IBarManagerHolder.BarManager
        {
            get { return ribbonControl.Manager; }
        }
        event EventHandler IBarManagerHolder.BarManagerChanged
        {
            add { }
            remove { }
        }
        #endregion

        #region IContextMenuHolder
        PopupMenu IContextMenuHolder.ContextMenu
        {
            get { return contextMenu; }
        }
        #endregion

        #region ISupportViewChanged Members
        event EventHandler<TemplateViewChangedEventArgs> ISupportViewChanged.ViewChanged
        {
            add { Events.AddHandler(viewChanged, value); }
            remove { Events.RemoveHandler(viewChanged, value); }
        }
        #endregion

        #region ISupportUpdate Members
        void ISupportUpdate.BeginUpdate()
        {
            if (ribbonControl.Manager != null)
            {
                ribbonControl.Manager.BeginUpdate();
            }
        }
        void ISupportUpdate.EndUpdate()
        {
            if (ribbonControl.Manager != null)
            {
                ribbonControl.Manager.EndUpdate();
            }
        }
        #endregion

        #region IViewSiteTemplate Members
        object IViewSiteTemplate.ViewSiteControl
        {
            get { return viewSiteManager.ViewSiteControl; }
        }
        #endregion

        #region ISupportStoreSettings Members
        void ISupportStoreSettings.SetSettings(IModelTemplate settings)
        {
            IModelTemplateWin templateModel = (IModelTemplateWin)settings;
            TemplatesHelper templatesHelper = new TemplatesHelper(templateModel);
            IModelFormState formState;
            if (viewSiteManager.View != null)
            {
                formState = templatesHelper.GetFormStateNode(viewSiteManager.View.Id);
            }
            else
            {
                formState = templatesHelper.GetFormStateNode();
            }
            formStateModelSynchronizer.Model = formState;
            templatesHelper.SetRibbonSettings(ribbonControl);
        }
        void ISupportStoreSettings.ReloadSettings()
        {
            modelSynchronizationManager.ApplyModel();
            RaiseSettingsReloaded();
        }
        void ISupportStoreSettings.SaveSettings()
        {
            SuspendLayout();
            try
            {
                modelSynchronizationManager.SynchronizeModel();
            }
            finally
            {
                ResumeLayout();
            }
        }
        event EventHandler ISupportStoreSettings.SettingsReloaded
        {
            add { Events.AddHandler(settingsReloaded, value); }
            remove { Events.RemoveHandler(settingsReloaded, value); }
        }
        #endregion

        #region IViewHolder Members
        DevExpress.ExpressApp.View IViewHolder.View
        {
            get { return viewSiteManager.View; }
        }
        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!viewSitePanel.Controls.Contains(LUONG_ADMIN.Instance))
            {
                viewSitePanel.Controls.Add(LUONG_ADMIN.Instance);
                LUONG_ADMIN.Instance.Dock = DockStyle.Fill;
                LUONG_ADMIN.Instance.BringToFront();
            }
            else
            {
                LUONG_ADMIN.Instance.BringToFront();
                LUONG_ADMIN.Instance.Dock = DockStyle.Fill;

            }

        }
        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            DanhMuc_AD dm_admin = new DanhMuc_AD();
            if (!viewSitePanel.Controls.Contains(dm_admin))
            {
                viewSitePanel.Controls.Add(dm_admin);
                dm_admin.Dock = DockStyle.Fill;
                dm_admin.BringToFront();
            }
            else
            {
                dm_admin.BringToFront();
            }
        }
        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            viewSitePanel.Controls.Clear();
            viewSitePanel.Controls.Add(UserQLNV_Admin.Instance);
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            viewSitePanel.Controls.Clear();
            viewSitePanel.Controls.Add(Thong_Ke.Instance);
        }
        #endregion

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();
            this.Close();
            FormDangNhap frm = new FormDangNhap();
            frm.ShowDialog();
        }

          private void viewSitePanel_Paint(object sender, PaintEventArgs e)
          {

          }
     }
}
