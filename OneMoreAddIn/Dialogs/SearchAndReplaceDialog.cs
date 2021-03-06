﻿//************************************************************************************************
// Copyright © 2018 Steven M Cohn.  All rights reserved.
//************************************************************************************************

namespace River.OneMoreAddIn
{
	using System;
	using System.Windows.Forms;


	internal partial class SearchAndReplaceDialog : Form
	{
		public SearchAndReplaceDialog ()
		{
			InitializeComponent();
		}


		public bool MatchCase => matchBox.Checked;

		public string WithText => withBox.Text;

		public string WhatText => whatBox.Text;


		private void SearchAndReplaceDialog_Shown (object sender, EventArgs e)
		{
			UIHelper.SetForegroundWindow(this);
			whatBox.Focus();
		}

		private void WTextChanged (object sender, EventArgs e)
		{
			okButton.Enabled = 
				whatBox.Text.Length > 0 && 
				withBox.Text.Length > 0;
		}
	}
}


