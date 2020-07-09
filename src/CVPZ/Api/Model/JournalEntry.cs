using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using JournalEntryEntity = CVPZ.Core.Entities.JournalEntry;

namespace CVPZ.Api.Model
{
    public class JournalEntry
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        public List<string> Technologies { get; set; }

        public static JournalEntry FromEntity(JournalEntryEntity entity)
        {
            return new JournalEntry()
            {
                Id = entity.Id,
                Description = entity.Description,
                Technologies = entity.Technologies
            };
        }
    }
}
