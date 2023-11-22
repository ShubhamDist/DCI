
 using DCI.Domain.Entities.Base;                                                                                                            
 using DCI.Domain.Entities.TravelRequest;																		                	  
 using DCI.Services.Abstractions.TravelRequest;																	                	  
 using Microsoft.AspNetCore.Mvc;																						                	  
 																														                	  
 namespace DCI.Web.Controllers.TravelRequest																	                	  
 {																														                	  
     /// <summary>																										                	  
     /// 																												                	  
     /// </summary>																									                	  
     [Route("api/[controller]")]																						                	  
     [ApiController]																									                	  
     public class TravelRequestController : BaseController																	                      
     {																													                	  
         private readonly ITravelRequestService _travelRequestService;															                      
         public TravelRequestController(ITravelRequestService travelRequestService) => _travelRequestService = travelRequestService;		                      
     																													                	  
         #region TravelRequest                                                                              					                      
         /// <summary>                                                                                   				                	  
         /// Fetch All TravelRequest                                                                             		                     	  
         /// </summary>                                                                                  				                	  
         [HttpGet]																										                	  
         public async Task<IActionResult> Get(CancellationToken cancellationToken = default)							                	  
         {																												                	  
             ResponseModel objResponse = await _travelRequestService.GetTravelRequestAsync(cancellationToken);					                      
             return await SendResponse(objResponse);																	                	  
         }																												                	  
 																														                	  
         /// <summary>                                                                                   				                	  
         /// Get TravelRequest by ID                                                                        					                      
         /// </summary>                                                                                  				                	  
         [HttpGet("{ID}")]																					    	                      
         public async Task<IActionResult> GetById(int ID, CancellationToken cancellationToken = default)				                	  
         {																												                	  
             ResponseModel objResponse = await _travelRequestService.GetTravelRequestByIdAsync(ID, cancellationToken);			                      
             return await SendResponse(objResponse);																	                	  
         }																												                	  
 																														                	  
         /// <summary>                                                                                   				                	  
         /// To Add TravelRequest                                                                          					                      
         /// </summary>                                                                                  				                	  
         [HttpPost]																									                	  
         public async Task<IActionResult> Post([FromBody] TravelRequestFormEntity inputparameters, CancellationToken cancellationToken = default)	  
         {																																	  
             ResponseModel objResponse = await _travelRequestService.SaveTravelRequestAsync(inputparameters, cancellationToken);					  
             return await SendResponse(objResponse);																						  
         }																																	  
 																																			  
         /// <summary>                                                                                   									  
         /// To Update TravelRequest                                                                      							    		  
         /// </summary>                                                                                  									  
         [HttpPut]																															  
         public async Task<IActionResult> Put([FromBody] TravelRequestFormEntity inputparameters, CancellationToken cancellationToken = default)	      
         {																																	  
             ResponseModel objResponse = await _travelRequestService.UpdateTravelRequestAsync(inputparameters, cancellationToken);				      
             return await SendResponse(objResponse);																						  
         }																																	  
 																																			  
         /// <summary>                                                                                   									  
         /// To Deactivate TravelRequest                                                                    								    	  
         /// </summary>                                                                                  									  
 																																			  
         [HttpDelete("{ID}")]																									     	   
         public async Task<IActionResult> Delete(int ID, CancellationToken cancellationToken = default)									  
         {																																	  
             ResponseModel objResponse = await _travelRequestService.DeleteTravelRequestAsync(ID, cancellationToken);							      
             return await SendResponse(objResponse);																						  
         }													     																			   
         #endregion																														  
     }																																		  
 }                                                                                                                                           