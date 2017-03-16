using Abp.Web.Mvc.Views;

namespace FoxReadingSystem.Web.Views
{
    public abstract class FoxReadingSystemWebViewPageBase : FoxReadingSystemWebViewPageBase<dynamic>
    {

    }

    public abstract class FoxReadingSystemWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected FoxReadingSystemWebViewPageBase()
        {
            LocalizationSourceName = FoxReadingSystemConsts.LocalizationSourceName;
        }
    }
}