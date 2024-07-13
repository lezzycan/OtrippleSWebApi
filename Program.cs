
namespace OtrippleSWebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder builder =
                 WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
           
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            WebApplication webApplication = 
                builder.Build();

            {
                webApplication.UseSwagger();
                webApplication.UseSwaggerUI();
            }

            webApplication.UseHttpsRedirection();

            webApplication.UseAuthorization();


            webApplication.MapControllers();

            webApplication.Run();
        }
    }
}
