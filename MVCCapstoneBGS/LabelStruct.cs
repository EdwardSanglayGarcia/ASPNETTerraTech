using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCapstoneBGS
{
    public struct LabelStruct
    {
        public struct Badges
        {
            public const string overallTop_1 = "https://i.imgur.com/M2yg9DO.png";
            //public const string EarthBender = "";
            //public const string EarthBender = "";
            //public const string EarthBender = "";
            //public const string EarthBender = "";
            //public const string EarthBender = "";
            //public const string EarthBender = "";
            //public const string EarthBender = "";
            //public const string EarthBender = "";
            //public const string EarthBender = "";
            //public const string EarthBender = "";
            //public const string EarthBender = "";
            //public const string EarthBender = "";
            //public const string EarthBender = "";
            //public const string EarthBender = "";
        }

        //LIST OF MESSAGES
        public struct Administrator_Message
        {
            public const string M_AdministratorHomepage = "Recent Records of Reported Concerns";
            public const string M_Submitted = "Manage Submitted Reports";
            public const string M_Accepted = "Manage Accepted Reports";
            public const string M_InProgress = "Manage In Progress Reports";
            public const string M_Completed = "Manage Completed Reports";
            public const string M_Rejected = "Manage Rejected Reports";
            public const string M_MonthlyReports = "Generate Monthly Reports of Concerns";
            public const string M_YearlyReports = "Generate Yearly Reports of Concerns";
            public const string M_Twitter = "Let other people know about the status of ";
            public const string M_Volunteers = "Manage volunteers who would complete the reports!";
        }

        public struct CommunityUser_Message
        {
            public const string M_CommunityUserHomepage = "Community User Homepage";
            public const string M_SubmitReport = "Submit an Environmental Concern!";
            public const string M_ViewStatus = "View my Reported Concerns and their status!";
          //  public const string M_Achievements = "Achievements";
        }

        //LIST OF TITLE TAGS
        public struct Administrator
        {
            public const string AdministratorHomepage = "Administrator";
            public const string Submitted = "Submitted";
            public const string Accepted = "Accepted";
            public const string InProgress = "In Progress";
            public const string Completed = "Completed";
            public const string Rejected = "Rejected";
            public const string MonthlyReports = "Monthly Reports";
            public const string YearlyReports = "Yearly Reports";
            public const string Twitter = "Twitter";
            public const string Volunteers = "Volunteers";
        }

        public struct CommunityUser
        {
            public const string CommunityUserHomepage = "Community User";
            public const string SubmitReport = "Submit Report";
            public const string ViewStatus = "View Status";
            public const string Achievements = "Achievements";
        }

        public struct Others
        {
            public const string Leaderboards = "Leaderboards";
        }


    }
}