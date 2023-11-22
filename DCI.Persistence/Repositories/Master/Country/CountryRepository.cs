
 using DCI.Domain.Entities.Base;                                                                                                                           
 using DCI.Domain.Entities.Master.Country;										                                                                	 
 using DCI.Domain.Repositories.Master.Country;									                                                                	 
 using DCI.Persistence.Repositories.BaseRepository;									                                                                	 
 using DCI.Persistence.Repositories.Constants;										                                                                	 
 																						                                                                	 
 namespace DCI.Persistence.Repositories.Master.Country						                                                                    	 
 {																						                                                                	 
     public class CountryRepository : GenericRepository, ICountryRepository			                                                                     
     {																					                                                                	 
         #region Variables																                                                                	 
         private readonly RepositoryDbContext _dbContext;								                                                                	 
         #endregion																	                                                                	 
 																						                                                                	 
         #region Constructor															                                                                	 
         public CountryRepository(RepositoryDbContext dbContext) : base(dbContext)		                                                                     
         {																				                                                                	 
             _dbContext = dbContext;													                                                                	 
         }																				                                                                	 
         #endregion																	                                                                	 
 																						                                                                	 
         #region Country																                                                                	 
         public async Task<IEnumerable<CountryReadOnlyEntity>> GetCountryAsync(CancellationToken cancellationToken)                                         
         {																																	  	        	 
             return await Get<CountryReadOnlyEntity>(RepositoryConstants.GETCOUNTRY);															    	 
         }																																					 
         public async Task<IEnumerable<CountryReadOnlyEntity>> GetCountryByIdAsync(int inputparameters, CancellationToken cancellationToken)		     	 
         {																																					 
             return await GetById<int, CountryReadOnlyEntity>(inputparameters, RepositoryConstants.GETCOUNTRYBYID);								    	 
         }																																					 
         public async Task<DBResponseEntity> SaveCountryAsync(CountryEntity inputparameters, CancellationToken cancellationToken)				        	 
         {																																					 
             return await Insert<CountryEntity, DBResponseEntity>(inputparameters, RepositoryConstants.ADDCOUNTRY);								    	 
         }																																					 
         public async Task<DBResponseEntity> UpdateCountryAsync(CountryEntity inputparameters, CancellationToken cancellationToken)				    	 
         {																																					 
             return await Update<CountryEntity, DBResponseEntity>(inputparameters, RepositoryConstants.UPDATECOUNTRY);						    		 
         }																																	 				 
         public async Task<DBResponseEntity> DeleteCountryAsync(int inputparameters, CancellationToken cancellationToken)					    			 
         {																																					 
             return await Delete<int, DBResponseEntity>(inputparameters, RepositoryConstants.DELETECOUNTRY);								      			 
         }																				                                                                	 
         #endregion																	                                                                	 
     }																					                                                                	 
 }																						                                                                	 