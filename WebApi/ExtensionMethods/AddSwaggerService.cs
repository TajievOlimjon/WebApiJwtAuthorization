using Microsoft.OpenApi.Models;

namespace WebApi.ExtensionMethods
{
    public static class AddSwaggerService
    {
        public static void AddSwaggerServices(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Sample web API",
                    Version = "v1",
                    Description = "Sampme API Services.",
                    Contact = new OpenApiContact
                    {
                        Name = "Tajiev Olimjon."
                    },
                });
                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "JWT Authorization header using the Bearer scheme."
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                          {
                              {
                                  new OpenApiSecurityScheme
                                  {
                                      Reference = new OpenApiReference
                                      {
                                          Type = ReferenceType.SecurityScheme,
                                          Id = "Bearer"
                                      }
                                  },
                                  new string[] {}
                              }
                          }
                );
            });
        }
    }
}
