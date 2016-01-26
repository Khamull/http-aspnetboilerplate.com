using Abp.Web.Mvc.Views;

namespace sample.Web.Views
{
    public abstract class sampleWebViewPageBase : sampleWebViewPageBase<dynamic>
    {

    }

    public abstract class sampleWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected sampleWebViewPageBase()
        {
            LocalizationSourceName = sampleConsts.LocalizationSourceName;
        }
    }
}