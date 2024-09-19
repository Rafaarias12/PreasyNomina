using API_Nomina.Actions;
using SHARED_Nomina.Response;

namespace API_Nomina.Services
{
    public class TurnosService
    {
        private readonly string conexion;

        public TurnosService(IConfiguration config)
        {
            conexion = config.GetConnectionString("Default");
        }

        public Respuesta TurnoEmpleado()
        {
            Respuesta rpta = new Respuesta();
            PostDapper post = new PostDapper();

            try
            {

            }
            catch (Exception ex) {
            
            }
        }
    }
}
