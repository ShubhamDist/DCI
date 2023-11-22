
 using DCI.Domain.Entities.Base;                                                                                                                           
 using DCI.Domain.Entities.Master.Configuration;										                                                                	 
 using DCI.Domain.Repositories.Master.Configuration;									                                                                	 
 using DCI.Persistence.Repositories.BaseRepository;									                                                                	 
 using DCI.Persistence.Repositories.Constants;										                                                                	 
 																						                                                                	 
 namespace DCI.Persistence.Repositories.Master.Configuration						                                                                    	 
 {																						                                                                	 
     public class ConfigurationRepository : GenericRepository, IConfigurationRepository			                                                                     
     {																					                                                                	 
         #region Variables																                                                                	 
         private readonly RepositoryDbContext _dbContext;								                                                                	 
         #endregion																	                                                                	 
 																						                                                                	 
         #region Constructor															                                                                	 
         public ConfigurationRepository(RepositoryDbContext dbContext) : base(dbContext)		                                                                     
         {																				                                                                	 
             _dbContext = dbContext;													                                                                	 
         }																				                                                                	 
         #endregion																	                                                                	 
 																						                                                                	 
         #region Configuration																                                                                	 
         public async Task<IEnumerable<ConfigurationReadOnlyEntity>> GetConfigurationAsync(CancellationToken cancellationToken)                                         
         {																																	  	        	 
             return await Get<ConfigurationReadOnlyEntity>(RepositoryConstants.GETCONFIGURATION);															    	 
         }																																					 
         public async Task<IEnumerable<ConfigurationReadOnlyEntity>> GetConfigurationByIdAsync(int inputparameters, CancellationToken cancellationToken)		     	 
         {																																					 
             return await GetById<int, ConfigurationReadOnlyEntity>(inputparameters, RepositoryConstants.GETCONFIGURATIONBYID);								    	 
         }																																					 
         public async Task<DBResponseEntity> SaveConfigurationAsync(ConfigurationEntity inputparameters, CancellationToken cancellationToken)				        	 
         {																																					 
             return await Insert<ConfigurationEntity, DBResponseEntity>(inputparameters, RepositoryConstants.ADDCONFIGURATION);								    	 
         }																																					 
         public async Task<DBResponseEntity> UpdateConfigurationAsync(ConfigurationEntity inputparameters, CancellationToken cancellationToken)				    	 
         {																																					 
             return await Update<ConfigurationEntity, DBResponseEntity>(inputparameters, RepositoryConstants.UPDATECONFIGURATION);						    		 
         }																																	 				 
         public async Task<DBResponseEntity> DeleteConfigurationAsync(int inputparameters, CancellationToken cancellationToken)					    			 
         {																																					 
             return await Delete<int, DBResponseEntity>(inputparameters, RepositoryConstants.DELETECONFIGURATION);								      			 
         }																				                                                                	 
         #endregion																	                                                                	 
     }																					                                                                	 
 }																						                                                                	 