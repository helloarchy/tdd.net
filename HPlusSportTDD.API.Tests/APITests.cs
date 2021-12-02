using System.Linq;
using HPlusSportTDD.API.Controllers;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace HPlusSportTDD.API.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldReturnAllArticles()
        {
            var articlesController = new ArticlesController();

            var result = articlesController.GetAll();

            Assert.AreEqual(3, result.Count());
        }
        
        [Test]
        public void ShouldReturnSingleArticle()
        {
            var articlesController = new ArticlesController();

            var result = articlesController.GetSingle(3);
            
            Assert.IsInstanceOf(typeof(OkObjectResult), result);
        }
        
        [Test]
        public void ShouldReturn404OnMissingArticle()
        {
            var articlesController = new ArticlesController();

            var result = articlesController.GetSingle(42);
            
            Assert.AreEqual((result as StatusCodeResult)?.StatusCode, 404 );
            Assert.IsInstanceOf(typeof(NotFoundResult), result);
        }
    }
}