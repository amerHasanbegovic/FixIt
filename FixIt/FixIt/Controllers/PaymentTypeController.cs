﻿using FixIt.Models.Models.PaymentType;
using FixIt.Services.Interfaces;

namespace FixIt.Controllers
{
    public class PaymentTypeController : BaseController<PaymentTypeViewModel, object, object>
    {
        public PaymentTypeController(IBaseCRUDService<PaymentTypeViewModel, object, object> service) : base(service)
        {
        }
    }
}
