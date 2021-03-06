using System;
using System.Collections;
using System.Configuration;
using System.Data;

using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;


public partial class admin_fatherlist : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bing();
        }
    }
    public void bing()
    { 
        BLL.fathercate myb = new BLL.fathercate();
        DataSet ds = myb.dataset();
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
 
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Edit")
        {
            f_id.Text = e.CommandArgument.ToString();
        }

        if (e.CommandName == "Delete")
        {
            int f_id = Convert.ToInt32(e.CommandArgument);
            BLL.procate myb = new BLL.procate();
            int result = myb.num(f_id);
            if (result > 0)
            {
                msg("先把含有此父类的子类删除，才能删除父类");
            }
            else

            {
                BLL.fathercate f_b = new BLL.fathercate();
                int rs = f_b.delete(f_id);
                if (rs > 0)
                {
                    msg("删除成功");
                    bing();
                }
                else
                {
                    msg("删除失败");
 
                }
            }

 
        }


    }
    public void msg(string msg)
    {
        BLL.tis myb = new BLL.tis();
        myb.msg(Page, msg);
    }
    protected void qued_Click(object sender, EventArgs e)
    {
        
        if (f_id.Text != "未选择")
        {
            if (TextBox1.Text !="")
            {
                Model.fathercate mym = new Model.fathercate();
                mym.fathercateid = Convert.ToInt32(f_id.Text);
                mym.fathername = TextBox1.Text;
                BLL.fathercate myb = new BLL.fathercate();
                int result = myb.update(mym);
                if (result > 0)
                {
                    msg("更改成功！");
                    TextBox1.Text = "";
                    f_id.Text = "未选择";
                    bing();
                }

            }
            else
            {
                msg("类明不能为空");
            }
        }
        else
        {
            msg("未选择");
        }

        

    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
      
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        DataBind();
    }
}
