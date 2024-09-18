using SHARED_Nomina.DTOs;
using SHARED_Nomina.Response;

namespace API_Nomina.Services.Interface
{
    public interface IEmpleadosService
    {
        public Respuesta GetEmpleado();
        public Respuesta PostEmpleado(EmpleadoDTO dto);
    }
}
