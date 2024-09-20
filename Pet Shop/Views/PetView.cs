﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Shop.Views
{
	public partial class PetView : Form, IPetView
	{
		private string message;
		private bool isSuccessful;
		private bool isEdit;

		public PetView()
		{
			InitializeComponent();
			AssociateAndRaiseViewEvents();
			//txtSearch.TextChanged += new EventHandler();
			//tabControl1.TabPages.Remove(tabPagePetDetail);
		}

		private void AssociateAndRaiseViewEvents()
		{
			txtSearch.TextChanged += (s, e) =>
			{
				SearchEvent?.Invoke(this, EventArgs.Empty);
			};
			btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
			txtSearch.KeyDown += (s, e) =>
			{
				if (e.KeyCode == Keys.Enter)
				{
					SearchEvent?.Invoke(this, EventArgs.Empty);
				}
			};
			petview_btnClose.Click += delegate { this.Close(); };
		}

		public string PetId
		{
			get { return txtPetId.Text; }
			set { txtPetId.Text = value; }
		}

		public string PetName
		{
			get { return txtPetName.Text; }
			set { txtPetName.Text = value; }
		}

		public string PetType
		{
			get { return txtPetType.Text; }
			set { txtPetType.Text = value; }
		}

		public string PetColour
		{
			get { return txtPetColour.Text; }
			set { txtPetColour.Text = value; }
		}

		public string SearchValue
		{
			get { return txtSearch.Text; }
			set { txtSearch.Text = value; }
		}

		public bool IsEdit
		{
			get { return isEdit; }
			set { isEdit = value; }
		}

		public bool IsSuccessful
		{
			get { return isSuccessful; }
			set { isSuccessful = value; }
		}


		public string Message
		{
			get { return message; }
			set { message = value; }
		}

		//public bool IsSuccessfull { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		int IPetView.PetId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public event EventHandler SearchEvent;
		public event EventHandler AddNewEvent;
		public event EventHandler EditEvent;
		public event EventHandler DelelteEvent;
		public event EventHandler SaveEvent;
		public event EventHandler CancelEvent;

		public void SetPetListBingdingSource(BindingSource petList)
		{
			//throw new NotImplementedException();
			dataGridView1.DataSource = petList;
		}

		//singleton pattern (open a single form instace)
		private static PetView instance;	
		public static PetView GetInstance(Form parentContainer)
		{
			if (instance == null || instance.IsDisposed)
			{
				instance = new PetView();
				instance.MdiParent = parentContainer;
				instance.FormBorderStyle = FormBorderStyle.None;
				instance.Dock = DockStyle.Fill;
			}
			else
			{
				if (instance.WindowState == FormWindowState.Minimized)
				{
					instance.WindowState = FormWindowState.Normal;
				}
				instance.BringToFront();
			}
			return instance;
		}

	}
}
