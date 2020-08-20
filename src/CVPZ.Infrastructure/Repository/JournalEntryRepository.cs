using CVPZ.Core.Entities;
using CVPZ.Core.Repository;
using CVPZ.Infrastructure.Data;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVPZ.Infrastructure.Repository
{
    public class JournalEntryRepository : IRepository<JournalEntry>
    {

        // Start Dummy Data

        private static readonly string[] Technologies = new[]
        {
            "C#", "SQL", "JavaScript", "TypeScript", "Java", "C++", "HTML", "CSS", "Jekyll", "GO"
        };

        private static readonly string[] Descriptions = new[]
        {
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam bibendum nulla urna, sit amet suscipit nisi laoreet in. Curabitur convallis tellus purus, sed rhoncus leo maximus vitae. Donec cursus est convallis posuere tincidunt. Morbi ornare libero ullamcorper pulvinar ullamcorper. Donec rutrum nibh sodales nisl mattis ultrices. Fusce molestie urna ante, nec varius mauris sollicitudin sit amet. Donec suscipit, mi sed ultricies malesuada, nibh quam lacinia diam, ultricies pharetra diam leo eget nisi. Integer sollicitudin ultricies aliquam. Donec et lorem sed nulla suscipit iaculis.",
            "Curabitur velit mi, egestas at libero a, iaculis faucibus ligula. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Vestibulum suscipit fermentum ornare.Duis et tellus mauris.Quisque cursus dictum luctus. Mauris in augue nec ipsum semper efficitur.Suspendisse sollicitudin sagittis massa, accumsan semper justo congue nec.Quisque eu dui vitae odio blandit cursus.Nulla vel ex sollicitudin magna porta molestie non at leo. Mauris blandit velit in aliquet dictum. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.Nam turpis quam, ultrices quis dictum sit amet, accumsan sit amet mauris. In a sem nec ante imperdiet scelerisque ac eu urna.",
            "Vestibulum eget nulla ac nibh sagittis consectetur vehicula ac diam. Praesent sed molestie nibh, venenatis laoreet sapien.Aliquam arcu neque, tristique nec mauris a, blandit scelerisque erat.Nullam in vestibulum dolor. Ut vehicula magna nec tempor porta. Quisque in justo in augue ultricies vehicula eu vitae diam. Curabitur tempus elementum tortor id semper. Donec libero velit, sagittis a rutrum bibendum, hendrerit et magna.Praesent laoreet eros ornare odio viverra, sed egestas arcu viverra. Nunc tincidunt ante a ligula luctus, at scelerisque arcu malesuada. Nulla libero augue, elementum sed faucibus eget, eleifend ornare mauris.Vivamus ac magna dolor. Sed venenatis quam massa, nec dignissim dolor fermentum vitae.Vestibulum elementum mattis tincidunt.",
            "Praesent nunc ipsum, congue quis nibh vitae, sollicitudin sodales diam.Suspendisse augue turpis, condimentum nec rhoncus vel, condimentum ac nisl.Cras malesuada eleifend augue vitae luctus. Donec fermentum at nisl vel condimentum. Mauris in iaculis arcu, quis imperdiet tortor.Proin efficitur lacinia dolor quis porttitor. In vestibulum rutrum eleifend. Curabitur quis massa arcu. Pellentesque sed ipsum consectetur, suscipit justo a, dignissim ipsum. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.",
            "Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.Vivamus ut tortor eget sem varius sollicitudin.Sed interdum turpis at tellus consequat finibus.Curabitur sed ipsum justo. Phasellus sem nisi, tempor ut risus ac, commodo dictum libero.Nulla facilisi. Nulla magna sapien, aliquet id tellus vitae, laoreet luctus sapien.Ut aliquet consequat cursus. Quisque tincidunt sed arcu et cursus.",
            "Etiam vel ante mi. Duis maximus tellus vitae ipsum commodo consequat.Donec quam lorem, consequat sed porta eget, lacinia vitae neque.Nunc congue semper lacus, et scelerisque mi ultricies nec.Sed mollis sit amet libero sed commodo.Integer non posuere ante. Fusce sit amet urna non odio auctor tincidunt. Mauris tincidunt eros eu malesuada pretium.",
            "Nulla facilisi. Duis nec auctor leo. Sed pharetra dolor et nibh consectetur finibus.Phasellus rhoncus dui nec massa congue, volutpat tincidunt tellus euismod. Nullam gravida orci et luctus porttitor. Sed dapibus sem ac ex commodo lobortis.Nulla sit amet condimentum magna.Nunc sodales lorem non mollis feugiat. Vivamus ac dui ac turpis vestibulum tincidunt.Integer a nisl imperdiet, facilisis leo et, dignissim ligula. Pellentesque auctor et velit ut bibendum.",
            "Nunc malesuada malesuada convallis. Fusce eros nisi, porta nec ante at, ultricies euismod eros.Maecenas sagittis sollicitudin dui et mollis. Nullam id velit est. Mauris quis eleifend dui. Aliquam ut egestas lorem. Ut a justo lorem. Integer euismod ex mollis, iaculis dui sit amet, commodo mi. Nulla elit mauris, efficitur sit amet hendrerit a, iaculis at nisi.",
            "Morbi ornare condimentum sapien, eu aliquet massa molestie ut.Nullam vel urna dictum, sollicitudin dolor ac, ullamcorper justo. Praesent eros ante, gravida sed suscipit in, rhoncus a magna.Vivamus viverra sed leo vitae commodo. Vestibulum vehicula venenatis velit, a viverra lorem gravida id.In hac habitasse platea dictumst.Suspendisse rhoncus ullamcorper suscipit. Pellentesque commodo pretium finibus. Vestibulum convallis vel erat ac elementum. Mauris purus lorem, porta vel blandit scelerisque, mattis ut libero.Aenean eget magna lectus. Vestibulum metus turpis, porttitor vestibulum metus non, condimentum volutpat dolor.Integer varius at elit vitae gravida. Nunc dignissim vel enim in efficitur.",
            "Fusce id ipsum rutrum, sagittis ante vitae, efficitur enim. In gravida aliquam feugiat. Proin egestas dui leo, vitae venenatis odio egestas eget.Vestibulum fermentum rhoncus metus sit amet porta.Duis volutpat nisl sed molestie accumsan. Quisque maximus maximus viverra. Aliquam malesuada ligula ex, quis venenatis odio lacinia sed."
        };

        // End Dummy Data


        private readonly CVPZContext _context;

        public JournalEntryRepository(CVPZContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }

        public async Task<JournalEntry> AddAsync(JournalEntry entity)
        {
            var rng = new Random();
            var taskResult = Task.Run(() => {
                entity.Id = rng.Next(3000, 3999);
                return entity;
            });
            return await taskResult;
        }

        public async Task DeleteAsync(JournalEntry entity)
        {
            throw new NotImplementedException();
        }

        public async Task<JournalEntry> GetByIdAsync(int id)
        {
            var rng = new Random();
            var taskResult = Task.Run(() => {
                return new JournalEntry {
                    Id = id,
                    Description = Descriptions[rng.Next(Descriptions.Length)]
                };
            });
            return await taskResult;
        }

        public async Task<IEnumerable<JournalEntry>> ListAsync()
        {
            var rng = new Random();
            var taskResult = Task.Run(() => {
                return Enumerable.Range(1, 5)
                    .Select(index => new JournalEntry
                    {
                        Description = Descriptions[rng.Next(Descriptions.Length)]
                    });
            });
            return await taskResult;
        }

        public async Task UpdateAsync(JournalEntry entity)
        {
            throw new NotImplementedException();
        }
    }
}
