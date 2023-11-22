using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string basePath = Directory.GetCurrentDirectory().Replace("GenerateApiStructure\\bin\\Debug\\net7.0", "");
        string projectName = "DCI";
        string structureFor, mainModuleChoice, mainModuleName = string.Empty;
        structureFor = ReadDataFromConsole("Enter the API Name for Generating the Structure:");
        mainModuleChoice = ReadDataFromConsole("Does this Module has Main Module.Please Choose(Y/N)");

        if (mainModuleChoice == "Y" || mainModuleChoice == "y")
        {
            mainModuleName = ReadDataFromConsole("Enter the Main Module Name:");
        }

        string moduleName = structureFor != null ? structureFor : "New";
        Console.Clear();
        GenerateResponse(GenerateModel(projectName, basePath, moduleName, mainModuleName), "Generating Model");
        GenerateResponse(GenerateController(projectName, basePath, moduleName, mainModuleName), "Generating Controller");
        GenerateResponse(GenerateService(projectName, basePath, moduleName, mainModuleName), "Generating Service");
        GenerateResponse(GenerateRepository(projectName, basePath, moduleName, mainModuleName), "Generating Repository");
    }

    private static string ReadDataFromConsole(string msg)
    {
        Console.WriteLine(msg);
        return Console.ReadLine();
    }

    private static bool GenerateModel(string project, string basePath, string moduleName, string mainModuleName)
    {
        try
        {
            string path = Path.Combine(basePath, project + @".Domain\Entities\");
            GenerateModulesFolders(path, mainModuleName, moduleName);
            string fileName = Path.Combine(path, mainModuleName, moduleName, moduleName + "Entity.cs");
            string content = GenerateInsertUpdateModelTemplate(moduleName, mainModuleName);
            WriteToFile(fileName, content);

            fileName = Path.Combine(path, mainModuleName, moduleName, moduleName + "ReadOnlyEntity.cs");
            content = GenerateReadModelTemplate(moduleName, mainModuleName);
            WriteToFile(fileName, content);
        }
        catch (Exception)
        {
            return false;
        }
        return true;
    }

    private static void WriteToFile(string fileName, string content)
    {
        Console.Clear();
        Console.WriteLine(content);
        Console.ReadLine();
        File.WriteAllText(fileName, content);
    }

    private static void GenerateModulesFolders(string path, string mainModuleName, string moduleName)
    {
        if (!Directory.Exists(Path.Combine(path, mainModuleName)))
        {
            GenerateFolder(Path.Combine(path, mainModuleName));
            if (!Directory.Exists(Path.Combine(path, mainModuleName, moduleName)))
            {
                GenerateFolder(Path.Combine(path, mainModuleName, moduleName));
            }
        }
        else
        {
            if (!Directory.Exists(Path.Combine(path, mainModuleName, moduleName)))
            {
                GenerateFolder(Path.Combine(path, mainModuleName, moduleName));
            }
        }
    }

    private static void GenerateFolder(string path)
    {
        Directory.CreateDirectory(path);
    }

    #region Generate Logic 
    private static bool GenerateController(string project, string basePath, string moduleName, string mainModuleName)
    {
        try
        {
            string path = Path.Combine(basePath, project + @".Web\Controllers\");
            GenerateModulesFolders(path, mainModuleName, moduleName);
            string fileName = Path.Combine(path, mainModuleName, moduleName, moduleName + "Controller.cs");
            string content = GetControllerTemplate(moduleName, mainModuleName);
            WriteToFile(fileName, content);
        }
        catch (Exception)
        {
            return false;
        }
        return true;
    }
    private static bool GenerateService(string project, string basePath, string moduleName, string mainModuleName)
    {
        try
        {
            string path = Path.Combine(basePath, project + @".Services\");
            GenerateModulesFolders(path, mainModuleName, moduleName);
            string fileName = Path.Combine(path, mainModuleName, moduleName, moduleName + "Service.cs");
            string content = GetServiceImplementationTemplate(moduleName, mainModuleName);
            WriteToFile(fileName, content);

            path = Path.Combine(basePath, project + @".Services.Abstractions\");
            GenerateModulesFolders(path, mainModuleName, moduleName);
            fileName = Path.Combine(path, mainModuleName, moduleName, "I" + moduleName + "Service.cs");
            content = GetServiceInterfaceTemplate(moduleName, mainModuleName);
            WriteToFile(fileName, content);
        }
        catch (Exception)
        {
            return false;
        }
        return true;
    }
    private static bool GenerateRepository(string project, string basePath, string moduleName, string mainModuleName)
    {
        try
        {
            string path = Path.Combine(basePath, project + @".Persistence\Repositories\");
            GenerateModulesFolders(path, mainModuleName, moduleName);
            string fileName = Path.Combine(path, mainModuleName, moduleName, moduleName + "Repository.cs");
            string content = GetRepositoryImplementationTemplate(moduleName, mainModuleName);
            WriteToFile(fileName, content);

            path = Path.Combine(basePath, project + @".Domain\Repositories\");
            GenerateModulesFolders(path, mainModuleName, moduleName);
            fileName = Path.Combine(path, mainModuleName, moduleName, "I" + moduleName + "Repository.cs");
            content = GetRepositoryInterfaceTemplate(moduleName, mainModuleName);
            WriteToFile(fileName, content);
        }
        catch (Exception)
        {
            return false;
        }
        return true;
    }
    #endregion  Generate Logic END
  
    #region Common Methods
    private static void GenerateResponse(bool res, string msg)
    {
        string successMsg = "Successfully Generated";
        string failedMsg = "Failed";

        if (res)
        {
            Console.Write(msg + "......................." + successMsg);
        }
        else
        {
            Console.Write(msg + "......................." + failedMsg);
        }
        Console.WriteLine();
    }
    private static string FirstCharToSmall(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return string.Empty;
        }

        var stringArray = input.ToCharArray();

        if (char.IsUpper(stringArray[0]))
        {
            stringArray[0] = char.ToLower(stringArray[0]);
        }

        return new string(stringArray);
    }
    #endregion Common Methods END
    
    #region Template Area
    private static string GenerateInsertUpdateModelTemplate(string ModuleName, string mainModuleName)
    {
        string content = string.Empty;
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("");

        sb.AppendLine("\n  namespace DCI.Domain.Entities.#MainModule.#Module");
        sb.AppendLine("\n  {                                                                                                                                  ");
        sb.AppendLine("\n      public class #ModuleEntity                                                                                                     ");
        sb.AppendLine("\n      {                                                                                                                              ");
        sb.AppendLine("\n          public int #ModuleId { get; set; }                                                                                         ");
        sb.AppendLine("\n      }                                                                                                                              ");
        sb.AppendLine("\n  }                                                                                                                                  ");

        if (mainModuleName == string.Empty)
        {
            content = sb.Replace(".#MainModule", "").Replace("#Module", ModuleName).ToString();
        }
        else
        {
            content = sb.Replace("#MainModule", mainModuleName).Replace("#Module", ModuleName).ToString();
        }
        return content;

    }
    private static string GenerateReadModelTemplate(string ModuleName, string mainModuleName)
    {
        string content = string.Empty;
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("");

        sb.AppendLine("\n  namespace DCI.Domain.Entities.#MainModule.#Module");
        sb.AppendLine("\n  {                                                                                                                                   ");
        sb.AppendLine("\n      public class #ModuleReadOnlyEntity                                                                                              ");
        sb.AppendLine("\n      {                                                                                                                               ");
        sb.AppendLine("\n          public int #ModuleId { get; set; }                                                                                          ");
        sb.AppendLine("\n      }                                                                                                                               ");
        sb.AppendLine("\n  }                                                                                                                                   ");


        if (mainModuleName == string.Empty)
        {
            content = sb.Replace(".#MainModule", "").Replace("#Module", ModuleName).ToString();
            content = sb.Replace("#Module", ModuleName)
           .ToString();

        }
        else
        {
            content = sb.Replace("#MainModule", mainModuleName).Replace("#Module", ModuleName).ToString();
            content = sb.Replace("#Module", ModuleName)
            .ToString();

        }
        return content;       

    }
    private static string GetControllerTemplate(string ModuleName, string mainModuleName)
    {
        string content = string.Empty;
        StringBuilder sb = new StringBuilder();

        sb.Append("\n using DCI.Domain.Entities.Base;                                                                                                            ");
        sb.Append("\n using DCI.Domain.Entities.#MainModule.#Module;																		                	  ");
        sb.Append("\n using DCI.Services.Abstractions.#MainModule.#Module;																	                	  ");
        sb.Append("\n using Microsoft.AspNetCore.Mvc;																						                	  ");
        sb.Append("\n 																														                	  ");
        sb.Append("\n namespace DCI.Web.Controllers.#MainModule.#Module																	                	  ");
        sb.Append("\n {																														                	  ");
        sb.Append("\n     /// <summary>																										                	  ");
        sb.Append("\n     /// 																												                	  ");
        sb.Append("\n     /// </summary>																									                	  ");
        sb.Append("\n     [Route(\"api/[controller]\")]																						                	  ");
        sb.Append("\n     [ApiController]																									                	  ");
        sb.Append("\n     public class #ModuleController : BaseController																	                      ");
        sb.Append("\n     {																													                	  ");
        sb.Append("\n         private readonly I#ModuleService _#refrencesService;															                      ");
        sb.Append("\n         public #ModuleController(I#ModuleService #refrencesService) => _#refrencesService = #refrencesService;		                      ");
        sb.Append("\n     																													                	  ");
        sb.Append("\n         #region #Module                                                                              					                      ");
        sb.Append("\n         /// <summary>                                                                                   				                	  ");
        sb.Append("\n         /// Fetch All #Module                                                                             		                     	  ");
        sb.Append("\n         /// </summary>                                                                                  				                	  ");
        sb.Append("\n         [HttpGet]																										                	  ");
        sb.Append("\n         public async Task<IActionResult> Get(CancellationToken cancellationToken = default)							                	  ");
        sb.Append("\n         {																												                	  ");
        sb.Append("\n             ResponseModel objResponse = await _#refrencesService.Get#ModuleAsync(cancellationToken);					                      ");
        sb.Append("\n             return await SendResponse(objResponse);																	                	  ");
        sb.Append("\n         }																												                	  ");
        sb.Append("\n 																														                	  ");
        sb.Append("\n         /// <summary>                                                                                   				                	  ");
        sb.Append("\n         /// Get #Module by ID                                                                        					                      ");
        sb.Append("\n         /// </summary>                                                                                  				                	  ");
        sb.Append("\n         [HttpGet(\"{ID}\")]																					    	                      ");
        sb.Append("\n         public async Task<IActionResult> GetById(int ID, CancellationToken cancellationToken = default)				                	  ");
        sb.Append("\n         {																												                	  ");
        sb.Append("\n             ResponseModel objResponse = await _#refrencesService.Get#ModuleByIdAsync(ID, cancellationToken);			                      ");
        sb.Append("\n             return await SendResponse(objResponse);																	                	  ");
        sb.Append("\n         }																												                	  ");
        sb.Append("\n 																														                	  ");
        sb.Append("\n         /// <summary>                                                                                   				                	  ");
        sb.Append("\n         /// To Add #Module                                                                          					                      ");
        sb.Append("\n         /// </summary>                                                                                  				                	  ");
        sb.Append("\n         [HttpPost]																									                	  ");
        sb.Append("\n         public async Task<IActionResult> Post([FromBody] #ModuleEntity inputparameters, CancellationToken cancellationToken = default)	  ");
        sb.Append("\n         {																																	  ");
        sb.Append("\n             ResponseModel objResponse = await _#refrencesService.Save#ModuleAsync(inputparameters, cancellationToken);					  ");
        sb.Append("\n             return await SendResponse(objResponse);																						  ");
        sb.Append("\n         }																																	  ");
        sb.Append("\n 																																			  ");
        sb.Append("\n         /// <summary>                                                                                   									  ");
        sb.Append("\n         /// To Update #Module                                                                      							    		  ");
        sb.Append("\n         /// </summary>                                                                                  									  ");
        sb.Append("\n         [HttpPut]																															  ");
        sb.Append("\n         public async Task<IActionResult> Put([FromBody] #ModuleEntity inputparameters, CancellationToken cancellationToken = default)	      ");
        sb.Append("\n         {																																	  ");
        sb.Append("\n             ResponseModel objResponse = await _#refrencesService.Update#ModuleAsync(inputparameters, cancellationToken);				      ");
        sb.Append("\n             return await SendResponse(objResponse);																						  ");
        sb.Append("\n         }																																	  ");
        sb.Append("\n 																																			  ");
        sb.Append("\n         /// <summary>                                                                                   									  ");
        sb.Append("\n         /// To Deactivate #Module                                                                    								    	  ");
        sb.Append("\n         /// </summary>                                                                                  									  ");
        sb.Append("\n 																																			  ");
        sb.Append("\n         [HttpDelete(\"{ID}\")]																									     	   ");
        sb.Append("\n         public async Task<IActionResult> Delete(int ID, CancellationToken cancellationToken = default)									  ");
        sb.Append("\n         {																																	  ");
        sb.Append("\n             ResponseModel objResponse = await _#refrencesService.Delete#ModuleAsync(ID, cancellationToken);							      ");
        sb.Append("\n             return await SendResponse(objResponse);																						  ");
        sb.Append("\n         }													     																			   ");
        sb.Append("\n         #endregion																														  ");
        sb.Append("\n     }																																		  ");
        sb.Append("\n }                                                                                                                                           ");

        if (mainModuleName == string.Empty)
        {
            content = sb.Replace(".#MainModule", "").Replace("#Module", ModuleName).ToString();
            string refrence = FirstCharToSmall(ModuleName);
            content = sb.Replace("#Module", ModuleName)
                                  .Replace("#refrences", refrence)                              
                                  .ToString();
        }
        else
        {
            content = sb.Replace("#MainModule", mainModuleName).Replace("#Module", ModuleName).ToString();
            string refrence = FirstCharToSmall(ModuleName);
            content = sb.Replace("#Module", ModuleName)
                                  .Replace("#refrences", refrence)                              
                                  .ToString();
        }
        return content;       
    
    }
    private static string GetServiceImplementationTemplate(string ModuleName, string mainModuleName)
    {
        string content = string.Empty;
        StringBuilder sb = new StringBuilder();

        sb.Append("\n using DCI.Domain.Entities.Base;                                                                                                      ");
        sb.Append("\n using DCI.Domain.Entities.#MainModule.#Module;							                                                            ");
        sb.Append("\n using DCI.Domain.Repositories.#MainModule.#Module;						                                                            ");
        sb.Append("\n using DCI.Services.Abstractions.#MainModule.#Module;						                                                            ");
        sb.Append("\n using DCI.Services.Base;													                                                            ");
        sb.Append("\n using DCI.Utility;														                                                            ");
        sb.Append("\n 																			                                                            ");
        sb.Append("\n namespace DCI.Services.#MainModule.#Module								                                                            ");
        sb.Append("\n {																			                                                            ");
        sb.Append("\n     public class #ModuleService : BaseService, I#ModuleService		                                                                ");
        sb.Append("\n     {																		                                                            ");
        sb.Append("\n         #region variables													                                                            ");
        sb.Append("\n         private readonly I#ModuleRepository _#refrencesRepository;		                                                            ");
        sb.Append("\n         ResponseModel blank_result = new ResponseModel();					                                                            ");
        sb.Append("\n         #endregion														                                                            ");
        sb.Append("\n 																			                                                            ");
        sb.Append("\n         #region Constructor												                                                            ");
        sb.Append("\n         public #ModuleService(I#ModuleRepository #refrencesRepository) => _#refrencesRepository = #refrencesRepository;               ");
        sb.Append("\n         #endregion                                                                                                                     ");
        sb.Append("\n 																									                                     ");
        sb.Append("\n         #region #Module																			                                     ");
        sb.Append("\n         public async Task<ResponseModel> Get#ModuleAsync(CancellationToken cancellationToken)	                                         ");
        sb.Append("\n         {																							                                     ");
        sb.Append("\n             var obj = await _#refrencesRepository.Get#ModuleAsync(cancellationToken);			                                         ");
        sb.Append("\n             return await ReadResponse(obj);														                                     ");
        sb.Append("\n         }																							                                     ");
        sb.Append("\n         public async Task<ResponseModel> Get#ModuleByIdAsync(int inputparameters, CancellationToken cancellationToken)                 ");
        sb.Append("\n         {		 var obj = await _#refrencesRepository.Get#ModuleByIdAsync(inputparameters, cancellationToken);			                 ");
        sb.Append("\n             return await ReadResponse(obj);																     						 ");
        sb.Append("\n         }																			                                                     ");
        sb.Append("\n         public async Task<ResponseModel> Save#ModuleAsync(#ModuleEntity inputparameters, CancellationToken cancellationToken)          ");
        sb.Append("\n         {																															     ");
        sb.Append("\n             DBResponseEntity obj = await _#refrencesRepository.Save#ModuleAsync(inputparameters, cancellationToken);			         ");
        sb.Append("\n             return await Response(obj, Enums.Insert.ToString());																	     ");
        sb.Append("\n         }																															     ");
        sb.Append("\n         public async Task<ResponseModel> Update#ModuleAsync(#ModuleEntity inputparameters, CancellationToken cancellationToken)        ");
        sb.Append("\n         {																															     ");
        sb.Append("\n             DBResponseEntity obj = await _#refrencesRepository.Update#ModuleAsync(inputparameters, cancellationToken);			     ");
        sb.Append("\n             return await Response(obj, Enums.Update.ToString());																	     ");
        sb.Append("\n         }																															     ");
        sb.Append("\n         public async Task<ResponseModel> Delete#ModuleAsync(int inputparameters, CancellationToken cancellationToken)		    	     ");
        sb.Append("\n         {																															     ");
        sb.Append("\n             DBResponseEntity obj = await _#refrencesRepository.Delete#ModuleAsync(inputparameters, cancellationToken);			     ");
        sb.Append("\n             return await Response(obj, Enums.Delete.ToString());		                                                                 ");
        sb.Append("\n         }																                                                                 ");
        sb.Append("\n         #endregion													                                                                 ");
        sb.Append("\n     }																	                                                                 ");
        sb.Append("\n }																		                                                                 ");

        if (mainModuleName == string.Empty)
        {
            content = sb.Replace(".#MainModule", "").Replace("#Module", ModuleName).ToString();
            string refrence = FirstCharToSmall(ModuleName);
            content = sb.Replace("#Module", ModuleName)
                        .Replace("#refrences", refrence)
                        .ToString();
        }
        else
        {
            content = sb.Replace("#MainModule", mainModuleName).Replace("#Module", ModuleName).ToString();
            string refrence = FirstCharToSmall(ModuleName);
            content = sb.Replace("#Module", ModuleName)
                        .Replace("#refrences", refrence)
                        .ToString();
        }
        return content;        
       
    }
    private static string GetServiceInterfaceTemplate(string ModuleName, string mainModuleName)
    {
        string content = string.Empty;
        StringBuilder sb = new StringBuilder();

        sb.Append("\n using DCI.Domain.Entities.Base;                                                                                                         ");
        sb.Append("\n using DCI.Domain.Entities.#MainModule.#Module;					                                                                       ");
        sb.Append("\n 																                                                                           ");
        sb.Append("\n namespace DCI.Services.Abstractions.#MainModule.#Module		                                                                           ");
        sb.Append("\n {																                                                                           ");
        sb.Append("\n     public interface I#ModuleService						                                                                               ");
        sb.Append("\n     {														     	                                                                       ");
        sb.Append("\n         #region #Module                                                                                                                  ");
        sb.Append("\n         Task<ResponseModel> Get#ModuleAsync(CancellationToken cancellationToken);                                                        ");
        sb.Append("\n         Task<ResponseModel> Get#ModuleByIdAsync(int inputparameters, CancellationToken cancellationToken);		                       ");
        sb.Append("\n         Task<ResponseModel> Save#ModuleAsync(#ModuleEntity inputparameters, CancellationToken cancellationToken);	                       ");
        sb.Append("\n         Task<ResponseModel> Update#ModuleAsync(#ModuleEntity inputparameters, CancellationToken cancellationToken);  	                   ");
        sb.Append("\n         Task<ResponseModel> Delete#ModuleAsync(int inputparameters, CancellationToken cancellationToken);				                   ");
        sb.Append("\n         #endregion                                                                                                                       ");
        sb.Append("\n     }															                                                                           ");
        sb.Append("\n }																                                                                           ");

        if (mainModuleName == string.Empty)
        {
            content = sb.Replace(".#MainModule", "").Replace("#Module", ModuleName).ToString();
            string refrence = FirstCharToSmall(ModuleName);
            content = sb.Replace("#Module", ModuleName)
                        .ToString();
        }
        else
        {
            content = sb.Replace("#MainModule", mainModuleName).Replace("#Module", ModuleName).ToString();
            string refrence = FirstCharToSmall(ModuleName);
            content = sb.Replace("#Module", ModuleName)
                        .ToString();
        }
        return content;       
        
    }
    private static string GetRepositoryInterfaceTemplate(string ModuleName, string mainModuleName)
    {
        string content = string.Empty;
        StringBuilder sb = new StringBuilder();

        sb.Append("\n using DCI.Domain.Entities.Base;                                                                                                         ");
        sb.Append("\n using DCI.Domain.Entities.#MainModule.#Module;			                                                                               ");
        sb.Append("\n 														                                                                                   ");
        sb.Append("\n namespace DCI.Domain.Repositories.#MainModule.#Module  	                                                                               ");
        sb.Append("\n {														                                                                                   ");
        sb.Append("\n     public interface I#ModuleRepository			                                                                                       ");
        sb.Append("\n     {													                                                                                   ");
        sb.Append("\n         #region #Module                                                                                                                  ");
        sb.Append("\n         Task<IEnumerable<#ModuleReadOnlyEntity>> Get#ModuleAsync(CancellationToken cancellationToken);                                   ");
        sb.Append("\n         Task<IEnumerable<#ModuleReadOnlyEntity>> Get#ModuleByIdAsync(int inputparameters, CancellationToken cancellationToken);	       ");
        sb.Append("\n         Task<DBResponseEntity> Save#ModuleAsync(#ModuleEntity inputparameters, CancellationToken cancellationToken);					   ");
        sb.Append("\n         Task<DBResponseEntity> Update#ModuleAsync(#ModuleEntity inputparameters, CancellationToken cancellationToken);				   ");
        sb.Append("\n         Task<DBResponseEntity> Delete#ModuleAsync(int inputparameters, CancellationToken cancellationToken);						   	   ");
        sb.Append("\n         #endregion                                                                                                                       ");
        sb.Append("\n     }														                                                                               ");
        sb.Append("\n }															                                                                               ");

        if (mainModuleName == string.Empty)
        {
            content = sb.Replace(".#MainModule", "").Replace("#Module", ModuleName).ToString();
            string refrence = FirstCharToSmall(ModuleName);
            content = sb.Replace("#Module", ModuleName)
                        .ToString();
        }
        else
        {
            content = sb.Replace("#MainModule", mainModuleName).Replace("#Module", ModuleName).ToString();
            string refrence = FirstCharToSmall(ModuleName);
            content = sb.Replace("#Module", ModuleName)
                        .ToString();
        }
        return content;      
        
    }
    private static string GetRepositoryImplementationTemplate(string ModuleName, string mainModuleName)
    {
        string content = string.Empty;
        StringBuilder sb = new StringBuilder();

        sb.Append("\n using DCI.Domain.Entities.Base;                                                                                                                           ");
        sb.Append("\n using DCI.Domain.Entities.#MainModule.#Module;										                                                                	 ");
        sb.Append("\n using DCI.Domain.Repositories.#MainModule.#Module;									                                                                	 ");
        sb.Append("\n using DCI.Persistence.Repositories.BaseRepository;									                                                                	 ");
        sb.Append("\n using DCI.Persistence.Repositories.Constants;										                                                                	 ");
        sb.Append("\n 																						                                                                	 ");
        sb.Append("\n namespace DCI.Persistence.Repositories.#MainModule.#Module						                                                                    	 ");
        sb.Append("\n {																						                                                                	 ");
        sb.Append("\n     public class #ModuleRepository : GenericRepository, I#ModuleRepository			                                                                     ");
        sb.Append("\n     {																					                                                                	 ");
        sb.Append("\n         #region Variables																                                                                	 ");
        sb.Append("\n         private readonly RepositoryDbContext _dbContext;								                                                                	 ");
        sb.Append("\n         #endregion																	                                                                	 ");
        sb.Append("\n 																						                                                                	 ");
        sb.Append("\n         #region Constructor															                                                                	 ");
        sb.Append("\n         public #ModuleRepository(RepositoryDbContext dbContext) : base(dbContext)		                                                                     ");
        sb.Append("\n         {																				                                                                	 ");
        sb.Append("\n             _dbContext = dbContext;													                                                                	 ");
        sb.Append("\n         }																				                                                                	 ");
        sb.Append("\n         #endregion																	                                                                	 ");
        sb.Append("\n 																						                                                                	 ");
        sb.Append("\n         #region #Module																                                                                	 ");
        sb.Append("\n         public async Task<IEnumerable<#ModuleReadOnlyEntity>> Get#ModuleAsync(CancellationToken cancellationToken)                                         ");
        sb.Append("\n         {																																	  	        	 ");
        sb.Append("\n             return await Get<#ModuleReadOnlyEntity>(RepositoryConstants.GET#Constant);															    	 ");
        sb.Append("\n         }																																					 ");
        sb.Append("\n         public async Task<IEnumerable<#ModuleReadOnlyEntity>> Get#ModuleByIdAsync(int inputparameters, CancellationToken cancellationToken)		     	 ");
        sb.Append("\n         {																																					 ");
        sb.Append("\n             return await GetById<int, #ModuleReadOnlyEntity>(inputparameters, RepositoryConstants.GET#ConstantBYID);								    	 ");
        sb.Append("\n         }																																					 ");
        sb.Append("\n         public async Task<DBResponseEntity> Save#ModuleAsync(#ModuleEntity inputparameters, CancellationToken cancellationToken)				        	 ");
        sb.Append("\n         {																																					 ");
        sb.Append("\n             return await Insert<#ModuleEntity, DBResponseEntity>(inputparameters, RepositoryConstants.ADD#Constant);								    	 ");
        sb.Append("\n         }																																					 ");
        sb.Append("\n         public async Task<DBResponseEntity> Update#ModuleAsync(#ModuleEntity inputparameters, CancellationToken cancellationToken)				    	 ");
        sb.Append("\n         {																																					 ");
        sb.Append("\n             return await Update<#ModuleEntity, DBResponseEntity>(inputparameters, RepositoryConstants.UPDATE#Constant);						    		 ");
        sb.Append("\n         }																																	 				 ");
        sb.Append("\n         public async Task<DBResponseEntity> Delete#ModuleAsync(int inputparameters, CancellationToken cancellationToken)					    			 ");
        sb.Append("\n         {																																					 ");
        sb.Append("\n             return await Delete<int, DBResponseEntity>(inputparameters, RepositoryConstants.DELETE#Constant);								      			 ");
        sb.Append("\n         }																				                                                                	 ");
        sb.Append("\n         #endregion																	                                                                	 ");
        sb.Append("\n     }																					                                                                	 ");
        sb.Append("\n }																						                                                                	 ");

        if (mainModuleName == string.Empty)
        {
            content = sb.Replace(".#MainModule", "").Replace("#Module", ModuleName).ToString();
            string refrence = FirstCharToSmall(ModuleName);
            content = sb.Replace("#Module", ModuleName)
                        .Replace("#refrences", refrence)
                        .Replace("#Constant", ModuleName.ToUpper())
                        .ToString();
        }
        else
        {
            content = sb.Replace("#MainModule", mainModuleName).Replace("#Module", ModuleName).ToString();
            string refrence = FirstCharToSmall(ModuleName);
            content = sb.Replace("#Module", ModuleName)
                        .Replace("#refrences", refrence)
                        .Replace("#Constant", ModuleName.ToUpper())
                        .ToString();
        }
        return content;
    }
    #endregion Template Area END
}