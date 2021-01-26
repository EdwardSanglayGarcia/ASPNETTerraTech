﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MVCCapstoneBGS
{
    public interface IDataProvider
    {
        #region SESSION
        List<UserInformation> GetUserInformation();

        List<Records> GetStatusLWBetweenDates(int UpdatedStatusID, DateTime StartDate, DateTime EndDate);

        List<Records> GetStatusLWPerYear(int UpdatedStatusID, int Year);

        List<SpecificEnvironmentalConcern> GetSpecificEnvironmentalConcern(int EnvironmentalConcernID);

        #endregion

        #region View
        List<UserType> GetUserType();
        List<Volunteer> GetVolunteer();
        List<EnvironmentalConcern> GetEnvironmentalConcern();
        List<UpdatedStatus> GetUpdatedStatus();
        List<CaseReport> GetCaseReport(int UpdatedStatusID);

        List<CaseReport> GetAssignedConcerns(int VolunteerID);

        List<CaseReport> GetCaseReportBetweenDates(int UpdatedStatusID, DateTime StartDate, DateTime EndDate);

        int CheckUsername(string Username);

        List<Leaderboard> GetLeaderboards_Year(int UpdatedStatusID, int Year);
        #endregion

        #region Insert
        List<UserType> InsertUserType(int UserTypeID, string Description);

        List<Volunteer> InsertVolunteer(string GivenName, string MaidenName, string FamilyName);
        List<EnvironmentalConcern> InsertEnvironmentalConcern(int EnvironmentalConcernID, string Description);
        List<UpdatedStatus> InsertUpdatedStatus(int UpdatedStatusID, string Description);
        //List<CaseReport> InsertCaseReport(int UserInformationID, int EnvironmentalConcernID, string XCoordinates, string YCoordinates, byte[] CaseReportPhoto, string CaseLocation);
        List<UserInformation> InsertUserInformation(int UserTypeID, string UserName, string Password, string Email, string GivenName, string MaidenName, string FamilyName);

        List<History> InsertHistory(string Username, string TypeOfActivity);
        List<CaseReport> InsertCaseReport(CaseReport UI, HttpPostedFileBase image1);

        List<UserInformation> Verify_UserInformation(string VerificationCode);

        List<UserInformation> VERIFY_Request_ForgotPassword(string Email);



        List<UserInformation> VERIFY_ForgotPassword(string Email, string PasswordActivationCode, string Password);

        List<BanList> GetBanList();

        List<UserInformation> BanUser(int UserInformationID, int NoOfDays);
        #endregion

        #region Delete
        List<UserType> DeleteUserType(int UserTypeID);

        List<Volunteer> DeleteVolunteer(int VolunteerID);
        List<EnvironmentalConcern> DeleteEnvironmentalConcern(int EnvironmentalConcernID);
        List<UpdatedStatus> DeleteUpdatedStatus(int UpdatedStatusID);
        List<CaseReport> DeleteCaseReport(int CaseReportID);
        List<UserInformation> DeleteUserInformation(int UserInformationID);
        #endregion

        #region Update
        List<UserType> UpdateUserType(int UserTypeID, string Description);
        List<Volunteer> UpdateVolunteer(int VolunteerID, string GivenName, string MaidenName, string FamilyName);
        List<EnvironmentalConcern> UpdateEnvironmentalConcern(int EnvironmentalConcernID, string Description);
        List<UpdatedStatus> UpdateUpdatedStatus(int UpdatedStatusID, string Description);
        List<CaseReport> UpdateCaseReport(int CaseReportID, int UpdatedStatusID);
        List<UserInformation> UpdateUserInformation(int UserInformationID, string GivenName, string FamilyName, string MaidenName);

        //CaseReport Management
        List<CaseReport> UpdateCaseReport_Rejected(int CaseReportID);

        List<CaseReport> UpdateCaseReport_Accepted(int CaseReportID);

        List<CaseReport> UpdateCaseReport_Completed(int CaseReportID);

        List<CaseReport> UpdateCaseReport_InProgress(int CaseReportID, int VolunteerID);

        List<CaseReport> UpdateCaseReport_Submitted(int CaseReportID);

        List<CaseReport> UpdateCaseReport_FinalizeRejected(int CaseReportID, string Notes);
        #endregion

        //CHARTS
        void CHART_Display(string PROC, int Year,int ID ,out string Number, out string Description); //COMPLETETED

        //REFACTOR
        //Display Bar Chart Overall Status into the Administrator Page
        void CHART_DASHBOARD_DISPLAY(string PROC, out string Number, out string Description);

        void CHART_DisplayBetweenDates(DateTime StartDate, DateTime EndDate, int UpdatedStatusID, out string Number, out string Description); //COMPLETETED



        //DASHBOARDS
        int GetHomeDashboard(int EnvironmentalConcernID);

        int GetAreaConcernDashboard(int Year);

        List<CaseReport> GetCaseReportPhoto(int CaseReportID);

        List<CaseReport> InsertCaseReportIMGUR(int CaseReportID, string PhotoLink);

        List<CaseReport> GetCaseReportPhotoIMGUR(int CaseReportID);

        int GetHomeDashboardProgress();

        int GetHomeDashboardSubmitted();

        int GetDashboard();

        List<CaseReportIdentity> GetCaseReportIdentity();

        List<AreaDetails> GetAreaDetailsPerMonthYear(int month, int year);
        List<AreaDetails> GetAreaDetailsPerYear(int year);

        List<AreaDetails> GetMonthlyTotals(int month, int year);


        #region DDLS

        List<CHART_MAKER> GetYearDDL();

        #endregion


        //DataTables
        //     List<CaseReport> GetCommunityUserCaseReport(int UpdatedStatusID);


    }
}
