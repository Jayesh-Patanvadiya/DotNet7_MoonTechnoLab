using DotNet7_MoonTechnoLab.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DotNet7_MoonTechnoLab.Repository
{
    public class DBContext : DbContext
    {
    //    private const string CONNECTION_STRING = "Host=localhost:5432;" +
    //"Username=postgres;" +
    //"Password=root;" +
    //"Database=postgres";
        protected readonly IConfiguration _configuration;

        public DBContext(IConfiguration configuration)
        {
            _configuration = configuration;

        }

        public DBContext(DbContextOptions<DBContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			var conn = _configuration.GetValue<string>("ConnectionStrings:ApiConnection");

			// connect to postgres with connection string from app settings
			options.UseNpgsql(conn);
        }

        public DbSet<PayReg> PayReg { get; set; }
        public DbSet<OTReg> OTReg { get; set; }

        public DbSet<TimeAttendance> TimeAttendance { get; set; }
		public DbSet<OverTimeCal> OverTimeCal { get; set; }


	}
	public class MyWebApiContextFactory : IDesignTimeDbContextFactory<DBContext>
    {
		protected readonly IConfiguration _configuration;

		public MyWebApiContextFactory(IConfiguration configuration)
		{
			_configuration = configuration;

		}
		//private const string CONNECTION_STRING = "Host=localhost:5432;" +
  //  "Username=postgres;" +
  //  "Password=root;" +
  //  "Database=postgres";
        public DBContext CreateDbContext(string[] args)
		{
			var conn = _configuration.GetValue<string>("ConnectionStrings:ApiConnection");

			var optionsBuilder = new DbContextOptionsBuilder<DBContext>();
            optionsBuilder.UseNpgsql(conn);

            return new DBContext(optionsBuilder.Options);
        }
    }
}
