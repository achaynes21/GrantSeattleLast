using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryERP.Core;
using InvertoryERP.Core.Domain;

namespace InventoryERP.Service.Services.Services
{
    public interface INewsPortalService
    {
        News GetNewsById(string id);
        void Save(News entity);
        void Delete(News entity);
        IList<News> GetNewsList();
        //IPagedList<ItemListShortViewModel> GetItemList(GeneralCriteriaModel model);

        void Edit(News oldModelObj);

        IList<News> GetRecentNews();

        IList<News> GetSidebarNews();

        IList<News> GetNewsListFront(int page, int PAGE_SIZE);

        double RowCount();
    }
}
