
 using DCI.Domain.Entities.Base;                                                                                                                           
 using DCI.Domain.Entities.Master.City;										                                                                	 
 using DCI.Domain.Repositories.Master.City;									                                                                	 
 using DCI.Persistence.Repositories.BaseRepository;									                                                                	 
 using DCI.Persistence.Repositories.Constants;										                                                                	 
 																						                                                                	 
 namespace DCI.Persistence.Repositories.Master.City						                                                                    	 
 {																						                                                                	 
     public class CityRepository : GenericRepository, ICityRepository			                                                                     
     {																					                                                                	 
         #region Variables																                                                                	 
         private readonly RepositoryDbContext _dbContext;								                                                                	 
         #endregion																	                                                                	 
 																						                                                                	 
         #region Constructor															                                                                	 
         public CityRepository(RepositoryDbContext dbContext) : base(dbContext)		                                                                     
         {																				                                                                	 
             _dbContext = dbContext;													                                                                	 
         }																				                                                                	 
         #endregion																	                                                                	 
 																						                                                                	 
         #region City																                                                                	 
         public async Task<IEnumerable<CityReadOnlyEntity>> GetCityAsync(CancellationToken cancellationToken)                                         
         {																																	  	        	 
             return await Get<CityReadOnlyEntity>(RepositoryConstants.GETCITY);															    	 
         }																																					 
         public async Task<IEnumerable<CityReadOnlyEntity>> GetCityByIdAsync(int inputparameters, CancellationToken cancellationToken)		     	 
         {																																					 
             return await GetById<int, CityReadOnlyEntity>(inputparameters, RepositoryConstants.GETCITYBYID);								    	 
         }
        public async Task<IEnumerable<CityReadOnlyEntity>> GetCityByStateIdAsync(int inputparameters, CancellationToken cancellationToken)
        {
            return await GetById<int, CityReadOnlyEntity>(inputparameters, RepositoryConstants.GETCITYBYSTATEID);
        }
        public async Task<DBResponseEntity> SaveCityAsync(CityEntity inputparameters, CancellationToken cancellationToken)				        	 
         {																																					 
             return await Insert<CityEntity, DBResponseEntity>(inputparameters, RepositoryConstants.ADDCITY);								    	 
         }																																					 
         public async Task<DBResponseEntity> UpdateCityAsync(CityEntity inputparameters, CancellationToken cancellationToken)				    	 
         {																																					 
             return await Update<CityEntity, DBResponseEntity>(inputparameters, RepositoryConstants.UPDATECITY);						    		 
         }																																	 				 
         public async Task<DBResponseEntity> DeleteCityAsync(int inputparameters, CancellationToken cancellationToken)					    			 
         {																																					 
             return await Delete<int, DBResponseEntity>(inputparameters, RepositoryConstants.DELETECITY);								      			 
         }																				                                                                	 
         #endregion																	                                                                	 
     }																					                                                                	 
 }																						                                                                	 