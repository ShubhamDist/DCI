
 using DCI.Domain.Entities.Base;                                                                                                                           
 using DCI.Domain.Entities.Master.Region;										                                                                	 
 using DCI.Domain.Repositories.Master.Region;									                                                                	 
 using DCI.Persistence.Repositories.BaseRepository;									                                                                	 
 using DCI.Persistence.Repositories.Constants;										                                                                	 
 																						                                                                	 
 namespace DCI.Persistence.Repositories.Master.Region						                                                                    	 
 {																						                                                                	 
     public class RegionRepository : GenericRepository, IRegionRepository			                                                                     
     {																					                                                                	 
         #region Variables																                                                                	 
         private readonly RepositoryDbContext _dbContext;								                                                                	 
         #endregion																	                                                                	 
 																						                                                                	 
         #region Constructor															                                                                	 
         public RegionRepository(RepositoryDbContext dbContext) : base(dbContext)		                                                                     
         {																				                                                                	 
             _dbContext = dbContext;													                                                                	 
         }																				                                                                	 
         #endregion																	                                                                	 
 																						                                                                	 
         #region Region																                                                                	 
         public async Task<IEnumerable<RegionReadOnlyEntity>> GetRegionAsync(CancellationToken cancellationToken)                                         
         {																																	  	        	 
             return await Get<RegionReadOnlyEntity>(RepositoryConstants.GETREGION);															    	 
         }																																					 
         public async Task<IEnumerable<RegionReadOnlyEntity>> GetRegionByIdAsync(int inputparameters, CancellationToken cancellationToken)		     	 
         {																																					 
             return await GetById<int, RegionReadOnlyEntity>(inputparameters, RepositoryConstants.GETREGIONBYID);								    	 
         }																																					 
         public async Task<DBResponseEntity> SaveRegionAsync(RegionEntity inputparameters, CancellationToken cancellationToken)				        	 
         {																																					 
             return await Insert<RegionEntity, DBResponseEntity>(inputparameters, RepositoryConstants.ADDREGION);								    	 
         }																																					 
         public async Task<DBResponseEntity> UpdateRegionAsync(RegionEntity inputparameters, CancellationToken cancellationToken)				    	 
         {																																					 
             return await Update<RegionEntity, DBResponseEntity>(inputparameters, RepositoryConstants.UPDATEREGION);						    		 
         }																																	 				 
         public async Task<DBResponseEntity> DeleteRegionAsync(int inputparameters, CancellationToken cancellationToken)					    			 
         {																																					 
             return await Delete<int, DBResponseEntity>(inputparameters, RepositoryConstants.DELETEREGION);								      			 
         }																				                                                                	 
         #endregion																	                                                                	 
     }																					                                                                	 
 }																						                                                                	 