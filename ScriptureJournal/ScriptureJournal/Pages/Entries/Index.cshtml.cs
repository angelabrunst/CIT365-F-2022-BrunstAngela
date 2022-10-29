using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ScriptureJournal.Data;
using ScriptureJournal.Models;

namespace ScriptureJournal.Pages.Entries
{
    public class IndexModel : PageModel
    {
        private readonly ScriptureJournal.Data.ScriptureJournalContext _context;

        public IndexModel(ScriptureJournal.Data.ScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<Entry> Entry { get;set; } = default!;
        [BindProperty(SupportsGet = true)]
        public string ? SearchString { get; set; }
        public SelectList ? Book { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ? ScriptureBook { get; set; }

        public SelectList ? DateAdded { get; set; }
        [BindProperty(SupportsGet = true)]
        public DateTime ? EntryDate { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<DateTime> dateQuery = from e in _context.Entry
                                           orderby e.DateAdded
                                           select e.DateAdded;
            IQueryable<string> bookQuery = from e in _context.Entry
                                           orderby e.Book
                                           select e.Book;
            var entries = from e in _context.Entry
                          select e;
            if (!string.IsNullOrEmpty(SearchString))
            {
                entries = entries.Where(s => s.Notes.Contains(SearchString));
            }
            
            if (!string.IsNullOrEmpty(ScriptureBook))
            {
                entries = entries.Where(x => x.Book == ScriptureBook);
            }

            if (DateTime.Equals(EntryDate, DateTime.MinValue))
            {
                entries = entries.Where(d => d.DateAdded == EntryDate);
            }

            DateAdded = new SelectList(await dateQuery.Distinct().ToListAsync());
            Book = new SelectList(await bookQuery.Distinct().ToListAsync());
            Entry = await entries.ToListAsync();
        }
    }
}
