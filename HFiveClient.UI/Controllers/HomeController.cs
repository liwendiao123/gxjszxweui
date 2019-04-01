using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HFiveClient.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 服务区监控
        /// </summary>
        /// <returns></returns>
        public ActionResult Surveillance()
        {
            return View();
        }

        /// <summary>
        /// 垃圾费用管理
        /// </summary>
        /// <returns></returns>
        public ActionResult GarbageCharges()
        {
            return View();
        }
        /// <summary>     
        /// 巡检管理
        /// </summary>
        /// <returns></returns>
        public ActionResult PatrolManagement()
        {
            return View();
        }

        /// <summary>
        /// 公共场所巡查
        /// </summary>
        /// <returns></returns>
        public ActionResult PatrolPublicPlaces()
        {
            return View();
        }

        /// <summary>
        /// 保安巡查
        /// </summary>
        /// <returns></returns>
        public ActionResult SecurityPatrolPublicPlaces()
        {
            return View();
        }


        /// <summary>
        /// 租金管理
        /// </summary>
        /// <returns></returns>
        public ActionResult RentManagement()
        {
            return View();
        }

        /// <summary>
        /// 消息管理
        /// </summary>
        /// <returns></returns>
        public ActionResult MsgNotice()
        {
            return View();
        }
        /// <summary>
        /// 消息详情
        /// </summary>
        /// <returns></returns>
        public ActionResult MsgDetail()
        {
            return View();
        }



        /// <summary>
        /// 营业概况
        /// </summary>
        /// <returns></returns>
        public ActionResult BusinessOverview()
        {
            return View();
        }

       /// <summary>
       /// 日结数据
       /// </summary>
       /// <returns></returns>
        public ActionResult Dayjunctiondata()
        {
            return View();
        }
        /// <summary>
        /// 交班数据
        /// </summary>
        /// <returns></returns>
        public ActionResult ShiftData()
        {
            return View();
        }

        public ActionResult DailySummary()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}