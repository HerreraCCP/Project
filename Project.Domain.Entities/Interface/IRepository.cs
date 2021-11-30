using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.Domain.Entities
{
    public interface IRepository : IDisposable
    {
        Task<IList<String>> GetAllByEvenString(IList<String> receiveString);

        Task<int[]> GetAllByEvenNumber (int[] arrayNumber);

    }
}
