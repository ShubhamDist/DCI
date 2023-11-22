
 using DCI.Domain.Entities.Base;                                                                                                                           
 using DCI.Domain.Entities.Master.Screen;										                                                                	 
 using DCI.Domain.Repositories.Master.Screen;									                                                                	 
 using DCI.Persistence.Repositories.BaseRepository;									                                                                	 
 using DCI.Persistence.Repositories.Constants;										                                                                	 
 																						                                                                	 
 namespace DCI.Persistence.Repositories.Master.Screen						                                                                    	 
 {																						                                                                	 
     public class ScreenRepository : GenericRepository, IScreenRepository			                                                                     
     {																					                                                                	 
         #region Variables																                                                                	 
         private readonly RepositoryDbContext _dbContext;								                                                                	 
         #endregion																	                                                                	 
 																						                                                                	 
         #region Constructor															                                                                	 
         public ScreenRepository(RepositoryDbContext dbContext) : base(dbContext)		                                                                     
         {																				                                                                	 
             _dbContext = dbContext;													                                                                	 
         }																				                                                                	 
         #endregion																	                                                                	 
 																						                                                                	 
         #region Screen																                                                                	 
         public async Task<IEnumerable<ScreenReadOnlyEntity>> GetScreenAsync(CancellationToken cancellationToken)                                         
         {																																	  	        	 
             return await Get<ScreenReadOnlyEntity>(RepositoryConstants.GETSCREEN);															    	 
         }																																					 
         public async Task<IEnumerable<ScreenReadOnlyEntity>> GetScreenByIdAsync(int inputparameters, CancellationToken cancellationToken)		     	 
         {																																					 
             return await GetById<int, ScreenReadOnlyEntity>(inputparameters, RepositoryConstants.GETSCREENBYID);								    	 
         }																																					 
         public async Task<DBResponseEntity> SaveScreenAsync(ScreenEntity inputparameters, CancellationToken cancellationToken)				        	 
         {																																					 
             return await Insert<ScreenEntity, DBResponseEntity>(inputparameters, RepositoryConstants.ADDSCREEN);								    	 
         }																																					 
         public async Task<DBResponseEntity> UpdateScreenAsync(ScreenEntity inputparameters, CancellationToken cancellationToken)				    	 
         {																																					 
             return await Update<ScreenEntity, DBResponseEntity>(inputparameters, RepositoryConstants.UPDATESCREEN);						    		 
         }																																	 				 
         public async Task<DBResponseEntity> DeleteScreenAsync(int inputparameters, CancellationToken cancellationToken)					    			 
         {																																					 
             return await Delete<int, DBResponseEntity>(inputparameters, RepositoryConstants.DELETESCREEN);								      			 
         }																				                                                                	 
         #endregion																	                                                                	 
     }																					                                                                	 
 }																						                                                                	 