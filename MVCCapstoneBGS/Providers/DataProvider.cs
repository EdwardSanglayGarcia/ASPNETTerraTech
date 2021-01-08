using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;

namespace MVCCapstoneBGS
{
    using Dapper;
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;

    public class DataProvider : DataAccess, IDataProvider
    {
        

        public List<CaseReport> GetCaseReportPhoto(int CaseReportID)
        {
            var result = new List<CaseReport>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@CaseReportID", CaseReportID);
              
                result = con.Query<CaseReport>(
                    StoredProcedureEnum.V_CaseReportPhoto.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }

        #region View
        public List<UserType> GetUserType()
        {
            var result = new List<UserType>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                result = con.Query<UserType>(
                    StoredProcedureEnum.V_UserType.ToString(), commandType: CommandType.StoredProcedure).ToList();
                //Gawa ka ng Stored Procedure
            }
            return result;
        }
        public List<Volunteer> GetVolunteer()
        {
            var result = new List<Volunteer>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                result = con.Query<Volunteer>(
                    StoredProcedureEnum.V_Volunteer.ToString(), commandType: CommandType.StoredProcedure).ToList();
                //Gawa ka ng Stored Procedure
            }
            return result;
        }
        public List<EnvironmentalConcern> GetEnvironmentalConcern()
        {
            var result = new List<EnvironmentalConcern>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                result = con.Query<EnvironmentalConcern>(
                    StoredProcedureEnum.V_EnvironmentalConcern.ToString(), commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }
        public List<UpdatedStatus> GetUpdatedStatus()
        {
            var result = new List<UpdatedStatus>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                result = con.Query<UpdatedStatus>(
                    StoredProcedureEnum.V_UpdatedStatus.ToString(), commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }
        public List<CaseReport> GetCaseReport(int UpdatedStatusID)
        {
            var result = new List<CaseReport>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@UpdatedStatusID", UpdatedStatusID);
                result = con.Query<CaseReport>(
                    StoredProcedureEnum.V_CaseReport.ToString(),param, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }
        // GetStatusLWBetweenDates(int UpdatedStatusID, int EnvironmentalConcernID, DateTime StartDate, DateTime EndDate);
        public List<Records> GetStatusLWBetweenDates(int UpdatedStatusID, DateTime StartDate, DateTime EndDate)
        {
            var result = new List<Records>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@UpdatedStatusID", UpdatedStatusID);
                param.Add("@StartDate", StartDate);
                param.Add("@EndDate", EndDate);
                result = con.Query<Records>(
                    StoredProcedureEnum.CHART_StatusLWBetweenDates.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }


        public List<Records> GetStatusLWPerYear(int UpdatedStatusID, int Year)
        {
            var result = new List<Records>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@UpdatedStatusID", UpdatedStatusID);
                param.Add("@Year", Year);


                result = con.Query<Records>(
                    StoredProcedureEnum.CHART_StatusLWPerYear.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }

        public List<CaseReport> GetCaseReportBetweenDates(int UpdatedStatusID, DateTime StartDate, DateTime EndDate)
        {
            var result = new List<CaseReport>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@UpdatedStatusID", UpdatedStatusID);
                param.Add("@StartDate", StartDate);
                param.Add("@EndDate", EndDate);
                result = con.Query<CaseReport>(
                    StoredProcedureEnum.V_CaseReportBetweenDates.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }


        public List<UserInformation> GetUserInformation()
        {
            var result = new List<UserInformation>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                result = con.Query<UserInformation>(
                    StoredProcedureEnum.V_UserInformation.ToString(), commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }


        public List<Leaderboard> GetLeaderboards_Year(int UpdatedStatusID, int Year)
        {
            var result = new List<Leaderboard>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@UpdatedStatusID", UpdatedStatusID);
                param.Add("@Year", Year);
                result = con.Query<Leaderboard>(
                    StoredProcedureEnum.V_Leaderboard_Y.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }

        #endregion

        #region Insert
        public List<UserType> InsertUserType(int UserTypeID, string Description)
        {
            
            var result = new List<UserType>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@UserTypeID", UserTypeID);
                param.Add("@Description", Description);

                result = con.Query<UserType>(
                    StoredProcedureEnum.I_UserType.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }
        public List<Volunteer> InsertVolunteer(string GivenName, string MaidenName, string FamilyName)
        {
            var result = new List<Volunteer>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@GivenName", GivenName);
                param.Add("@MaidenName", MaidenName);
                param.Add("@FamilyName", FamilyName);

                result = con.Query<Volunteer>(
                    StoredProcedureEnum.I_Volunteer.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }
        public List<EnvironmentalConcern> InsertEnvironmentalConcern(int EnvironmentalConcernID, string Description)
        {
            var result = new List<EnvironmentalConcern>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@EnvironmentalConcernID", EnvironmentalConcernID);
                param.Add("@Description", Description);

                result = con.Query<EnvironmentalConcern>(
                    StoredProcedureEnum.I_EnvironmentalConcern.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }
        public List<UpdatedStatus> InsertUpdatedStatus(int UpdatedStatusID, string Description)
        {
            var result = new List<UpdatedStatus>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@UpdatedStatusID", UpdatedStatusID);
                param.Add("@Description", Description);

                result = con.Query<UpdatedStatus>(
                    StoredProcedureEnum.I_UpdatedStatus.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }
        //public List<CaseReport> InsertCaseReport(int UserInformationID, int EnvironmentalConcernID, string XCoordinates, string YCoordinates, byte[]CaseReportPhoto, string CaseLocation)
        //{

        //    var result = new List<CaseReport>();
        //    using (IDbConnection con = new SqlConnection(constring))
        //    {
        //        con.Open();
        //        var param = new DynamicParameters();
        //        param.Add("@UserInformationID", UserInformationID);
        //        param.Add("@EnvironmentalConcernID", EnvironmentalConcernID);
        //        param.Add("@XCoordinates", XCoordinates);
        //        param.Add("@YCoordinates", YCoordinates);
        //        param.Add("@CaseReportPhoto", CaseReportPhoto);
        //        param.Add("@CaseLocation", CaseLocation);

        //        for (int i = 1; i <= 100; i++)
        //        {
        //        result = con.Query<CaseReport>(
        //            StoredProcedureEnum.I_CaseReport.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
        //        }
        //    }
        //    return result;
        //}




        public List<UserInformation> InsertUserInformation(int UserTypeID, string UserName, string Password, string Email, string GivenName, string MaidenName, string FamilyName)
        ///Insert User information
        {
                var result = new List<UserInformation>();
                using (IDbConnection con = new SqlConnection(constring))
                {
                    con.Open();
                    var param = new DynamicParameters();
                    param.Add("@UserTypeID", UserTypeID);
                    param.Add("@UserName", UserName);
                    param.Add("@Password", Password);
                    param.Add("@Email", Email);
                    param.Add("@GivenName", GivenName);
                    param.Add("@MaidenName", MaidenName);
                    param.Add("@FamilyName", FamilyName);

             
                    result = con.Query<UserInformation>(
                            StoredProcedureEnum.I_UserInformation.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
              
                }
            return result;
        }

        public List<CaseReport> InsertCaseReport(CaseReport UI, HttpPostedFileBase image1)
        {
            var result = new List<CaseReport>();
            using (IDbConnection con = new SqlConnection(constring))
            {

                PriorityDictionary M = new PriorityDictionary();
                M.myString = M.myString.Select(x => x.ToUpper()).ToArray();
                if (UI.Notes == null)
                {
                    UI.Notes = "No description provided";
                }
                int hits = 0;
                foreach (string x in M.myString)
                {
                    if (UI.Notes.ToUpper().Contains(x))
                    {
                        Console.Write(x + " ");
                        hits++;
                    }
                }

                if (image1 != null)
                {
                    UI.CaseReportPhoto = new byte[image1.ContentLength];
                    image1.InputStream.Read(UI.CaseReportPhoto, 0, image1.ContentLength);
                }

                con.Open();
                var param = new DynamicParameters();
                param.Add("@UserInformationID", UI.UserInformationID);
                param.Add("@EnvironmentalConcernID", UI.EnvironmentalConcernID);
                param.Add("@XCoordinates", UI.XCoordinates);
                param.Add("@YCoordinates", UI.YCoordinates);
                param.Add("@CaseLocation", UI.CaseLocation);
                param.Add("@CaseReportPhoto", UI.CaseReportPhoto);
                param.Add("@Notes",UI.Notes);
                param.Add("@Hits",hits);


                result = con.Query<CaseReport>(
               StoredProcedureEnum.I_CaseReport.ToString(), param, commandType: CommandType.StoredProcedure).ToList();

            }
            return result;
        }

        #endregion

        #region Delete
        public List<UserType> DeleteUserType(int UserTypeID)
        {
            var result = new List<UserType>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@UserTypeID", UserTypeID);

                result = con.Query<UserType>(
                    StoredProcedureEnum.D_UserType.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }
        public List<Volunteer> DeleteVolunteer(int VolunteerID)
        {
            var result = new List<Volunteer>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@VolunteerID", VolunteerID);

                result = con.Query<Volunteer>(
                    StoredProcedureEnum.D_Volunteer.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }
        public List<EnvironmentalConcern> DeleteEnvironmentalConcern(int EnvironmentalConcernID)
        {
            var result = new List<EnvironmentalConcern>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@EnvironmentalConcernID", EnvironmentalConcernID);

                result = con.Query<EnvironmentalConcern>(
                    StoredProcedureEnum.D_EnvironmentalConcern.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }
        public List<UpdatedStatus> DeleteUpdatedStatus(int UpdatedStatusID)
        {
            var result = new List<UpdatedStatus>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@UpdatedStatusID", UpdatedStatusID);

                result = con.Query<UpdatedStatus>(
                    StoredProcedureEnum.D_UpdatedStatus.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }
        public List<CaseReport> DeleteCaseReport(int CaseReportID)
        {
            var result = new List<CaseReport>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@CaseReportID", CaseReportID);

                result = con.Query<CaseReport>(
                    StoredProcedureEnum.D_CaseReport.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }
        public List<UserInformation> DeleteUserInformation(int UserInformationID)
        {
            var result = new List<UserInformation>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@UserInformationID", UserInformationID);

                result = con.Query<UserInformation>(
                    StoredProcedureEnum.D_UserInformation.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }
        #endregion

        #region Update
        public List<UserType> UpdateUserType(int UserTypeID, string Description)
        {
            var result = new List<UserType>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@UserTypeID", UserTypeID);
                param.Add("@Description", Description);

                result = con.Query<UserType>(
                    StoredProcedureEnum.U_UserType.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }
        public List<Volunteer> UpdateVolunteer(int VolunteerID, string GivenName, string MaidenName, string FamilyName)
        {
            var result = new List<Volunteer>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@VolunteerID", VolunteerID);
                param.Add("@GivenName", GivenName);
                param.Add("@MaidenName", MaidenName);
                param.Add("@FamilyName", FamilyName);

                result = con.Query<Volunteer>(
                    StoredProcedureEnum.U_Volunteer.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }
        public List<EnvironmentalConcern> UpdateEnvironmentalConcern(int EnvironmentalConcernID, string Description)
        {
            var result = new List<EnvironmentalConcern>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@EnvironmentalConcernID", EnvironmentalConcernID);
                param.Add("@Description", Description);

                result = con.Query<EnvironmentalConcern>(
                    StoredProcedureEnum.U_EnvironmentalConcern.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }
        public List<UpdatedStatus> UpdateUpdatedStatus(int UpdatedStatusID, string Description)
        {
            var result = new List<UpdatedStatus>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@UpdatedStatusID", UpdatedStatusID);
                param.Add("@Description", Description);

                result = con.Query<UpdatedStatus>(
                    StoredProcedureEnum.U_UpdatedStatus.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }
        public List<CaseReport> UpdateCaseReport(int CaseReportID, int UpdatedStatusID)
        {
            var result = new List<CaseReport>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@CaseReportID", CaseReportID);
                param.Add("@UpdatedStatusID", UpdatedStatusID);

                result = con.Query<CaseReport>(
                    StoredProcedureEnum.U_CaseReport.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }
        public List<UserInformation> UpdateUserInformation(int UserInformationID, string GivenName, string FamilyName, string MaidenName)
        {
            var result = new List<UserInformation>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@UserInformationID", UserInformationID);
                param.Add("@GivenName", GivenName);
                param.Add("@FamilyName", FamilyName);
                param.Add("@MaidenName", MaidenName);

                result = con.Query<UserInformation>(
                    StoredProcedureEnum.U_CaseReport.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }

        //CaseReport Management
        public List<CaseReport> UpdateCaseReport_Rejected(int CaseReportID)
        {
            var result = new List<CaseReport>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@CaseReportID", CaseReportID);

                result = con.Query<CaseReport>(
                    StoredProcedureEnum.U_CaseReport_R.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }

        public List<CaseReport> UpdateCaseReport_Accepted(int CaseReportID)
        {
            var result = new List<CaseReport>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@CaseReportID", CaseReportID);

                result = con.Query<CaseReport>(
                    StoredProcedureEnum.U_CaseReport_A.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }

        public List<CaseReport> UpdateCaseReport_Completed(int CaseReportID)
        {
            var result = new List<CaseReport>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@CaseReportID", CaseReportID);

                result = con.Query<CaseReport>(
                    StoredProcedureEnum.U_CaseReport_C.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }

        public List<CaseReport> UpdateCaseReport_InProgress(int CaseReportID, int VolunteerID)
        {
            var result = new List<CaseReport>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@CaseReportID", CaseReportID);
                param.Add("@VolunteerID", VolunteerID);

                result = con.Query<CaseReport>(
                    StoredProcedureEnum.U_CaseReport_I.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }

        public List<CaseReport> UpdateCaseReport_Submitted(int CaseReportID)
        {
            var result = new List<CaseReport>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@CaseReportID", CaseReportID);

                result = con.Query<CaseReport>(
                    StoredProcedureEnum.U_CaseReport_S.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }

        public List<CaseReport> UpdateCaseReport_FinalizeRejected(int CaseReportID, string Notes)
        {
            var result = new List<CaseReport>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@CaseReportID", CaseReportID);
                param.Add("@Notes", Notes);

                result = con.Query<CaseReport>(
                    StoredProcedureEnum.U_CaseReport_Finalize_R.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }
        #endregion

        #region CHARTS_And_GRAPHS
        public void CHART_Display(string PROC, int Year,int ID, out string Number, out string Description)
        {
            //EVERYTHING BEYOND THIS LINE NEEDS TO BE CHANGED PROPERLY BY 8.2.20 5 PM

            // result = con.Query<UserInformation>(
            //   StoredProcedureEnum.U_CaseReport.ToString(), param, commandType: CommandType.StoredProcedure).ToList();

            //var query = con.Query<CHART_UserInformation>("CHART_EnvironmentalConcern", null, null, true, 0, CommandType.StoredProcedure).ToList();

            //var result = con.Query<CHART_UserInformation>(StoredProcedureEnum.CHART_EnvironmentalConcern.ToString(), commandType: CommandType.StoredProcedure).ToList();
            //  var query = con.Query<CHART_UserInformation>(StoredProcedureEnum.CHART_EnvironmentalConcern.ToString(), null, null, true, 0, CommandType.StoredProcedure).ToList();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                const string quote = "\"";
                var param = new DynamicParameters();
                param.Add("@Year", Year);

                if (PROC.ToString() == "CHART_Status" || PROC.ToString() == "CHART_Status_LW")
                {
                    param.Add("@UpdatedStatusID", ID);
                }
                if (PROC.ToString() == "CHART_EnvironmentalConcern_MonthYear" || PROC.ToString()== "CHART_OverallStatusUpdate_MonthYear")
                {
                    param.Add("@Month", ID);
                }

                var query = con.Query<CHART_MAKER>(PROC.ToString(), param, commandType: CommandType.StoredProcedure).ToList();

                var CountNumber = (from temp in query select temp.Number).ToList();

                var ConcernDescription = (from temp in query select quote + temp.Description + quote).ToList();

                Number = string.Join(",", CountNumber);
                Description = string.Join(",", ConcernDescription);
            }
        }

        

        public void CHART_DASHBOARD_DISPLAY(string PROC, out string Number, out string Description)
        {
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                const string quote = "\"";
                var param = new DynamicParameters();

                var query = con.Query<CHART_MAKER>(PROC.ToString(), param, commandType: CommandType.StoredProcedure).ToList();

                var CountNumber = (from temp in query select temp.Number).ToList();

                var ConcernDescription = (from temp in query select quote + temp.Description + quote).ToList();

                Number = string.Join(",", CountNumber);
                Description = string.Join(",", ConcernDescription);
            }
        }

        public void CHART_DisplayBetweenDates(DateTime StartDate, DateTime EndDate, int UpdatedStatusID, out string Number, out string Description)
        {
         using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                const string quote = "\"";
                var param = new DynamicParameters();
                param.Add("@StartDate", StartDate);
                param.Add("@EndDate", EndDate);
                param.Add("@UpdatedStatusID", UpdatedStatusID);

                var query = con.Query<CHART_MAKER>(StoredProcedureEnum.CHART_BetweenDates.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
                var CountNumber = (from temp in query select temp.Number).ToList();
                var ConcernDescription = (from temp in query select quote + temp.Description + quote).ToList();

                Number = string.Join(",", CountNumber);
                Description = string.Join(",", ConcernDescription);
            }
        }


        public int GetDashboard()
        {
            var result = new List<UserInformation>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                result = con.Query<UserInformation>(
                    StoredProcedureEnum.V_UserInformation.ToString(), commandType: CommandType.StoredProcedure).ToList();
            }
            var count = result.Count();
            return count;
        }
        public int GetHomeDashboard(int EnvironmentalConcernID)
        {
            var result = new List<DASHBOARD_Home>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@EnvironmentalConcernID", EnvironmentalConcernID);

                result = con.Query<DASHBOARD_Home>(
                    StoredProcedureEnum.DASHBOARD_Home.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }
            if (result.Count() == 0)
            {
                return 0;
            }
            else
                return result.Count();

        }
        public int GetHomeDashboardProgress()
        {
            var result = new List<DASHBOARD_Home>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();


                result = con.Query<DASHBOARD_Home>(
                    StoredProcedureEnum.DASHBOARD_HomeProgress.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }

            if (result.Count() == 0)
            {
                return 0;
            }
            else
            return result.Count();
        }

        public int GetHomeDashboardSubmitted()
        {
            var result = new List<DASHBOARD_Home>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();


                result = con.Query<DASHBOARD_Home>(
                    StoredProcedureEnum.DASHBOARD_HomeSubmitted.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }

            if (result.Count() == 0)
            {
                return 0;
            }
            else
                return result.Count();
        }

        public int GetAreaConcernDashboard(int Year)
        {
            var result = new List<DASHBOARD_Home>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@Year", Year);

                result = con.Query<DASHBOARD_Home>(
                    StoredProcedureEnum.CHART_CompletedArea.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }

            if (result.Count() == 0)
            {
                return 0;
            }
            else
                return result.Count();
        }
        public List<AreaDetails> GetAreaDetailsPerMonthYear(int month, int year)
        {
            var result = new List<AreaDetails>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@month", month);
                param.Add("@year", year);

                result = con.Query<AreaDetails>(
                    StoredProcedureEnum.GENERATION_AreaPerMonthYear.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }
        public List<AreaDetails> GetMonthlyTotals(int month, int year)
        {
            var result = new List<AreaDetails>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@month", month);
                param.Add("@year", year);


                result = con.Query<AreaDetails>(
                    StoredProcedureEnum.GENERATION_MonthlyTotals.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }
        #endregion

        #region DDLS
        public List<CHART_MAKER> GetYearDDL()
        {
            var result = new List<CHART_MAKER>();
            using (IDbConnection con = new SqlConnection(constring))
            {
                con.Open();
                result = con.Query<CHART_MAKER>(
                    StoredProcedureEnum.DDL_Year.ToString(), commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }
        #endregion


    }
}