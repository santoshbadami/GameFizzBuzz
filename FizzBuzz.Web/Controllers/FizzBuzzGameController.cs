#region Namespaces
using FizzBuzz.Web.ApplicationService;
using FizzBuzz.Web.Models;
using FizzBuzz.Web.XPagedList;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
#endregion

namespace FizzBuzz.Web.Controllers
{
    public class FizzBuzzGameController : Controller
    {
        #region Private Variables
        private readonly IFizzBuzzApplicationService _fizzBuzzApplicationService;
        private static List<FizzBuzzModel> fizzBuzzList;
        #endregion

        #region Constructor

        public FizzBuzzGameController(IFizzBuzzApplicationService fizzBuzzApplicationService)
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
        public IActionResult FizzBuzzPlay(int number, int page = 1)
        {
            fizzBuzzList = GetValues(number);
            IPagedList<FizzBuzzModel> numberList = GetPagedNames(page);
            TempData["number"] = number;
            return View(numberList);
        }

        /// <summary>
        /// Post method for pagination
        /// </summary>
        /// <param name="page number"></param>
        /// <returns></returns>
        public IActionResult Pagination(int page = 1)
        {
            IPagedList<FizzBuzzModel> numberList = GetPagedNames(page);
            return View("FizzBuzzPlay", numberList);
        }

        #endregion

        #region Get methods

        /// <summary>
        /// Get action method to render view
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult FizzBuzzPlay()
        {
            return View();
        }
        #endregion

        #region Protected methods
        protected IPagedList<FizzBuzzModel> GetPagedNames(int? page)
        {
            // return a 404 if user browses to before the first page
            if (page.HasValue && page < 1)
            {
                return null;
            }

            // page the list
            const int pageSize = 20;
            IPagedList<FizzBuzzModel> listPaged = fizzBuzzList.ToPagedList(page ?? 1, pageSize);

            // return a 404 if user browses to pages beyond last page. special case first page if no items exist
            return listPaged.PageNumber != 1 && page.HasValue && page > listPaged.PageCount ? null : listPaged;
        }
        protected List<FizzBuzzModel> GetValues(int number)
        {
            return _fizzBuzzApplicationService.GetNumbers(number);
        }
        #endregion
    }
}