using Hospital.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Newtonsoft.Json;
using System.Data;

namespace Hospital.Repository
{
    public class DoctorRepository: BaseRepository<Doctor> 
    {
        public override void AddData(Doctor record)
        {
            try
            {
                var connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;MultipleActiveResultSets=True";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                var query = $"INSERT INTO Doctor (Id, CreatedDate, UpdatedDate, Field,Name)VALUES('{record.Id}', GETDATE(), GETDATE(), '{record.Field}', '{record.Name}'); ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Inserting Data Successfully");
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Occre while creating table:" + e.Message + "\t" + e.GetType());
            }
            
        }

        public List<Doctor> GetDoctor()
        {
            var xyz = new List<Doctor>();
            try
            {
               
                var connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;MultipleActiveResultSets=True";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                var query = "Select * from Doctor;"; 
                SqlCommand cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var r = Serialize(reader);
                        string json = JsonConvert.SerializeObject(r, Formatting.Indented);
                        //var jsonString=this.sqlDatoToJson(reader);
                        var abc = JsonConvert.DeserializeObject<Doctor>(json);
                        
                        xyz.Add(abc);
                        Console.WriteLine(reader["Id"].ToString());
                        Console.WriteLine(reader["CreatedDate"].ToString());
                        Console.WriteLine(reader["UpdatedDate"].ToString());
                        Console.WriteLine(reader["Field"].ToString());
                        Console.WriteLine(reader["Name"].ToString());
                    }
                }
                
                conn.Close();
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Occre while creating table:" + e.Message + "\t" + e.GetType());
            }
            return xyz;
        }
        private String sqlDatoToJson(SqlDataReader dataReader)
        {
            var dataTable = new DataTable();
            dataTable.Load(dataReader);
            string JSONString = string.Empty;
            JSONString = JsonConvert.SerializeObject(dataTable);
            return JSONString;
        }

        public IEnumerable<Dictionary<string, object>> Serialize(SqlDataReader reader)
        {
            var results = new List<Dictionary<string, object>>();
            var cols = new List<string>();
            for (var i = 0; i < reader.FieldCount; i++)
                cols.Add(reader.GetName(i));

            while (reader.Read())
                results.Add(SerializeRow(cols, reader));

            return results;
        }
        private Dictionary<string, object> SerializeRow(IEnumerable<string> cols,
                                                        SqlDataReader reader)
        {
            var result = new Dictionary<string, object>();
            foreach (var col in cols)
                result.Add(col, reader[col]);
            return result;
        }
    }
}
