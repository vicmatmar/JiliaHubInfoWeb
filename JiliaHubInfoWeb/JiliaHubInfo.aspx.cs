using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace JiliaHubInfoWeb
{
    public partial class JiliaHubInfo : System.Web.UI.Page
    {
        static SqlConnectionStringBuilder _db_connect_str;
        static DataTable _table_data;

        protected void Page_Load(object sender, EventArgs e)
        {
            _db_connect_str = new SqlConnectionStringBuilder(Properties.Settings.Default.ConnectionString);

            if (!IsPostBack)
            {
                _table_data = new DataTable();
                using (SqlConnection con = new SqlConnection(_db_connect_str.ConnectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from JiliaHubs ORDER BY Timestamp DESC", con);
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                        adp.Fill(_table_data);
                }

                GridViewInfo.DataSource = _table_data;
                GridViewInfo.DataBind();
            }
        }
    }
}