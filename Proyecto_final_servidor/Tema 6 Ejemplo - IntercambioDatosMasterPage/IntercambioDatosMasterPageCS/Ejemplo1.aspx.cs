﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Ejemplo1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
          
    }

    protected void btnPoner_Click(object sender, EventArgs e)
    {
        lblIdentificadorUsuario.Text = txtUsuario.Text;
        lblNombreUsuario.Text = txtNombre.Text;
    }

    protected void btnCoger_Click(object sender, EventArgs e)
    {
        lblUsuario.Text = lblIdentificadorUsuario.Text;
        lblNombre.Text = lblNombreUsuario.Text;
        
    }

}