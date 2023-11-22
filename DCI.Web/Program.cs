using DCI.Domain.Repositories.Base;
using DCI.Domain.Repositories.Master.City;
using DCI.Domain.Repositories.Master.Configuration;
using DCI.Domain.Repositories.Master.Country;
using DCI.Domain.Repositories.Master.Module;
using DCI.Domain.Repositories.Master.Region;
using DCI.Domain.Repositories.Master.Role;
using DCI.Domain.Repositories.Master.Screen;
using DCI.Domain.Repositories.Master.State;
using DCI.Domain.Repositories.Master.Station;
using DCI.Domain.Repositories.Master.SubModule;
using DCI.Domain.Repositories.Master.TypeDetail;
using DCI.Domain.Repositories.Master.TypeMaster;
using DCI.Domain.Repositories.TravelRequest;
using DCI.Persistence;
using DCI.Persistence.Repositories.BaseRepository;
using DCI.Persistence.Repositories.Master.City;
using DCI.Persistence.Repositories.Master.Configuration;
using DCI.Persistence.Repositories.Master.Country;
using DCI.Persistence.Repositories.Master.Module;
using DCI.Persistence.Repositories.Master.Region;
using DCI.Persistence.Repositories.Master.Role;
using DCI.Persistence.Repositories.Master.Screen;
using DCI.Persistence.Repositories.Master.State;
using DCI.Persistence.Repositories.Master.Station;
using DCI.Persistence.Repositories.Master.SubModule;
using DCI.Persistence.Repositories.Master.TypeDetail;
using DCI.Persistence.Repositories.Master.TypeMaster;
using DCI.Persistence.Repositories.TravelRequest;
using DCI.Services.Abstractions.Master.City;
using DCI.Services.Abstractions.Master.Configuration;
using DCI.Services.Abstractions.Master.Country;
using DCI.Services.Abstractions.Master.Module;
using DCI.Services.Abstractions.Master.Region;
using DCI.Services.Abstractions.Master.Role;
using DCI.Services.Abstractions.Master.Screen;
using DCI.Services.Abstractions.Master.State;
using DCI.Services.Abstractions.Master.Station;
using DCI.Services.Abstractions.Master.SubModule;
using DCI.Services.Abstractions.Master.TypeDetail;
using DCI.Services.Abstractions.Master.TypeMaster;
using DCI.Services.Abstractions.TravelRequest;
using DCI.Services.Master.City;
using DCI.Services.Master.Configuration;
using DCI.Services.Master.Country;
using DCI.Services.Master.Module;
using DCI.Services.Master.Region;
using DCI.Services.Master.Role;
using DCI.Services.Master.Screen;
using DCI.Services.Master.State;
using DCI.Services.Master.Station;
using DCI.Services.Master.SubModule;
using DCI.Services.Master.TypeDetail;
using DCI.Services.Master.TypeMaster;
using DCI.Services.TravelRequest;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebHostBuilder host = new();

ConfigurationManager configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddSingleton<RepositoryDbContext>();

// Adding Authentication
//builder.Services.AddAuthentication(options =>
//{
//    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
//    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
//    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
//}).
//AddJwtBearer(options =>
//{
//    options.SaveToken = true;
//    options.RequireHttpsMetadata = false;
//    options.TokenValidationParameters = new TokenValidationParameters()
//    {
//        ValidateIssuer = true,
//        ValidateAudience = true,
//        ValidAudience = configuration["JWT:ValidAudience"],
//        ValidIssuer = configuration["JWT:ValidIssuer"],
//        ClockSkew = TimeSpan.Zero,
//        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]))
//    };
//});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    _ = builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

//builder.Services.AddApiVersioning(x =>
//{
//    x.DefaultApiVersion = new ApiVersion(1, 0);
//    x.AssumeDefaultVersionWhenUnspecified = true;
//    x.ReportApiVersions = true;
//});

#region Service Injected
// Register Repository
builder.Services.AddScoped(typeof(IGenericRepository), typeof(GenericRepository));

builder.Services.AddScoped(typeof(ITypeDetailRepository), typeof(TypeDetailRepository));
builder.Services.AddScoped(typeof(ITypeMasterRepository), typeof(TypeMasterRepository));
builder.Services.AddScoped(typeof(ICountryRepository), typeof(CountryRepository));
builder.Services.AddScoped(typeof(IStateRepository), typeof(StateRepository));
builder.Services.AddScoped(typeof(IStationRepository), typeof(StationRepository));
builder.Services.AddScoped(typeof(ICityRepository), typeof(CityRepository));
builder.Services.AddScoped(typeof(IRegionRepository), typeof(RegionRepository));
builder.Services.AddScoped(typeof(IRoleRepository), typeof(RoleRepository));
builder.Services.AddScoped(typeof(ISubModuleRepository), typeof(SubModuleRepository));
builder.Services.AddScoped(typeof(IModuleRepository), typeof(ModuleRepository));
builder.Services.AddScoped(typeof(IScreenRepository), typeof(ScreenRepository));
builder.Services.AddScoped(typeof(IConfigurationRepository), typeof(ConfigurationRepository));
builder.Services.AddScoped(typeof(ITravelRequestRepository), typeof(TravelRequestRepository));


builder.Services.AddScoped(typeof(ITypeDetailService), typeof(TypeDetailService));
builder.Services.AddScoped(typeof(ITypeMasterService), typeof(TypeMasterService));
builder.Services.AddScoped(typeof(ICountryService), typeof(CountryService));
builder.Services.AddScoped(typeof(IStateService), typeof(StateService));
builder.Services.AddScoped(typeof(IStationService), typeof(StationService));
builder.Services.AddScoped(typeof(ICityService), typeof(CityService));
builder.Services.AddScoped(typeof(IRegionService), typeof(RegionService));
builder.Services.AddScoped(typeof(IRoleService), typeof(RoleService));
builder.Services.AddScoped(typeof(ISubModuleService), typeof(SubModuleService));
builder.Services.AddScoped(typeof(IModuleService), typeof(ModuleService));
builder.Services.AddScoped(typeof(IScreenService), typeof(ScreenService));
builder.Services.AddScoped(typeof(IConfigurationService), typeof(ConfigurationService));
builder.Services.AddScoped(typeof(ITravelRequestService), typeof(TravelRequestService));



#endregion


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen(
//  c =>
//  {
//      string xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}Proj.xml";
//      string xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
//      c.IncludeXmlComments(xmlPath);

//      c.SwaggerDoc("v1", new OpenApiInfo { Title = "TheCodeBuzz-Service", Version = "v1" });
//      c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
//      {
//          In = ParameterLocation.Header,
//          Description = "Please enter token",
//          Name = "Authorization",
//          Type = SecuritySchemeType.Http,
//          BearerFormat = "JWT",
//          Scheme = "bearer"
//      });
//      c.AddSecurityRequirement(new OpenApiSecurityRequirement
//    {
//        {
//            new OpenApiSecurityScheme
//            {
//                Reference = new OpenApiReference
//                {
//                    Type=ReferenceType.SecurityScheme,
//                    Id="Bearer"
//                },
//                Scheme = "oauth2",
//                Name = "Bearer",
//                In = ParameterLocation.Header,
//            },
//            new string[]{}
//        }
//    });
//  });


WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    _ = app.UseSwagger();
    _ = app.UseSwaggerUI();
}
app.UseCors("corsapp");

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
};
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

//app.UseForwardedHeaders(new ForwardedHeadersOptions
//{
//    ForwardedHeaders = ForwardedHeaders.XForwardedFor |
//    ForwardedHeaders.XForwardedProto
//});

app.Run();
