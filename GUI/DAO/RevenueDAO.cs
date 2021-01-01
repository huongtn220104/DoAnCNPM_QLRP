using System;
using System.Data;
using System.Linq;

namespace GUI.DAO
{
    public class RevenueDAO
    {
        public static DataTable GetRevenue(string idMovie, DateTime fromDate, DateTime toDate)
        {
            return DataProvider.ExecuteQuery("EXEC USP_GetRevenueByMovieAndDate @idMovie , @fromDate , @toDate", new object[] { idMovie, fromDate, toDate });
        }
        public static DataTable GetReportRevenue(string idMovie, DateTime fromDate, DateTime toDate)
        {
            return DataProvider.ExecuteQuery("EXEC USP_GetReportRevenueByMovieAndDate @idMovie , @fromDate , @toDate", new object[] { idMovie, fromDate, toDate });
        }
        public static DataTable GetRevenue1(DateTime fromDate, DateTime toDate)
        {
            return DataProvider.ExecuteQuery("EXEC USP_GetRevenueByDate @fromDate , @toDate", new object[] { fromDate, toDate });
        }
        public static DataTable GetReportRevenue1(DateTime fromDate, DateTime toDate)
        {
            return DataProvider.ExecuteQuery("EXEC USP_GetReportRevenueByDate @fromDate , @toDate", new object[] { fromDate, toDate });
        }
    }
}
