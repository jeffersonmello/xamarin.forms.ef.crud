using Microsoft.EntityFrameworkCore;
using SQLiteXF.Model.Data.Financeiro;

namespace SQLiteXF.Data.Context
{
    public class DataContext : DbContext
    {
        #region Private Properties

        /// <summary>
        /// Caminho da Base de dados
        /// </summary>
        private readonly string _databasePath;

        #endregion Private Properties

        #region Public Properties

        /// <summary>
        /// Tabela de Despesas
        /// </summary>
        public DbSet<Despesa> Despesas { get; set; }

        #endregion Public Properties

        #region Constructor

        public DataContext(string databasePath)
        {
            _databasePath = databasePath;

            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        #endregion Constructor

        #region Protected Methods

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={_databasePath}");
        }

        //TYPE CONFIGURATION
        //https://stackoverflow.com/questions/26957519/ef-core-mapping-entitytypeconfiguration

        #endregion Protected Methods
    }
}
