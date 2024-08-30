using car_traders.View.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_traders.Service.Common
{
    internal class AlertService
    {
        public void AlertBox(string message,string types)
        {
            if (Enum.TryParse(types, true, out MessageBoxForm.enumType type))
            {

                MessageBoxForm messageBoxForm = new MessageBoxForm();
                messageBoxForm.showAlert(message, type);
            }
        }
    }
}
