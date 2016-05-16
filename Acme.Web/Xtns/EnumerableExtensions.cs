using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Acme.Web.Xtns
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<TDest> Project<TDest, TFrom>(this IEnumerable<TFrom> list)
        {
            IList<TDest> converted = new List<TDest>();
            foreach (TFrom obj in list)
            {
                converted.Add(Mapper.Map<TDest>(obj));
            }
            return converted;
        }
    }
}