using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using static NetCoreBooking.Enums.Enums;


namespace NetCoreBooking.Controllers
{
    public class BaseNotification : Controller
    {
        //public void Alert(string message, NotificationType notificationType)
        //{
        //    var msg = "<script language='javascript'>swal('" + notificationType.ToString().ToUpper() + "', '" + message + "','" + notificationType + "')" + "</script>";
        //    TempData["notification"] = msg;
        //}
        public void Alert(string message, NotificationType notificationType)
        {
            var msg = "" + notificationType.ToString().ToUpper() + "," + message + "," + notificationType + "" + "";
            var msg1 = notificationType.ToString().ToUpper();
            var msg3 = message;
            TempData["notification1"] = msg1;
            TempData["notification3"] = msg3;


            TempData["notification"] = msg;
        }

        /// <summary>
        /// Sets the information for the system notification.
        /// </summary>
        /// <param name="message">The message to display to the user.</param>
        /// <param name="notifyType">The type of notification to display to the user: Success, Error or Warning.</param>
        public void Message(string message, NotificationType notifyType)
        {
            TempData["Notification2"] = message;
            switch (notifyType)
            {
                case NotificationType.success:
                    TempData["NotificationCSS"] = "alert-success" /*"alert-box success"*/;
                    break;
                case NotificationType.error:
                    TempData["NotificationCSS"] = "alert-danger"/*"alert-box errors"*/;
                    break;
                case NotificationType.warning:
                    TempData["NotificationCSS"] = "alert-box warning";
                    break;

                case NotificationType.info:
                    TempData["NotificationCSS"] = "alert-box notice";
                    break;
            }
        }


        public bool TimeOfDayIsBetween(DateTime start, DateTime end)
        {
            if (start < end)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
