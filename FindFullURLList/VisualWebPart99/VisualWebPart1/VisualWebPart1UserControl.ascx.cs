﻿using System;
using System.Web.UI;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Utilities;

namespace VisualWebPart99.VisualWebPart1
{
    public partial class VisualWebPart1UserControl : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void ExecuteButton_OnClick(object sender, EventArgs e)
        {
            try
             {
                using (SPSite site = new SPSite("http://wss2k13/sites/deploy/"))
                {
                    using (SPWeb web = site.OpenWeb())
                    {
                        SPList list = web.Lists[FilterBox.Text];
                        string listURL = SPUtility.GetFullUrl(site, list.DefaultDisplayFormUrl);
                        ResultLabel.Text = listURL.ToString();
                        ResultLabel.Visible = true;
                        ResultLabel.ForeColor = System.Drawing.Color.BlueViolet;
                    }
                }
             }
            catch (Exception Error)
            {
                ResultLabel.Text = DateTime.Now.ToString() + "Список не существует или указан с ошибкой" + Error.Message;
                ResultLabel.Visible = true;
                ResultLabel.ForeColor = System.Drawing.Color.Red;
            }
            System.Threading.Thread.Sleep(5000);
        }
        protected void RedirectButton_OnClick(object sender, EventArgs e)
        {
            using (SPSite site = new SPSite("http://wss2k13/sites/deploy/"))
            {
                using (SPWeb web = site.OpenWeb())
                {
                    SPList list = web.Lists[FilterBox.Text];
                    string listURL = SPUtility.GetFullUrl(site, list.DefaultDisplayFormUrl);
                    string queryString = "author";
                    SPUtility.Redirect(listURL, SPRedirectFlags.Default, Context, queryString);
                }
            }
        }
    }
}
