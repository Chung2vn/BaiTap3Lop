using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class StoneBUS
    {
        public DataTable GetStone()
        {
            try
            {
                StoneDAO stoneDAO = new StoneDAO();
                return stoneDAO.Read();
            }
            catch
            {
                throw;
            }
        }
        public DataTable GetStone(Int16 ID)
        {
            try
            {
                StoneDAO stoneDAO = new StoneDAO();
                return stoneDAO.Read(ID);
            }
            catch
            {
                throw;
            }
        }   
    }
}
