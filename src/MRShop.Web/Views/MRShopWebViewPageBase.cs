using Abp.Web.Mvc.Views;

namespace MRShop.Web.Views
{
    public abstract class MRShopWebViewPageBase : MRShopWebViewPageBase<dynamic>
    {

    }

    public abstract class MRShopWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected MRShopWebViewPageBase()
        {
            LocalizationSourceName = MRShopConsts.LocalizationSourceName;
        }
    }
}