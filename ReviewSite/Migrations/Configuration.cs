namespace ReviewSite.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ReviewSite.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ReviewSite.Models.ReviewSiteContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ReviewSite.Models.ReviewSiteContext";
        }

        protected override void Seed(ReviewSite.Models.ReviewSiteContext context)
        {
            context.Categories.AddOrUpdate(x => x.CatID,
            new Category() { CatID = 20, CatName = "Interviews", ReviewID = 20 }
            );

            context.Reviews.AddOrUpdate(x => x.ReviewID,
                new Review() { ReviewID = 20, ReviewTitle = "Horizon Zero Dawn: How Do You Eat Robo-Meat?", ReviewContent = "Fusce eget sagittis libero, id sollicitudin leo. Suspendisse laoreet sagittis ex sed malesuada. Phasellus laoreet libero nisl, in sollicitudin risus rutrum nec.", PublishedDate = DateTime.Now }
                );

            
        }
    }
}
