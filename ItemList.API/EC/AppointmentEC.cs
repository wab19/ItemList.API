using ItemList.API.Database;
using Library.CIS4930.Standard.DTO;

namespace ItemList.API.EC
{
    public class AppointmentEC
    {
        public IEnumerable<AppointmentDTO> Get()
        {
            return FakeDatabase.Appointments.Select(t => new AppointmentDTO(t));
        }
    }
}
