using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using PrimeDealsRealestat.Repository.Extintions;
using Shiping.Services.Extintions;
using Shiping.Services.Mapper;
using System.Security.Claims;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

// Add services to the container.
var key = "your-newly-generated-base64-encoded-key"; // Secret key (should be stored securely)
var keyBytes = Encoding.ASCII.GetBytes(key);
builder.Services.AddHttpContextAccessor();

builder.Services.AddControllers();
InfrastractureExtintions.ConfigureDataBase(builder.Services, "Data Source=SQL8004.site4now.net;Initial Catalog=db_aaba14_shipping;User Id=db_aaba14_shipping_admin;Password=P@ssw0rd");
//InfrastractureExtintions.ConfigureDataBase(builder.Services, "Server=IBRAHIM-ESSAM\\SQLEXPRESS;Database=Shipping;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");
InfrastractureExtintions.ConfigureServises(builder.Services);
ServicesExtintions.ConfigureServises(builder.Services);
builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n 
                      Enter 'Bearer' [space] and then your token in the text input below.
                      \r\n\r\nExample: 'Bearer 12345abcdef'",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
      {
        {
          new OpenApiSecurityScheme
          {
            Reference = new OpenApiReference
              {
                Type = ReferenceType.SecurityScheme,
                Id = "Bearer"
              },
              Scheme = "oauth2",
              Name = "Bearer",
              In = ParameterLocation.Header,

            },
            new List<string>()
          }
        });
    //var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    //var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    //c.IncludeXmlComments(xmlPath);
});
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(keyBytes),
        RoleClaimType = ClaimTypes.Role // Specify that roles are stored in the "role" claim type

    };
});
builder.Services.AddCors(o => o.AddPolicy("DefaultCorsPolicy", builder =>
{
    builder.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader()
           ;
}));
var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();
//app.usehtt();
app.UseRouting();
app.UseCors("DefaultCorsPolicy");



//app.UseHttpsRedirection();

//app.UseAuthentication(); // Add authentication middleware
app.UseAuthorization();
app.UseStaticFiles();
app.MapControllers();

app.Run();
