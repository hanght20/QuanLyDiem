using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyDiem.DAL
{
    public class DBLib
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        private SqlConnection cnn;
        private SqlCommand cmd;
        public DBLib()
        {
            string strCnn = "Server= DESKTOP-MN74J8A;Database=QUANLYDIEM;Integrated security=true;User ID=sa;Password=123";
            cnn = new SqlConnection(strCnn);
            cmd = new SqlCommand();
            cmd.Connection = cnn;
        }
        public void Open()
        {
            if (cnn.State != System.Data.ConnectionState.Open)
            {
                cnn.Open();
            }
        }
        public void Close()
        {
            if (cnn.State != System.Data.ConnectionState.Closed)
            {
                cnn.Close();
            }
        }
        public bool ExecuteNonQuery(string cmdText, CommandType cmdType)
        {
            int count = 0;
            try
            {
                this.Open();
                cmd.CommandText = cmdText;
                cmd.CommandType = cmdType;
                count = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return count > 0;
        }
        public void AddParameter(string name, object value)
        {
            SqlParameter para = new SqlParameter();
            para.ParameterName = name;
            para.Value = value;
            cmd.Parameters.Add(para);
        }
        public void AddParameter(string name, object value, ParameterDirection direction)
        {
            SqlParameter para = new SqlParameter();
            para.ParameterName = name;
            para.Value = value;
            para.Direction = direction;
            cmd.Parameters.Add(para);
        }
        //Phương thức lấy giá trị của tham số đầu ra
        public int GetParameter(string parameterName)
        {
            return (int)cmd.Parameters[parameterName].Value;
        }
        
        public DataTable FillDataTable(string cmdText, CommandType cmdType)
        {
            DataTable table = null;
            try
            {
                this.Open();
                cmd.CommandText = cmdText;
                cmd.CommandType = cmdType;
                table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return table;
        }
        public DataTable FillDataTable(string cmdText, CommandType cmdType, string[] arrPara, object[] arrValue, SqlDbType[] arrDbType)
        {
            DataTable table = null;
            try
            {
                this.Open();
                cmd.CommandText = cmdText;
                cmd.CommandType = cmdType;
                SqlParameter para = null;
                for (int i = 0; i < arrPara.Length; i++)
                {
                    para = new SqlParameter();
                    para.ParameterName = arrPara[i];
                    para.Value = arrValue[i];
                    para.SqlDbType = arrDbType[i];
                    cmd.Parameters.Add(para);
                }
                table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return table;
        }
        
    }
}
