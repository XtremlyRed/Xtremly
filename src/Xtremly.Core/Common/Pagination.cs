using System;
using System.Collections.Generic;

namespace Xtremly.Core
{
    public struct Pagination<Target>
    {
        public IEnumerable<Target> Data { get; set; }

        public int TotalPage
        {
            get
            {
                if (TotalCount <= 0 || PageSize <= 0)
                {
                    return 1;
                }

                return ((int)Math.Ceiling((double)TotalCount / PageSize)).FromRange(1, int.MaxValue);
            }
        }

        public int TotalCount { get; set; }

        public int CurrentPage { get; set; }

        public int PageSize { get; set; }

        public object Condition { get; set; }


        public Pagination GetPagination()
        {
            return new Pagination()
            {
                TotalCount = TotalCount,
                CurrentPage = CurrentPage,
                PageSize = PageSize,
                Condition = Condition,
            };
        }
    }


    public struct Pagination
    {
        public int TotalPage
        {
            get
            {
                if (TotalCount <= 0 || PageSize <= 0)
                {
                    return 1;
                }

                return ((int)Math.Ceiling((double)TotalCount / PageSize)).FromRange(1, int.MaxValue);
            }
        }

        public int TotalCount { get; set; }

        public int CurrentPage { get; set; }

        public int PageSize { get; set; }

        public object Condition { get; set; }
    }
}
