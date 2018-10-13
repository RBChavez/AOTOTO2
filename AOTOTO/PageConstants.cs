
namespace AOTOTO
{
    public class PageConstants
    {

        /// Time
        public const int Delay1 = 200;
        public const int Delay2 = 300;
        public const int Delay3 = 500;
        public const int Delay4 = 700;
        public const int Delay5 = 800;
        public const int Delay6 = 900;
        public const int Delay7 = 3000;           

        /// <summary>Login page</summary>
        public const string QA_URL = "https://ehbqa2.hrsa.gov/EAuthNS//Account/SignIn";
        public const string REI_INT_URL = "https://hrsaint.reisys.com/EAuthNS//Account/SignIn";
        public const string HRSA_INT_URL = "https://ehbint.hrsa.gov/EAuthNS//Account/SignIn";
        public const string Perf_URL = "https://hrsa" + Test_Parameters.Environment + Test_Parameters.Environment_Number + ".amer.reisystems.com/2010/WebEPSInternal/Interface/Common/AccessControl/Login.aspx";
        public const string UAT_URL = "https://hrsa" + Test_Parameters.Environment + Test_Parameters.Environment_Number + ".amer.reisystems.com/2010/WebEPSInternal/Interface/Common/AccessControl/Login.aspx";
        public const string UTL_URL = "https://hrsa" + Test_Parameters.Environment + Test_Parameters.Environment_Number + "-is.amer.reisystems.com/2010/WebEPSInternal/Interface/Common/AccessControl/Login.aspx";
        public const string LoginPageTitle = "Login | HRSA EHBs";
        public const string HomeTitle = "Home";
        public const string OverlayOKButton = "btnPreLoginWarningMessageOK";
        public const string UserNameTextBox = "UserName";
        public const string PasswordTextBox = "Password";
        public const string LoginButton = "Login";
        public const string Login_ID = "Login";

        /// <summary>Activities page</summary>
        public const string Activities_ID = "activitiesTab";
        public const string XpathManageLink = "//span[text()='"+ Test_Parameters.UserRole + "']/ancestor::li/following-sibling::ul/li[text()='QC Team']/following-sibling::ul/li/a[span[text()='Manage']]";
        public const string BodyTagName = "body";
        public const string Upload_Link_Xpath = @"//li[contains(text(),'Summary Statement')/a/span[contains(text(),'Upload')]";


        /// <summary>List page</summary>
        public const string Upload_Status_Not_Started_ID = @"ctl00_ctl00_MainContent_dirContent_UploadList_OverAllStatus_i0_chk0"; 
        public const string Custom_Xpath = @"//*[@id=""DisplaySearchOptions1_contentDivImg30""]/div[1]/a[text()=' Custom']";
        public const string Arrow_Down_ID_1 = @"ctl00_ctl00_MainContent_dirContent_UploadList_DisplaySearchOptions1_DisplayOptionsComboBox0_Arrow";
        public const string Projected_Award_Start_Date_Xpath = @"//*[@id=""ctl00_ctl00_MainContent_dirContent_UploadList_DisplaySearchOptions1_DisplayOptionsComboBox0_DropDown""]/div/ul/li[text()='Projected Award Start Date']";
        public const string Arrow_Down_ID_2 = @"ctl00_ctl00_MainContent_dirContent_UploadList_DisplaySearchOptions1_SortDirectionComboBox0_Arrow";
        public const string Decending_Xpath = @"//*[@id=""ctl00_ctl00_MainContent_dirContent_UploadList_DisplaySearchOptions1_SortDirectionComboBox0_DropDown""]/div/ul/li[text()='Descending']";
        public const string Search_ID = @"btnSearch";
        public const string Exported_Applications_Xpath = @"//*[@id=""ctl00_ctl00_MainContent_dirContent_UploadList_grid_ctl84""]/thead/tr[2]/th[5]/a[text()='Exported Applications']";
        public const string Link_Upload_ID = @"ctl00_ctl00_MainContent_dirContent_UploadList_grid_ctl84_ctl04_lnkUpload";
        public const string Select_Program_ID = @"ctl00_ctl00_MainContent_dirContent_UploadList_grid_ctl84__0";
        public const string Announcement_Xpath = @"//*[@id=""ctl00_ctl00_MainContent_dirContent_UploadList_grid_ctl84__0""]/td[1]";
        public const string Arrow_Down_Button = @"ctl00_ctl00_MainContent_dirContent_UploadList_grid_ctl84_ctl02_ctl00_PageSizeComboBox_Arrow";
        public const string PageSize_100_Xpath = @"//*[@id=""ctl00_ctl00_MainContent_dirContent_UploadList_grid_ctl84_ctl02_ctl00_PageSizeComboBox_DropDown""]/div/ul/li[text()='100']";
        public const string Go_Button_ListPage_Xpath = @"//*[@id=""ctl00_ctl00_MainContent_dirContent_UploadList_grid_ctl84""]/thead/tr[1]/td/table/tbody/tr/td/div[4]/a";

