﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Nomad;
using Nomad.Enums;
using Nomad.Interfaces;

namespace fc3m
{
	public partial class frmMainGame : NomadForm
	{
		private ViewportControl _viewPort;
		private Game _game;
		public frmMainGame(Game game)
		{
			_game = game;
			InitializeComponent();
			_viewPort = new ViewportControl(this, _game);
			this.Controls.Add(_viewPort);
		}




		public override ViewportControl Viewport
		{
			get { return _viewPort; }
		}
	}
}