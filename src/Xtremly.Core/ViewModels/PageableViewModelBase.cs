﻿using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Xtremly.Core
{

    /// <summary>
    ///  create new instance of the <see cref="PageableViewModelBase"/>
    /// </summary>
    public abstract class PageableViewModelBase : ViewModelBase
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string oldSearchCondition = string.Empty;

        /// <summary>
        /// total page
        /// </summary>
        public virtual int TotalPage
        {
            get => GetValue(1);
            set => SetValue(value);
        }

        /// <summary>
        /// current page
        /// </summary>
        public virtual int CurrentPage
        {
            get => GetValue(1);
            set => SetValue(value);
        }

        /// <summary>
        /// the index of the jump page
        /// </summary>
        public virtual int TargetPage
        {
            get => GetValue(1);
            set => SetValue(value);
        }

        /// <summary>
        /// the count of per page
        /// </summary>
        public virtual int PageSize
        {
            get => GetValue(10);
            set => SetValue(value);
        }
        /// <summary> 
        /// SearchKeyword
        /// </summary>
        public virtual string SearchKeyword
        {
            get => GetValue(string.Empty);
            set => SetValue(value);
        }

        /// <summary>
        /// IsSearching
        /// </summary>
        public virtual bool IsSearching
        {
            get => GetValue(false);
            set => SetValue(value);
        }
        /// <summary>
        /// SearchCommand
        /// </summary>
        public virtual RelayCommandAsync SearchCommand => RelayCommand.Bind(async () =>
        {
            try
            {
                if (IsSearching)
                {
                    return;
                }

                IsSearching = true;
                string search = SearchKeyword ??= string.Empty;
                if (oldSearchCondition != search)
                {
                    CurrentPage = 1;
                }

                Pagination oagination = await Search(search, CurrentPage, PageSize);

                TotalPage = oagination.TotalPage;

                oldSearchCondition = search ?? string.Empty;
            }
            finally
            {
                IsSearching = false;
            }
        });

        /// <summary>
        /// GotoCommand
        /// </summary>
        public virtual RelayCommandAsync GotoCommand => RelayCommand.Bind(async () =>
        {

            if (TargetPage > TotalPage || CurrentPage == TargetPage)
            {
                return;
            }

            if (TargetPage < 1 || CurrentPage == 1)
            {
                return;
            }

            CurrentPage = TargetPage;

            await Search(SearchKeyword, CurrentPage, PageSize);


        });


        /// <summary>
        /// FirstPageCommand
        /// </summary>
        public virtual RelayCommandAsync FirstPageCommand => RelayCommand.Bind(async () =>
        {

            CurrentPage = 1;
            await SearchCommand?.ExecuteAsync();

        });

        /// <summary>
        /// PreviousPageCommand
        /// </summary>
        public virtual RelayCommandAsync PreviousPageCommand => RelayCommand.Bind(async () =>
        {
            if (CurrentPage == 1)
            {
                return;
            }

            CurrentPage -= 1;
            await SearchCommand?.ExecuteAsync();

        });

        /// <summary>
        /// LastPageCommand
        /// </summary>
        public virtual RelayCommandAsync LastPageCommand => RelayCommand.Bind(async () =>
        {
            CurrentPage = TotalPage;
            await SearchCommand?.ExecuteAsync();
        });

        /// <summary>
        /// NextPageCommand
        /// </summary>
        public virtual RelayCommandAsync NextPageCommand => RelayCommand.Bind(async () =>
        {
            if (CurrentPage == TotalPage)
            {
                return;
            }

            CurrentPage += 1;
            await SearchCommand?.ExecuteAsync();
        });






        /// <summary>
        ///     <para>keyword:keyword of search</para>
        ///     <para>currentPage:the number of page</para>
        ///     <para>pageSize:max count in a page</para>
        ///     <para>returns:the number of total count</para>
        /// </summary>
        /// <param name="keyword">keyword of search</param>
        /// <param name="currentPage">the number of page</param>
        /// <param name="pageSize">the count in a page</param>
        /// <returns>total count</returns>
        protected abstract Task<Pagination> Search(string keyword, int currentPage, int pageSize);

    }
}