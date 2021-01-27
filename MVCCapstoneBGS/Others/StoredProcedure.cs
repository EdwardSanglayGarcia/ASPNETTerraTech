using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCapstoneBGS
{
    public enum StoredProcedureEnum
    {
        /*INDEPENDENT*/
        V_UserType, //OK
        I_UserType,
        D_UserType,
        U_UserType,

        V_EnvironmentalConcern,
        I_EnvironmentalConcern,
        D_EnvironmentalConcern,
        U_EnvironmentalConcern,

        V_UpdatedStatus,
        I_UpdatedStatus,
        D_UpdatedStatus,
        U_UpdatedStatus,

        /*DEPENDENT*/
        V_UserInformation, //OK
        I_UserInformation, // UserTypeID [DEFAULT 1], Username , Password, GivenName , MaidenName , FamilyName , Email,
        D_UserInformation,

        V_CaseReport, //OK
        I_CaseReport,
        D_CaseReport,
        U_CaseReport,

        V_Volunteer,
        I_Volunteer,
        D_Volunteer,
        U_Volunteer,

        DASHBOARD_Home,
        DASHBOARD_HomeProgress,
        DASHBOARD_HomeSubmitted,
        HOMEPAGE_Area,

        CHART_CompletedArea,
        CHART_EnvironmentalConcern,
        CHART_Status,
        CHART_Status_LW,
        CHART_OverallStatusUpdate,
        CHART_EnvironmentalConcern_MonthYear,
        CHART_OverallStatusUpdate_MonthYear,
        CHART_BetweenDates,
        CHART_DASHBOARD_AREA,

        GENERATION_AreaPerMonthYear,
        GENERATION_MonthlyTotals,

        DDL_Year,


        U_CaseReport_R,
        U_CaseReport_A,
        U_CaseReport_I,
        U_CaseReport_C,
        U_CaseReport_S,
        U_CaseReport_Finalize_R,

        V_Leaderboard_Y,
        V_Leaderboard_MY,
        V_CaseReportPhoto,
        V_CaseReportBetweenDates,

        CHART_StatusLWBetweenDates,
        CHART_OverallStatusUpdate_Year,
        CHART_StatusLWPerYear,
        GENERATION_AreaPerYear,

        V_CaseReport_IDENTITY,
        U_CaseReport_PhotoLink,
        V_CaseReportPhotoIMGUR,

        V_CheckUsername,
        V_History,
        I_History,
        Verify_UserInformation,
        VERIFY_Request_ForgotPassword,
        VERIFY_ForgotPassword,
        V_SpecificEnvironmentalConcern,
        Ban_List,
        Ban_User,
        V_AssignedConcerns,
        V_CompletedAssignedConcerns



    }

    public enum Priority {
        
    }
}