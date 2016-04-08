namespace MVCPagina
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SolutionsContext : DbContext
    {
        public SolutionsContext()
            : base("name=SolutionsContext")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
