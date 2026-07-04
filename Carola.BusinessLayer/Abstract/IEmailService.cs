using Carola.DtoLayer.EmailDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carola.BusinessLayer.Abstract
{
    public interface IEmailService
    {
        Task SendBookingApprovalOfferAsync(BookingApprovalEmailDto model);
    }
}
