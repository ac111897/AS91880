using System.Collections.Generic;

namespace AS91880.Services
{
    public interface IContentService
    {
        public IEnumerable<string> GetContent(string path);
    }
}
