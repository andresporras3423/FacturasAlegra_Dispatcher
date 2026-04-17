using UiPath.CodedWorkflows;
using System;

namespace FacturasAlegra_Dispatcher
{
    public class GoogleDocsFactory
    {
        public GoogleDocsFactory(ICodedWorkflowsServiceContainer resolver)
        {
        }
    }

    public class DriveFactory
    {
        public UiPath.GSuite.Activities.Api.DriveConnection oscarporras02_gmail_com_s_workspace_folder_oscarporras02_gmail_com__2 { get; set; }
        public UiPath.GSuite.Activities.Api.DriveConnection Shared_oscarporras02_gmail_com__3 { get; set; }
        public UiPath.GSuite.Activities.Api.DriveConnection oscarporras02_gmail_com_s_workspace_folder_generateLink_payment_oscarporras02_gmail_com__2_3 { get; set; }

        public DriveFactory(ICodedWorkflowsServiceContainer resolver)
        {
            oscarporras02_gmail_com_s_workspace_folder_oscarporras02_gmail_com__2 = new UiPath.GSuite.Activities.Api.DriveConnection("d556852d-bb1a-4931-b5d6-18d84465b16f", resolver);
            Shared_oscarporras02_gmail_com__3 = new UiPath.GSuite.Activities.Api.DriveConnection("7eaa39ed-ec77-4d67-ad41-8d134898ca4e", resolver);
            oscarporras02_gmail_com_s_workspace_folder_generateLink_payment_oscarporras02_gmail_com__2_3 = new UiPath.GSuite.Activities.Api.DriveConnection("899e05c1-4feb-461e-8261-7016dd5e2ee5", resolver);
        }
    }

    public class GoogleFormsFactory
    {
        public GoogleFormsFactory(ICodedWorkflowsServiceContainer resolver)
        {
        }
    }

    public class GmailFactory
    {
        public UiPath.GSuite.Activities.Api.GmailConnection oscarporras02_gmail_com_s_workspace_folder_oscarporras02_gmail_com__2 { get; set; }
        public UiPath.GSuite.Activities.Api.GmailConnection oscarporras02_gmail_com_s_workspace_folder_generateLink_payment_oscarporras02_gmail_com__2_2 { get; set; }
        public UiPath.GSuite.Activities.Api.GmailConnection Shared_russiporras_gmail_com { get; set; }

        public GmailFactory(ICodedWorkflowsServiceContainer resolver)
        {
            oscarporras02_gmail_com_s_workspace_folder_oscarporras02_gmail_com__2 = new UiPath.GSuite.Activities.Api.GmailConnection("9c35a254-74dd-4464-879c-06ee7f7d89f4", resolver);
            oscarporras02_gmail_com_s_workspace_folder_generateLink_payment_oscarporras02_gmail_com__2_2 = new UiPath.GSuite.Activities.Api.GmailConnection("483fd353-9c1e-421a-901d-96d43ee3b382", resolver);
            Shared_russiporras_gmail_com = new UiPath.GSuite.Activities.Api.GmailConnection("547016aa-d57e-408c-84b7-5ea8a55cdb58", resolver);
        }
    }

    public class GoogleSheetsFactory
    {
        public UiPath.GSuite.Activities.Api.SheetsConnection oscarporras02_gmail_com_s_workspace_folder_oscarporras02_gmail_com__2 { get; set; }
        public UiPath.GSuite.Activities.Api.SheetsConnection Shared_oscarporras02_gmail_com__3 { get; set; }
        public UiPath.GSuite.Activities.Api.SheetsConnection oscarporras02_gmail_com_s_workspace_folder_generateLink_payment_oscarporras02_gmail_com__2_1 { get; set; }

        public GoogleSheetsFactory(ICodedWorkflowsServiceContainer resolver)
        {
            oscarporras02_gmail_com_s_workspace_folder_oscarporras02_gmail_com__2 = new UiPath.GSuite.Activities.Api.SheetsConnection("25b55f64-5b7d-4239-bafd-470ab50c58f3", resolver);
            Shared_oscarporras02_gmail_com__3 = new UiPath.GSuite.Activities.Api.SheetsConnection("67ef9091-e553-430e-8a7c-acf59a40126c", resolver);
            oscarporras02_gmail_com_s_workspace_folder_generateLink_payment_oscarporras02_gmail_com__2_1 = new UiPath.GSuite.Activities.Api.SheetsConnection("aa1595c8-6f2e-48b1-9791-3bc93d5ab5c4", resolver);
        }
    }

    public class GoogleTasksFactory
    {
        public GoogleTasksFactory(ICodedWorkflowsServiceContainer resolver)
        {
        }
    }

    public class GoogleWorkspaceFactory
    {
        public UiPath.GSuite.Activities.Api.WorkspaceConnection oscarporras02_gmail_com_s_workspace_folder_oscarporras02_gmail_com__2 { get; set; }
        public UiPath.GSuite.Activities.Api.WorkspaceConnection oscarporras02_gmail_com_s_workspace_folder_oscarporras02_gmail_com__3 { get; set; }
        public UiPath.GSuite.Activities.Api.WorkspaceConnection oscarporras02_gmail_com_s_workspace_folder_oscarporras02_gmail_com__4 { get; set; }

        public GoogleWorkspaceFactory(ICodedWorkflowsServiceContainer resolver)
        {
            oscarporras02_gmail_com_s_workspace_folder_oscarporras02_gmail_com__2 = new UiPath.GSuite.Activities.Api.WorkspaceConnection("66bdb834-008c-4bfc-bf17-2ce1597b20e7", resolver);
            oscarporras02_gmail_com_s_workspace_folder_oscarporras02_gmail_com__3 = new UiPath.GSuite.Activities.Api.WorkspaceConnection("cda9da0f-6922-486e-9720-f7e84c68fa14", resolver);
            oscarporras02_gmail_com_s_workspace_folder_oscarporras02_gmail_com__4 = new UiPath.GSuite.Activities.Api.WorkspaceConnection("9266407c-d9c9-4d7a-935f-eebdf3dba5c5", resolver);
        }
    }
}