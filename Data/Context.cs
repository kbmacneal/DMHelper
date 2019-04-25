using DM_helper.Models;
using Microsoft.EntityFrameworkCore;

namespace DM_helper
{
    public partial class Context : DbContext
    {
        public Context ()
        { }

        public Context (DbContextOptions<Context> options) : base (options)
        { }
    }

}