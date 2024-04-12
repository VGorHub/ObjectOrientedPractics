using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public enum OrderStatus
    {
        New,         // Новый заказ
        Processing,  // Обрабатывается
        Assembly,    // Собирается на складе
        Sent,        // Отправлен
        Delivered,   // Доставлен
        Returned,    // Возврат
        Abandoned    // Отменен (со стороны магазина)
    }

}
