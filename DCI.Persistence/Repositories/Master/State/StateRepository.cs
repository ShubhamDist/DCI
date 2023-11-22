
 using DCI.Domain.Entities.Base;                                                                                                                           
 using DCI.Domain.Entities.Master.State;										                                                                	 
 using DCI.Domain.Repositories.Master.State;									                                                                	 
 using DCI.Persistence.Repositories.BaseRepository;									                                                                	 
 using DCI.Persistence.Repositories.Constants;										                                                                	 
 																						                                                                	 
 namespace DCI.Persistence.Repositories.Master.State						                                                                    	 
 {																						                                                                	 
     public class StateRepository : GenericRepository, IStateRepository			                                                                     
     {																					                                                                	 
         #region Variables																                                                                	 
         private readonly RepositoryDbContext _dbContext;								                                                                	 
         #endregion																	                                                                	 
 																						                                                                	 
         #region Constructor															                                                                	 
         public StateRepository(RepositoryDbContext dbContext) : base(dbContext)		                                                                     
         {																				                                                                	 
             _dbContext = dbContext;													                                                                	 
         }																				                                                                	 
         #endregion																	                                                                	 
 																						                                                                	 
         #region State																                                                                	 
         public async Task<IEnumerable<StateReadOnlyEntity>> GetStateAsync(CancellationToken cancellationToken)                                         
         {																																	  	        	 
             return await Get<StateReadOnlyEntity>(RepositoryConstants.GETSTATE);															    	 
         }																																					 
         public async Task<IEnumerable<StateReadOnlyEntity>> GetStateByIdAsync(int inputparameters, CancellationToken cancellationToken)		     	 
         {																																					 
             return await GetById<int, StateReadOnlyEntity>(inputparameters, RepositoryConstants.GETSTATEBYID);								    	 
         }																																					 
         public async Task<DBResponseEntity> SaveStateAsync(StateEntity inputparameters, CancellationToken cancellationToken)				        	 
         {																																					 
             return await Insert<StateEntity, DBResponseEntity>(inputparameters, RepositoryConstants.ADDSTATE);								    	 
         }																																					 
         public async Task<DBResponseEntity> UpdateStateAsync(StateEntity inputparameters, CancellationToken cancellationToken)				    	 
         {																																					 
             return await Update<StateEntity, DBResponseEntity>(inputparameters, RepositoryConstants.UPDATESTATE);						    		 
         }																																	 				 
         public async Task<DBResponseEntity> DeleteStateAsync(int inputparameters, CancellationToken cancellationToken)					    			 
         {																																					 
             return await Delete<int, DBResponseEntity>(inputparameters, RepositoryConstants.DELETESTATE);								      			 
         }																				                                                                	 
         #endregion																	                                                                	 
     }																					                                                                	 
 }																						                                                                	 