

namespace ObjectOrientedPractics.Model.Enums
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
