using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebQSort.Models
{
    public static class Repository
    {
        private static List<QSortResponse> responses = new List<QSortResponse>();

        public static IEnumerable<QSortResponse> Responses
        {
            get
            {
                return responses;
            }
        }

        public static void AddResonses(QSortResponse response)
        {
            responses.Add(response);
        }
    }
}
