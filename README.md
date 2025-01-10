     protected void AttendanceRecords_RowDataBound(object sender, GridViewRowEventArgs e)
        {

            if (string.Equals(e.Row.RowType.ToString(), "DATAROW", StringComparison.CurrentCultureIgnoreCase))
            {
                DataRow oRow = ((DataRowView)e.Row.DataItem).Row;

                System.Web.UI.Control oSlNo = e.Row.FindControl("SlNo");
                System.Web.UI.Control oDate = e.Row.FindControl("Dates");
                System.Web.UI.Control oPresent = e.Row.FindControl("Present");
                System.Web.UI.Control oLocation = e.Row.FindControl("LocationCode");
                System.Web.UI.Control oDayDef = e.Row.FindControl("DayDef");
                System.Web.UI.Control oSiteID = e.Row.FindControl("SiteID");
              
                ((Label)oSlNo).Text = ((e.Row.DataItemIndex) + 1).ToString();

                if (Convert.ToDateTime(oRow["Dates"].ToString()) > DateTime.Now)
                    ((CheckBox)oPresent).Enabled = false;

                Dictionary<string, object> ddlParams = new Dictionary<string, object>();
                ddlParams.Add("Location", oRow["LocationCode"].ToString());

                GetDropdowns("SiteByLocation", ddlParams);
                ((DropDownList)e.Row.FindControl("SiteID")).DataBind();
                ((DropDownList)e.Row.FindControl("SiteID")).SelectedValue = ((BusinessLayer.App_AttendanceRegisterNextDataset.App_AttendanceDetailsRow)oRow).SiteID.ToString();
                ScriptManager.GetCurrent(this).RegisterAsyncPostBackControl(((DropDownList)oLocation));
                ScriptManager.GetCurrent(this).RegisterAsyncPostBackControl(((DropDownList)oSiteID));
                if (oRow["TotPresent"].ToString() == "9")
                {
                    ((CheckBox)oPresent).Enabled = false;
                    ((DropDownList)oDayDef).SelectedIndex = 1;
                }



            }
