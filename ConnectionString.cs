namespace WebApplicationNew_ADONET
{
    public class ConnectionString
    {
        private static string cName = "Data Source=LAPTOP-BLNTEBH7\\SQLEXPRESS; Initial Catalog=StudentManagementNew;Trusted_Connection=True;TrustServerCertificate=true";
        public static string CName
        {
            get => cName;
        }
    }
}
