using Carola.DtoLayer.ReservationDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carola.BusinessLayer.Abstract
{
    public interface IReservationService
    {
        Task DeleteReservationAsync(int id);
        Task<int> CreateReservationAsync(CreateReservationDto createReservationDto);
        Task UpdateReservationAsync(UpdateReservationDto updateReservationDto);
        Task<List<ResultReservationDto>> GetAllReservationAsync();
        Task<GetReservationByIdDto> GetReservationByIdAsync(int id);
    }
}
