using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using HQTCSDL_Group01.DatabaseManager.DTOs;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQTCSDL_Group01.DatabaseManager
{
    class PartnerDBManager
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["partner"].ConnectionString;

        public IEnumerable<int> GetPartnerIDs()
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "SELECT dt.MA_DT FROM DOI_TAC dt"
                };
                using var reader = command.ExecuteReader();
                while (reader.Read())
                    yield return reader.GetInt32(0);
            }
            finally { };
        }

        public string GetPartnerName(int partnerID)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "SELECT dt.TEN_DT FROM DOI_TAC dt WHERE dt.MA_DT = @partner_id"
                };

                command.Parameters.AddWithValue("@partner_id", partnerID);

                using var reader = command.ExecuteReader();
                if (reader.Read())
                    return reader.GetString(0);
                return String.Empty;
            }
            catch (Exception e)
            {
                return String.Empty;
            }
        }

        public IEnumerable<int> GetBranchIDs(int partnerID)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.StoredProcedure,
                    CommandText = "chi_nhanh_chua_ki_hd"
                };
                command.Parameters.AddWithValue("@ma_dt", partnerID);
                using var reader = command.ExecuteReader();
                while (reader.Read())
                    yield return reader.GetInt32(0);
            }
            finally { };
        }

        public string GetBranchAddress(int branchID)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "SELECT cn.DIA_CHI_CN FROM CHI_NHANH cn WHERE cn.MA_CN = @branch_id"
                };

                command.Parameters.AddWithValue("@branch_id", branchID);

                using var reader = command.ExecuteReader();
                if (reader.Read())
                    return reader.GetString(0);
                return String.Empty;
            }
            catch (Exception e)
            {
                return String.Empty;
            }
        }

     

        public bool ExtendContractError(int contractID, int addDays, TimeSpan delay)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.StoredProcedure,
                    CommandText = "gia_han_hop_dong_ERROR"
                };
                command.Parameters.AddWithValue("@ma_hd", contractID);
                command.Parameters.AddWithValue("@so_ngay_them", addDays);
                command.Parameters.AddWithValue("@delay", delay);
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        public bool ExtendContract(int contractID, int addDays, TimeSpan delay)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.StoredProcedure,
                    CommandText = "gia_han_hop_dong"
                };
                command.Parameters.AddWithValue("@ma_hd", contractID);
                command.Parameters.AddWithValue("@so_ngay_them", addDays);
                command.Parameters.AddWithValue("@delay", delay);
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public IEnumerable<int> GetContractIDs(int partnerID)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "SELECT hd.MA_HD FROM HOP_DONG hd WHERE hd.MA_DT = @partner_id"
                };
                command.Parameters.AddWithValue("@partner_id", partnerID);
                using var reader = command.ExecuteReader();
                while (reader.Read())
                    yield return reader.GetInt32(0);
            }
            finally { }
        }

        public IEnumerable<Contract> GetContracts(int partnerID)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "SELECT hd.MA_HD, hd.MA_THUE_DT, hd.NGUOI_DAI_DIEN_HD, hd.NGAY_BD_HD, hd.NGAY_KT_HD FROM HOP_DONG hd WHERE hd.MA_DT = @partner_id"
                };
                command.Parameters.AddWithValue("@partner_id", partnerID);
                using var reader = command.ExecuteReader();
                while (reader.Read())
                    yield return new Contract(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3), reader.GetDateTime(4));
            }
            finally { }
        }

        public IEnumerable<Branch> GetBranches(int contractID)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "SELECT cn.MA_CN, cn.TEN_CN, cn.DIA_CHI_CN FROM CHI_NHANH cn WHERE cn.MA_HD = @contract_id"
                };
                command.Parameters.AddWithValue("@contract_id", contractID);
                using var reader = command.ExecuteReader();
                while (reader.Read())
                    yield return new Branch(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
            }
            finally { }
        }

        public int GetContractDuration(int contractID)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "SELECT DATEDIFF(DAY, hd.NGAY_BD_HD, hd.NGAY_KT_HD) FROM HOP_DONG hd WHERE hd.MA_HD = @ma_hd"
                };
                command.Parameters.AddWithValue("@ma_hd", contractID);
                return (command.ExecuteScalar() as int?).GetValueOrDefault(-1);
            }
            catch (Exception e)
            {
                return -1;
            }
        }


        public bool AddProduct(Product product, int partnerID)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "INSERT INTO SAN_PHAM(MA_DT, TEN_SP, MO_TA_SP, GIA_SP) VALUES (@ma_dt, @ten_sp, @mo_ta, @gia)"
                };
                command.Parameters.AddWithValue("@ma_dt", partnerID);
                command.Parameters.AddWithValue("@ten_sp", product.Name);
                command.Parameters.AddWithValue("@mo_ta", product.Description);
                command.Parameters.AddWithValue("@gia", product.Price);
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public IEnumerable<int> GetProductIDs(int partnerID)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    //CommandText = "SELECT sp.MA_SP, sp.TEN_SP, sp.MO_TA_SP, sp.GIA_SP FROM SAN_PHAM sp WHERE sp.MA_DT = @partner_id"
                    CommandText = "SELECT sp.MA_SP FROM SAN_PHAM sp WHERE sp.MA_DT = @partner_id"
                };
                command.Parameters.AddWithValue("@partner_id", partnerID);

                using var reader = command.ExecuteReader();
                while (reader.Read())
                    yield return reader.GetInt32(0);
            }
            finally { }
        }

        public Product GetProduct(int productID)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "SELECT TOP 1 sp.MA_SP, sp.TEN_SP, sp.MO_TA_SP, sp.GIA_SP FROM SAN_PHAM sp WHERE sp.MA_SP = @ma_sp"
                };
                command.Parameters.AddWithValue("@ma_sp", productID);

                using var reader = command.ExecuteReader();
                if (reader.Read())
                    return new Product(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3));
                return null;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool DeleteProduct(int productID)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "DELETE FROM SAN_PHAM WHERE MA_SP = @ma_sp"
                };
                command.Parameters.AddWithValue("@ma_sp", productID);
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool UpdateProduct(Product update)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.StoredProcedure,
                    CommandText = "cap_nhat_san_pham"
                };
                command.Parameters.AddWithValue("@ma_sp", update.ID);
                command.Parameters.AddWithValue("@ten_sp", update.Name);
                command.Parameters.AddWithValue("@mo_ta", update.Description);
                command.Parameters.AddWithValue("@gia", update.Price);
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        public int GetProductAmount(int productID, int branchID)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "SELECT cnsp.SO_LUONG_CNSP FROM CHI_NHANH_SP cnsp WHERE cnsp.MA_SP = @ma_sp AND cnsp.MA_CN = @ma_cn"
                };
                command.Parameters.AddWithValue("@ma_sp", productID);
                command.Parameters.AddWithValue("@ma_cn", branchID);

                using var reader = command.ExecuteReader();
                if (reader.Read())
                    return reader.GetInt32(0);
                return 0;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public bool UpdateProductAmountError(int productID, int branchID, int different, TimeSpan delay)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.StoredProcedure,
                    CommandText = "cap_nhat_so_luong_cnsp_ERROR"
                };
                command.Parameters.AddWithValue("@ma_sp", productID);
                command.Parameters.AddWithValue("@ma_cn", branchID);
                command.Parameters.AddWithValue("@chenh_lech", different);
                command.Parameters.AddWithValue("@delay", delay);
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool UpdateProductAmount(int productID, int branchID, int different, TimeSpan delay)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.StoredProcedure,
                    CommandText = "cap_nhat_so_luong_cnsp"
                };
                command.Parameters.AddWithValue("@ma_sp", productID);
                command.Parameters.AddWithValue("@ma_cn", branchID);
                command.Parameters.AddWithValue("@chenh_lech", different);
                command.Parameters.AddWithValue("@delay", delay);
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public IEnumerable<Order> GetOrders(int partnerID)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "SELECT dh.MA_DH, dh.MA_CN, dh.MA_KH, dh.MA_TX, dh.HINH_THUC_TT, dh.DIA_CHI_GH, dh.TINH_TRANG_DH, dh.PHI_SP, dh.PHI_VC FROM DON_HANG dh JOIN CHI_NHANH cn ON dh.MA_CN = cn.MA_CN WHERE cn.MA_DT = @partner_id"
                };
                command.Parameters.AddWithValue("@partner_id", partnerID);
                using var reader = command.ExecuteReader();
                while (reader.Read())
                    yield return new Order(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), (reader[3] as int?).GetValueOrDefault(-1), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetInt32(7), reader.GetInt32(8));
            }
            finally { }
        }

        public IEnumerable<ProductAmount> GetProductAmountFromOrder(int orderID)
        {
            
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "SELECT sp.MA_SP, sp.TEN_SP, dhsp.SO_LUONG_SP_DH, dhsp.GIA_SP_DH FROM DON_HANG_SP dhsp JOIN SAN_PHAM sp ON dhsp.MA_SP = sp.MA_SP WHERE dhsp.MA_DH = @order_id"
                };
                command.Parameters.AddWithValue("@order_id", orderID);
                using var reader = command.ExecuteReader();
                while (reader.Read())
                    yield return new ProductAmount(new Product(reader.GetInt32(0), reader.GetString(1), "", reader.GetInt32(3)), reader.GetInt32(2));
            }
            finally { }
        }

        public PartnerStatistics GetStatistics(int partnerID, TimeSpan delay)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.StoredProcedure,
                    CommandText = "doi_tac_thong_ke"
                };
                command.Parameters.AddWithValue("@ma_dt", partnerID);
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

                    reader.NextResult();
                    reader.Read();
                    var maxAmount = new ProductAmount(new Product(reader.GetInt32(1), reader.GetString(2), "", 0), reader.GetInt32(3));
                    return new PartnerStatistics(total, shipping, done, maxAmount);
                }


                return null;
            }
            catch (Exception e)
            {
                return null;
            }
        }


        public PartnerStatistics GetStatisticsError(int partnerID, TimeSpan delay)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.StoredProcedure,
                    CommandText = "doi_tac_thong_ke_ERROR"
                };
                command.Parameters.AddWithValue("@ma_dt", partnerID);
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

                    reader.NextResult();
                    reader.Read();
                    var maxAmount = new ProductAmount(new Product(reader.GetInt32(1), reader.GetString(2), "", 0), reader.GetInt32(3));
                    return new PartnerStatistics(total, shipping, done, maxAmount);
                }

                return null;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }


}
