using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
namespace BLL
{
  public  class PC_info_BLL
    {
      public static List<PC_info> GetData(PC_info pc) {
          return PC_info_DAL.GetData(pc);
      }
      public static int Del(int id) {
          return PC_info_DAL.Del(id);
       }
    }
}
