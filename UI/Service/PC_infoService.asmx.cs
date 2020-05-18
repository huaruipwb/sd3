using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using BLL;
using Model;
namespace UI.Service
{
    /// <summary>
    /// PC_infoService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class PC_infoService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public List<PC_info> GetData()
        {
            List<PC_info> list = PC_info_BLL.GetData(new PC_info());
            return list;
        }
        [WebMethod]
        public List<PC_info> GetData2(PC_info pc)
        {
            List<PC_info> list = PC_info_BLL.GetData(pc);
            return list;
        }
        [WebMethod]
        public int Del(int id)
        {
            int count = PC_info_BLL.Del(id);
            return count;
        }
    }
}
