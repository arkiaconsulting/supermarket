using supermarket.app;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Xunit;

namespace supermarket.acceptance
{
    [Binding]
    public class BrowsingProductsSteps
    {
        [Given(@"The following users exist:")]
        public void GivenTheFollowingUsersExist(Table table)
        {
            ScenarioContext.Current.Set(table.CreateSet<Account>());
        }

        [Given(@"I'm authenticated as (.*)")]
        public void GivenIMAuthenticatedAsLouis(string userName)
        {
            var account = ScenarioContext.Current.Get<IEnumerable<Account>>().Single(a => a.UserName == userName);
            ScenarioContext.Current.Set(account.Preferred ? new PreferredPricePolicy() as IPricePolicy : new NotPreferredPricePolicy());
        }

        [Given(@"The following products exist:")]
        public void GivenTheFollowingProductsExist(Table table)
        {
            var products = table.CreateSet<Product>();

            ScenarioContext.Current.Set<IProductsRepository>(new InMemoryProductRepository(products));
        }

        [When(@"I choose the (.*) category")]
        public void WhenIChooseTheCategory(string categoryName)
        {
            var pricePolicy = ScenarioContext.Current.Get<IPricePolicy>();
            ScenarioContext.Current.Set(new Queries(
                ScenarioContext.Current.Get<IProductsRepository>()).ProductsByCategory(categoryName, pricePolicy));
        }

        [Then(@"I can see a list of all the products")]
        public void ThenICanSeeAListOfAllTheProducts(Table table)
        {
            var expected = table.CreateSet<Product>();

            Assert.Equal(expected, ScenarioContext.Current.Get<IEnumerable<Product>>());
        }
    }
}
