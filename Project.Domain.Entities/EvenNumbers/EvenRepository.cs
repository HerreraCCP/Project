using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Linq;

namespace Project.Domain.Entities
{
    public class EvenRepository : IRepository
    {
        List<string> _Ilogger = new List<string> { "Message: sommething happen, " };

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public virtual async Task<int[]> GetAllByEvenNumber(int[] arrayNumber)
        {

            int[] _return = new int[] {};

            try
            {
                if(arrayNumber.Length > 0) return arrayNumber.Where(c => c % 2 == 0).Select(c => c).ToArray();
                return _return;
            }
            catch
            {
                return _return;
            }

        }

        public virtual async Task<IList<string>> GetAllByEvenString(IList<string> receiveString)
        {
            try
            {
                if (receiveString.Count == 0) Console.WriteLine(_Ilogger);
                var result = OnlyNumber(receiveString);
                var onlyEvenNumber = (from i in result
                                      where i % 2 == 0
                                      select i).ToArray();

                return onlyEvenNumber.Select(c => Convert.ToString(c.ToString())).ToList();
            }
            catch
            {
                return _Ilogger;
            }
        }



        private IEnumerable<int> OnlyNumber(IList<string> _value)
        {
            var number = new List<int>();
            int value;

            foreach (var item in _value)
            {
                if (int.TryParse(item, out value))
                {
                    number.Add(Convert.ToInt32(value));
                }
            }
            return number;
        }


    }
}