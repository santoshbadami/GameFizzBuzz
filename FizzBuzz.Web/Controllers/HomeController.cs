#region Namespaces
using FizzBuzz.Web.ApplicationService;
using FizzBuzz.Web.Models;
using FizzBuzz.Web.XPagedList;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
#endregion

namespace FizzBuzz.Web.Controllers
{
    public class HomeController : Controller
    {
        #region Private Variables
        private readonly IFizzBuzzApplicationService _fizzBuzzApplicationService;
        private static List<FizzBuzzModel> listUnpaged;
        #endregion

        #region Constructor

        public HomeController(IFizzBuzzApplicationService fizzBuzzApplicationService)
        {
            _fizzBuzzApplicationService = fizzBuzzApplicationService;
        }

        #endregion


        #region Post methods

        /// <summary>
        /// Post method to process fizzBuzz values
        /// </summary>
        /// <param name="input number"></param>
        /// <param name="page number"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Index(int number, int page = 1)
        {
            listUnpaged = GetValues(number);
            ViewBag.Names = GetPagedNames(page);

            return View();
        }

        /// <summary>
        /// Post method for pagination
        /// </summary>
        /// <param name="page number"></param>
        /// <returns></returns>
        public IActionResult Pagination(int page = 1)
        {
            ViewBag.Names = GetPagedNames(page);

            return View("Index");
        }

        #endregion

        #region Get methods

        /// <summary>
        /// Get action method to render view
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        #endregion

        #region Protected methods
        protected IPagedList<FizzBuzzModel> GetPagedNames(int? page)
        {
            // return a 404 if user browses to before the first page
            if (page.HasValue && page < 1)
                return null;

            // page the list
            const int pageSize = 10;
            var listPaged = listUnpaged.ToPagedList(page ?? 1, pageSize);

            // return a 404 if user browses to pages beyond last page. special case first page if no items exist
            if (listPaged.PageNumber != 1 && page.HasValue && page > listPaged.PageCount)
                return null;

            return listPaged;
        }
        protected List<FizzBuzzModel> GetValues(int number)
        {
            return _fizzBuzzApplicationService.GetNumbers(number);
        }
        #endregion
    }
}
