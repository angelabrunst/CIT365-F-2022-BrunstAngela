using Microsoft.EntityFrameworkCore;
using ScriptureJournal.Data;

namespace ScriptureJournal.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ScriptureJournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ScriptureJournalContext>>()))
            {
                if (context == null || context.Entry == null)
                {
                    throw new ArgumentNullException("Null ScriptureJournalContext");
                }

                // Look for any entries
                if (context.Entry.Any())
                {
                    return;
                }
                context.Entry.AddRange(
                    new Entry
                    {
                        DateAdded = DateTime.Parse("2022-10-24"),
                        Book = "1 Nephi",
                        Chapter = 3,
                        Verse = 7,
                        Notes = "And it came to pass that I, Nephi, said unto my father: I awill go and do the things which the Lord hath commanded, for I know that the Lord giveth no bcommandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."
                    },

                    new Entry
                    {
                        DateAdded = DateTime.Parse("2022-10-24"),
                        Book = "Mosiah",
                        Chapter = 2,
                        Verse = 17,
                        Notes = "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God."
                    },

                    new Entry
                    {
                        DateAdded = DateTime.Parse("2022-10-24"),
                        Book = "Hebrews",
                        Chapter = 12,
                        Verse = 9,
                        Notes = "Furthermore we have had fathers of our flesh which corrected us, and we gave them reverence: shall we not much rather be in subjection unto the Father of spirits, and live?"
                    },

                    new Entry
                    {
                        DateAdded = DateTime.Parse("2022-10-24"),
                        Book = "Isaiah",
                        Chapter = 5,
                        Verse = 20,
                        Notes = "Woe unto them that call evil good, and good evil; that put darkness for light, and light for darkness; that put bitter for sweet, and sweet for bitter!"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
