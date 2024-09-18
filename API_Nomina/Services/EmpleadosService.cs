using API_Nomina.Actions;
using API_Nomina.Services.Interface;
using SHARED_Nomina.DTOs;
using SHARED_Nomina.Response;

namespace API_Nomina.Services
{
    public class EmpleadosService : IEmpleadosService
    {
        private readonly string conexion;
        public EmpleadosService(IConfiguration config)
        {
            conexion = config.GetConnectionString("Default");
        }

        public Respuesta GetEmpleado()
        {
            Respuesta rpta = new Respuesta();
            GetDapper get = new GetDapper();

            try
            {
                string procedimiento = "spListEmpleados";
                rpta = get.GetProcedure(procedimiento, conexion);
            }
            catch (Exception ex)
            {
                rpta.Mensaje = ex.Message;
            }
            return rpta;
        }

        public Respuesta PostEmpleado(EmpleadoDTO dto)
        {
            Respuesta rpta = new Respuesta();
            PostDapper post = new PostDapper(); 
            try
            {
                string procedimiento = "spPostEmpleado";
                string[] parametros = {
                    "documento", "tipo_doc", "nombre", "apellido", "titulo", "salario_basico", "salario_hora", "area"
                };
                object[] objValores = new object[] {
                    dto.documento, dto.tipo_doc, dto.nombre, dto.apellido, dto.titulo, dto.salario_basico, dto.salario_hora, dto.area
                };
                rpta = post.ProcedimientoInsertar(conexion, parametros, objValores, procedimiento);
            }
            catch (Exception ex)
            {
                rpta.Mensaje = ex.Message;
            }
            return rpta;
        }
    }
}
