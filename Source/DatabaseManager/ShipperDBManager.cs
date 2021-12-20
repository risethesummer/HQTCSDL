using HQTCSDL_Group01.DatabaseManager.DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace HQTCSDL_Group01.DatabaseManager
{
    public class ShipperDBManager
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["shipper"].ConnectionString;
        public bool AcceptOrderError(int orderID, int shipperID, TimeSpan delay)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.StoredProcedure,
                    CommandText = "tiep_nhan_dh_ERROR"
                };
                command.Parameters.AddWithValue("@ma_dh", orderID);
                command.Parameters.AddWithValue("@ma_tx", shipperID);
                command.Parameters.AddWithValue("@delay", delay);
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool AcceptOrder(int orderID, int shipperID, TimeSpan delay)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.StoredProcedure,
                    CommandText = "tiep_nhan_dh"
                };
                command.Parameters.AddWithValue("@ma_dh", orderID);
                command.Parameters.AddWithValue("@ma_tx", shipperID);
                command.Parameters.AddWithValue("@delay", delay);
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public Statistics GetStatistics(int shipperID, TimeSpan delay)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.StoredProcedure,
                    CommandText = "tai_xe_thong_ke"
                };
                command.Parameters.AddWithValue("@ma_tx", shipperID);
                command.Parameters.AddWithValue("@delay", delay);
                using var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    var total = new TotalStatistics(reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3));
                    var shipping = new TotalStatistics(0, 0, 0);
                    var done = new TotalStatistics(0, 0, 0);
                    reader.NextResult();
                    reader.Read();
                    if (!reader.IsDBNull(2))
                        shipping = new TotalStatistics(reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3));
                    reader.NextResult();
                    reader.Read();
                    if (!reader.IsDBNull(2))
                        done = new TotalStatistics(reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3));
                    return new Statistics(total, shipping, done);
                }

                return null;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Statistics GetStatisticsError(int shipperID, TimeSpan delay)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.StoredProcedure,
                    CommandText = "tai_xe_thong_ke_ERROR"
                };
                command.Parameters.AddWithValue("@ma_tx", shipperID);
                command.Parameters.AddWithValue("@delay", delay);
                using var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    var total = new TotalStatistics(reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3));
                    var shipping = new TotalStatistics(0, 0, 0);
                    var done = new TotalStatistics(0, 0, 0);
                    reader.NextResult();
                    reader.Read();
                    if (!reader.IsDBNull(2))
                        shipping = new TotalStatistics(reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3));
                    reader.NextResult();
                    reader.Read();
                    if (!reader.IsDBNull(2))
                        done = new TotalStatistics(reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3));
                    return new Statistics(total, shipping, done);
                }
                return null;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool UpdateOrder(int orderID)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "UPDATE DON_HANG SET TINH_TRANG_DH = N'Thành công' WHERE MA_DH = @order_id"
                };
                command.Parameters.AddWithValue("@order_id", orderID);
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public IEnumerable<Order> GetAvailableOrders()
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "SELECT dh.MA_DH, dh.MA_CN, dh.MA_KH, dh.MA_TX, dh.HINH_THUC_TT, dh.DIA_CHI_GH, dh.TINH_TRANG_DH, dh.PHI_SP, dh.PHI_VC FROM DON_HANG dh WHERE dh.MA_TX IS NULL AND dh.TINH_TRANG_DH = N'Đang xử lý'"
                };
                using var reader = command.ExecuteReader();
                while (reader.Read())
                    yield return new Order(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), (reader[3] as int?).GetValueOrDefault(-1), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetInt32(7), reader.GetInt32(8));
            }
            finally { }
        }

        public IEnumerable<Order> GetShippingOrders(int shipperID)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "SELECT dh.MA_DH, dh.MA_CN, dh.MA_KH, dh.MA_TX, dh.HINH_THUC_TT, dh.DIA_CHI_GH, dh.TINH_TRANG_DH, dh.PHI_SP, dh.PHI_VC FROM DON_HANG dh WHERE dh.MA_TX = @shipper_id AND dh.TINH_TRANG_DH = N'Đang giao'"
                };
                command.Parameters.AddWithValue("@shipper_id", shipperID);
                using var reader = command.ExecuteReader();
                while (reader.Read())
                    yield return new Order(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), (reader[3] as int?).GetValueOrDefault(-1), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetInt32(7), reader.GetInt32(8));
            }
            finally { }
        }
    }
}
