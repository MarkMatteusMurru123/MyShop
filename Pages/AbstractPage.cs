using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Data.Abstractions;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Pages
{
    public abstract class AbstractPage<TData> : PageModel where TData : UniqueItemData
    {
        private readonly DbContext context;
        private readonly DbSet<TData> set;
        protected AbstractPage(DbContext c, DbSet<TData> s)
        {
            context = c;
            set = s;
        }

        public IList<TData> Items { get; set; }

       
        public async Task OnGetIndexAsync() => Items = await set.ToListAsync(); //teeb kätte antud dbsetist listi
        public string Caption { get; protected set; }

        
    }
}
