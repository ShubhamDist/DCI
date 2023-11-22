
 using DCI.Domain.Entities.Base;                                                                                                                           
 using DCI.Domain.Entities.Master.TypeMaster;										                                                                	 
 using DCI.Domain.Repositories.Master.TypeMaster;									                                                                	 
 using DCI.Persistence.Repositories.BaseRepository;									                                                                	 
 using DCI.Persistence.Repositories.Constants;										                                                                	 
 																						                                                                	 
 namespace DCI.Persistence.Repositories.Master.TypeMaster						                                                                    	 
 {																						                                                                	 
     public class TypeMasterRepository : GenericRepository, ITypeMasterRepository			                                                                     
     {																					                                                                	 
         #region Variables																                                                                	 
         private readonly RepositoryDbContext _dbContext;								                                                                	 
         #endregion																	                                                                	 
 																						                                                                	 
         #region Constructor															                                                                	 
         public TypeMasterRepository(RepositoryDbContext dbContext) : base(dbContext)		                                                                     
         {																				                                                                	 
             _dbContext = dbContext;													                                                                	 
         }																				                                                                	 
         #endregion																	                                                                	 
 																						                                                                	 
         #region TypeMaster																                                                                	 
         public async Task<IEnumerable<TypeMasterReadOnlyEntity>> GetTypeMasterAsync(CancellationToken cancellationToken)                                         
         {																																	  	        	 
             return await Get<TypeMasterReadOnlyEntity>(RepositoryConstants.GETTYPEMASTER);															    	 
         }																																					 
         public async Task<IEnumerable<TypeMasterReadOnlyEntity>> GetTypeMasterByIdAsync(int inputparameters, CancellationToken cancellationToken)		     	 
         {																																					 
             return await GetById<int, TypeMasterReadOnlyEntity>(inputparameters, RepositoryConstants.GETTYPEMASTERBYID);								    	 
         }																																					 
         public async Task<DBResponseEntity> SaveTypeMasterAsync(TypeMasterEntity inputparameters, CancellationToken cancellationToken)				        	 
         {																																					 
             return await Insert<TypeMasterEntity, DBResponseEntity>(inputparameters, RepositoryConstants.ADDTYPEMASTER);								    	 
         }																																					 
         public async Task<DBResponseEntity> UpdateTypeMasterAsync(TypeMasterEntity inputparameters, CancellationToken cancellationToken)				    	 
         {																																					 
             return await Update<TypeMasterEntity, DBResponseEntity>(inputparameters, RepositoryConstants.UPDATETYPEMASTER);						    		 
         }																																	 				 
         public async Task<DBResponseEntity> DeleteTypeMasterAsync(int inputparameters, CancellationToken cancellationToken)					    			 
         {																																					 
             return await Delete<int, DBResponseEntity>(inputparameters, RepositoryConstants.DELETETYPEMASTER);								      			 
         }																				                                                                	 
         #endregion																	                                                                	 
     }																					                                                                	 
 }																						                                                                	 