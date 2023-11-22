
 using DCI.Domain.Entities.Base;                                                                                                                           
 using DCI.Domain.Entities.Master.Role;										                                                                	 
 using DCI.Domain.Repositories.Master.Role;									                                                                	 
 using DCI.Persistence.Repositories.BaseRepository;									                                                                	 
 using DCI.Persistence.Repositories.Constants;										                                                                	 
 																						                                                                	 
 namespace DCI.Persistence.Repositories.Master.Role						                                                                    	 
 {																						                                                                	 
     public class RoleRepository : GenericRepository, IRoleRepository			                                                                     
     {																					                                                                	 
         #region Variables																                                                                	 
         private readonly RepositoryDbContext _dbContext;								                                                                	 
         #endregion																	                                                                	 
 																						                                                                	 
         #region Constructor															                                                                	 
         public RoleRepository(RepositoryDbContext dbContext) : base(dbContext)		                                                                     
         {																				                                                                	 
             _dbContext = dbContext;													                                                                	 
         }																				                                                                	 
         #endregion																	                                                                	 
 																						                                                                	 
         #region Role																                                                                	 
         public async Task<IEnumerable<RoleReadOnlyEntity>> GetRoleAsync(CancellationToken cancellationToken)                                         
         {																																	  	        	 
             return await Get<RoleReadOnlyEntity>(RepositoryConstants.GETROLE);															    	 
         }																																					 
         public async Task<IEnumerable<RoleReadOnlyEntity>> GetRoleByIdAsync(int inputparameters, CancellationToken cancellationToken)		     	 
         {																																					 
             return await GetById<int, RoleReadOnlyEntity>(inputparameters, RepositoryConstants.GETROLEBYID);								    	 
         }																																					 
         public async Task<DBResponseEntity> SaveRoleAsync(RoleEntity inputparameters, CancellationToken cancellationToken)				        	 
         {																																					 
             return await Insert<RoleEntity, DBResponseEntity>(inputparameters, RepositoryConstants.ADDROLE);								    	 
         }																																					 
         public async Task<DBResponseEntity> UpdateRoleAsync(RoleEntity inputparameters, CancellationToken cancellationToken)				    	 
         {																																					 
             return await Update<RoleEntity, DBResponseEntity>(inputparameters, RepositoryConstants.UPDATEROLE);						    		 
         }																																	 				 
         public async Task<DBResponseEntity> DeleteRoleAsync(int inputparameters, CancellationToken cancellationToken)					    			 
         {																																					 
             return await Delete<int, DBResponseEntity>(inputparameters, RepositoryConstants.DELETEROLE);								      			 
         }																				                                                                	 
         #endregion																	                                                                	 
     }																					                                                                	 
 }																						                                                                	 