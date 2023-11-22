namespace DCI.Persistence.Repositories.Constants
{
    public class RepositoryConstants
    {
        #region Officers
        //Add Update officers function
        public const string GETOFFICER = "getofficer";
        public const string ADDOFFICER = "addofficer";
        public const string ADDOFFICERADDRESS = "addaddress";
        public const string UPDATEOFFICERADDRESS = "updateaddress";
        public const string UPDATEOFFICER = "updateofficer";
        public const string DELETEOFFICER = "deleteofficer";

        #endregion

        #region Login
        public const string FUNC_GETROLEID = "func_getroleid";
        public const string SP_UPDATEIEMINUMBER = "sp_updateimeinumber";
        public const string FUNC_GETUSERDETAILFORLOGIN = "func_getuserdetailforLogin";
        public const string SP_CHANGEPASSWORD = "sp_changepassword";
        public const string FUNC_GETREFRESHTOKEN = "func_getrefreshtoken";
        public const string SP_UPDATEREFRESHTOKEN = "sp_updaterefreshtoken";
        #endregion

        #region TypeMaster
        public const string GETTYPEMASTER = "gettypemaster";
        public const string GETTYPEMASTERBYID = "gettypedetailbytymasterid";
        public const string ADDTYPEMASTER = "addtypemaster";
        public const string UPDATETYPEMASTER = "updatetypemaster";
        public const string DELETETYPEMASTER = "deletetypemaster";
        #endregion

        #region TypeDetail
        public const string GETTYPEDETAIL = "gettypedetail";
        public const string GETTYPEDETAILBYID = "gettypedetailbyid";
        public const string GETTYPEDETAILBYTYPEMASTERID = "gettypedetailbytypemasterid";
        public const string ADDTYPEDETAIL = "addtypedetail";
        public const string UPDATETYPEDETAIL = "updatetypedetail";
        public const string DELETETYPEDETAIL = "deletetypedetail";
        #endregion

        #region State
        //Add Update officers function
        public const string GETSTATE = "getstate";
        public const string GETSTATEBYID = "getstatebyid";
        public const string ADDSTATE = "addstate";
        public const string UPDATESTATE = "updatestate";
        public const string DELETESTATE = "deletestate";
        #endregion

        #region country
        //Add Update officers function
        public const string GETCOUNTRY = "getcountry";
        public const string GETCOUNTRYBYID = "getcountrybyid";
        public const string ADDCOUNTRY = "addcountry";
        public const string UPDATECOUNTRY = "updatecountry";
        public const string DELETECOUNTRY = "deletecountry";
        #endregion

        #region Region
        public const string GETREGION = "getregion";
        public const string GETREGIONBYID = "getregionbyid";
        public const string ADDREGION = "addregion";
        public const string UPDATEREGION = "updateregion";
        public const string DELETEREGION = "deleteregion";
        #endregion

        #region Station
        //Add Update officers function
        public const string GETSTATION = "getstation";
        public const string GETSTATIONBYID = "getstationbyid";
        public const string GETSTATIONBYSTATEID = "getstationbystateid";
        public const string ADDSTATION = "addstation";
        public const string UPDATESTATION = "updatestation";
        public const string DELETESTATION = "deletestation";
        #endregion

        #region SubModule
        public const string GETSUBMODULE = "getsubmodule";
        public const string GETSUBMODULEBYID = "getsubmodulebyid";
        public const string GETSUBMODULEBYMODULEID = "getsubmodulebymoduleid";
        public const string ADDSUBMODULE = "addsubmodule";
        public const string UPDATESUBMODULE = "updatesubmodule";
        public const string DELETESUBMODULE = "deletesubmodule";
        #endregion

        #region Module
        public const string GETMODULE = "getmodule";
        public const string GETMODULEBYID = "getmodulebyid";
        public const string ADDMODULE = "addmodule";
        public const string UPDATEMODULE = "updatemodule";
        public const string DELETEMODULE = "deletemodule";
        #endregion

        #region Posting
        public const string GETPOSTING = "getposting";
        public const string GETPOSTINGBYID = "getpostingbyid";
        public const string ADDPOSTING = "addposting";
        public const string UPDATEPOSTING = "updateposting";
        public const string DELETEPOSTING = "deleteposting";
        #endregion

        #region City
        public const string GETCITY = "getcity";
        public const string GETCITYBYID = "getcitybyid";
        public const string GETCITYBYSTATEID = "getcitybystateid";
        public const string ADDCITY = "addcity";
        public const string UPDATECITY = "updatecity";
        public const string DELETECITY = "deletecity";
        #endregion

        #region ECI      
        public const string GETECI = "geteci";
        public const string GETECIBYID = "getecibyid";
        public const string ADDECI = "addeci";
        public const string UPDATEECI = "updateeci";
        public const string DELETEECI = "deleteeci";
        #endregion

        #region Education      
        public const string GETEDUCATION = "geteducation";
        public const string GETEDUCATIONBYID = "geteducationbyid";
        public const string ADDEDUCATION = "addeducation";
        public const string UPDATEEDUCATION = "updateeducation";
        public const string DELETEEDUCATION = "deleteeducation";
        #endregion

        #region ACR      
        public const string GETACR = "getacr";
        public const string GETACRBYID = "getacrbyid";
        public const string ADDACR = "addacr";
        public const string UPDATEACR = "updateacr";
        public const string DELETEACR = "deleteacr";
        #endregion

        #region Role
        //Add Update officers function
        public const string GETROLE = "getrole";
        public const string GETROLEBYID = "getrolebyid";
        public const string ADDROLE = "addrole";
        public const string UPDATEROLE = "updaterole";
        public const string DELETEROLE = "deleterole";
        #endregion

        #region Screen
        //Add Update officers function
        public const string GETSCREEN = "getscreen";
        public const string GETSCREENBYID = "getscreenbyid";
        public const string ADDSCREEN = "addscreen";
        public const string UPDATESCREEN = "updatescreen";
        public const string DELETESCREEN = "deletescreen";
        #endregion

        #region Configuration
        //Add Update officers function
        public const string GETCONFIGURATION = "getconfiguration";
        public const string GETCONFIGURATIONBYID = "getconfigurationbyid";
        public const string ADDCONFIGURATION = "addconfiguration";
        public const string UPDATECONFIGURATION = "updateconfiguration";
        public const string DELETECONFIGURATION = "deleteconfiguration";
        #endregion


        #region TRAVELREQUEST

        public const string GETTRAVELREQUEST = "USP_TravelRequest";
        public const string GETTRAVELREQUESTBYID = "USP_TravelRequestByID";
        public const string ADDTRAVELREQUEST = "usp_InsertTravelRequest";
        public const string UPDATETRAVELREQUEST = "USP_UpdateTravelRequest";
        public const string DELETETRAVELREQUEST = "USP_DeleteTravelRequest";
        #endregion

    }
}
