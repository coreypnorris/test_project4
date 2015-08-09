using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicComics.Domain
{
    public interface ITitleDataSource
    {
        IQueryable<Title> Titles { get; }
    }
}
