﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationJenkinsGit
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Response is coming from the code files,new CR on 9APR");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Response is coming from the code Action, new CR on 9APR");
        }
    }
}