        /// <summary>Upload page</summary>
        public const string TrackingNumber_Xpath = @"//*[@id=""ctl00_ctl00_MainContent_dirContent_gridSummaryStatements_grid_ctl70__0""]/td[1]";
        public const string Status_Table_ID = @"ctl00_ctl00_MainContent_dirContent_tgsSummaryOfUploadStatus_togglerBody";
        public const string Status_tglCountsSummariesSentToPo_ID = @"ctl00_ctl00_MainContent_dirContent_tgsSummaryOfUploadStatus_tglCountsSummariesSentToPo_togglerHeaderContent";
        public const string Status_CountsSummariesSkippingPoReview_ID = @"ctl00_ctl00_MainContent_dirContent_tgsSummaryOfUploadStatus_tglCountsSummariesSkippingPoReview_togglerHeaderContent";
        public const string Action_ddlActions_ID = @"ctl00_ctl00_MainContent_dirContent_drp_Action_ddlActions";
        public const string SentToPO_Xpath= @"//option[contains(text(),'Send To PO')]";
        public const string GoButton_ID = @"ctl00_ctl00_MainContent_dirContent_drp_Action_ddlGo";
        public const string Validate_1_Text = @"There are no Summary Statements uploaded yet. Please upload Summary Statements for processing.";
        public const string SkipPO_Xpath = @"//option[contains(text(),'Skip Programs Office Review')]";
        public const string MainContent_dirContent_ID= @"ctl00_ctl00_MainContent_dirContent_hlAttach";
        public const string Success_Message_Text = @"Your Request Was Processed Successfully.";

        /// <summary>Attach page</summary>
        public const string AttachFile_Button_ID = @"ctl00_ctl00_MainContent_dirContent_SSPackageAttachement_documentPurposeCodeGroups_ctl00_purposeCodeGroup_addRow_finanattach";
        public const string Browse_Button_ID = @"ctl00_ctl00_MainContent_dirContent_SSPackageAttachement_documentPurposeCodeGroups_ctl00_purposeCodeGroup_addRow_finanattach";
        public const string File_Location_ID = @"ctl00_ctl00_MainContent_dirContent_SSPackageAttachement_documentPurposeCodeGroups_ctl00_purposeCodeGroup_uploaderfile0";
        public const string Attache_Button_ID = @"ctl00_ctl00_MainContent_dirContent_SSPackageAttachement_documentPurposeCodeGroups_ctl00_purposeCodeGroup_attach";
        public const string SaveandCon_ID = @"ctl00_ctl00_MainContent_dirContent_drp_Action_ButtonRight1";

        /// <summary>Itermediet Sent To PO page</summary>
        public const string Warning_PO_Text = @"This option would send the Summary Statements to the Programs Office for review";
        public const string Cancel_PO_Button_ID = @"ctl00_ctl00_MainContent_dirContent_PageAction_ButtonLeft1";
        public const string Continue_PO_Button_ID = @"ctl00_ctl00_MainContent_dirContent_PageAction_ButtonRight1";

        /// <summary>Itermediet skip PO page</summary>
        public const string Warning_Skip_POText = @"This option would skip the Programs Office review for this Funding cycle and send the Summary Statements to the Summary Statements notification package (Create SSNP) stage.";
        public const string Cancel_SkipPO_Button_ID = @"ctl00_ctl00_MainContent_dirContent_PageAction_ButtonLeft1";
        public const string Continue_SkipPO_Button_ID = @"ctl00_ctl00_MainContent_dirContent_PageAction_ButtonRight1";

        /// <summary>Send Summary Statement to PO PO page</summary>
        public const string Confrim_Text = @"This is the confirmation page, please click appropriate button.";
        public const string ARM_User_ID = @"ctl00_ctl00_MainContent_dirContent_txtUserID";
        public const string ARM_Password_ID = @"ctl00_ctl00_MainContent_dirContent_txtPassword";
        public const string ARM_ConfrimPassword_ID = @"ctl00_ctl00_MainContent_dirContent_txtConfirmPassword";
        public const string Cancel_Confrim_ID = @"ctl00_ctl00_MainContent_dirContent_drp_Action_ButtonLeft1";
        public const string Confrim_ID = @"ctl00_ctl00_MainContent_dirContent_drp_Action_ButtonRight1";

        /// <summary>Skip Programs Office Review - Confirmation page</summary>
        public const string Note_Text = @"This option would skip the Programs Office Summary Statement review and directly send the Summary Statements to the Summary Statement Notification Package (SSNP) stage.";
        public const string Cancel_Confrim_Skip_ID = @"ctl00_ctl00_MainContent_dirContent_PageAction_ButtonLeft1";
        public const string ARM_User_Skip_ID = @"ctl00_ctl00_MainContent_dirContent_txtARMUserID";
        public const string ARM_Password_Skip_ID = @"ctl00_ctl00_MainContent_dirContent_txtARMPassword";
        public const string ARM_ConfrimPassword_Skip_ID = @"ctl00_ctl00_MainContent_dirContent_txtARMConfirmPassword";
        public const string Confrim_Skip_ID = @"ctl00_ctl00_MainContent_dirContent_PageAction_ButtonRight1";
        public const string AttachFile_SkipPO_Button_ID = @"ctl00_ctl00_MainContent_dirContent_SkipPODocuments_documentPurposeCodeGroups_ctl00_purposeCodeGroup_addRow_finanattach";
        public const string ChooseFile_SkipPO_Button_ID = @"ctl00_ctl00_MainContent_dirContent_SkipPODocuments_documentPurposeCodeGroups_ctl00_purposeCodeGroup_uploaderfile0";
        public const string Upload_Button_ID = @"ctl00_ctl00_MainContent_dirContent_SkipPODocuments_documentPurposeCodeGroups_ctl00_purposeCodeGroup_attach";
        public const string Comment_TextBox_ID = @"ctl00_ctl00_MainContent_dirContent_txtCommentsDescription_rEditorTop";
        public const string Comment_Frame_ID = @"ctl00_ctl00_MainContent_dirContent_txtCommentsDescription_rEditor_contentIframe";
        public const string Comment_Xpath = @"//html/body";
    }
}

