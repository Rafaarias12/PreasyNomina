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

        //public Respuesta TurnoEmpleado()
        //{
        //    Respuesta rpta = new Respuesta();
        //    PostDapper post = new PostDapper();

        //    try
        //    {

        //    }
        //    catch (Exception ex) {
            
        //    }
        //}

        public Respuesta ListTurnos()
        {
            string sql = "select * from turno";
            GetDapper get = new GetDapper();
            Respuesta rpta = new Respuesta();
            rpta = get.GetConsulta(conexion, sql);
            return rpta;
        }

        
    }
}
