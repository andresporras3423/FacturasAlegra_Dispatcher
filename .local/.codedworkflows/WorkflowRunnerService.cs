using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Interfaces;
using UiPath.Activities.Contracts;
using FacturasAlegra_Dispatcher;

[assembly: WorkflowRunnerServiceAttribute(typeof(FacturasAlegra_Dispatcher.WorkflowRunnerService))]
namespace FacturasAlegra_Dispatcher
{
    public class WorkflowRunnerService
    {
        private readonly ICodedWorkflowServices _services;
        public WorkflowRunnerService(ICodedWorkflowServices services)
        {
            _services = services;
        }

        /// <summary>
        /// Invokes the Framework/CloseAllApplications.xaml
        /// </summary>
        /// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void CloseAllApplications(System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\CloseAllApplications.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the DownloadFile.xaml
        /// </summary>
        /// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public bool DownloadFile(string in_path, System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"DownloadFile.xaml", new Dictionary<string, object> { { "in_path", in_path } }, default, isolated, default, GetAssemblyName());
            return (bool)result["out_downloadSucess"];
        }

        /// <summary>
        /// Invokes the getfacturas.xaml
        /// </summary>
        /// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public System.Data.DataTable getfacturas(System.DateTime in_minDate, System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"getfacturas.xaml", new Dictionary<string, object> { { "in_minDate", in_minDate } }, default, isolated, default, GetAssemblyName());
            return (System.Data.DataTable)result["out_dt_fullData"];
        }

        /// <summary>
        /// Invokes the Framework/GetTransactionData.xaml
        /// </summary>
        /// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (string out_transactionRow, System.Data.DataRow out_TransactionItem, string out_TransactionField1, string out_TransactionField2, string out_TransactionID, int io_TransactionNumber, System.Data.DataTable io_dt_TransactionData) GetTransactionData(System.Collections.Generic.Dictionary<string, object> in_Config, int io_TransactionNumber, System.Data.DataTable io_dt_TransactionData, System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\GetTransactionData.xaml", new Dictionary<string, object> { { "in_Config", in_Config }, { "io_TransactionNumber", io_TransactionNumber }, { "io_dt_TransactionData", io_dt_TransactionData } }, default, isolated, default, GetAssemblyName());
            return ((string)result["out_transactionRow"], (System.Data.DataRow)result["out_TransactionItem"], (string)result["out_TransactionField1"], (string)result["out_TransactionField2"], (string)result["out_TransactionID"], (int)result["io_TransactionNumber"], (System.Data.DataTable)result["io_dt_TransactionData"]);
        }

        /// <summary>
        /// Invokes the Tests/GetTransactionDataTestCase.xaml
        /// </summary>
        /// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void GetTransactionDataTestCase(System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\GetTransactionDataTestCase.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/InitAllApplications.xaml
        /// </summary>
        /// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void InitAllApplications(System.Collections.Generic.Dictionary<string, object> in_Config, System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\InitAllApplications.xaml", new Dictionary<string, object> { { "in_Config", in_Config } }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/InitAllApplicationsTestCase.xaml
        /// </summary>
        /// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void InitAllApplicationsTestCase(System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\InitAllApplicationsTestCase.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/InitAllSettings.xaml
        /// </summary>
        /// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public System.Collections.Generic.Dictionary<string, object> InitAllSettings(string in_ConfigFile, string[] in_ConfigSheets, System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\InitAllSettings.xaml", new Dictionary<string, object> { { "in_ConfigFile", in_ConfigFile }, { "in_ConfigSheets", in_ConfigSheets } }, default, isolated, default, GetAssemblyName());
            return (System.Collections.Generic.Dictionary<string, object>)result["out_Config"];
        }

        /// <summary>
        /// Invokes the Tests/InitAllSettingsTestCase.xaml
        /// </summary>
        /// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void InitAllSettingsTestCase(System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\InitAllSettingsTestCase.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/KillAllProcesses.xaml
        /// </summary>
        /// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void KillAllProcesses(System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\KillAllProcesses.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Main.xaml
        /// </summary>
        /// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Main(string processMonth, string in_OrchestratorQueueName, string in_OrchestratorQueueFolder, System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Main.xaml", new Dictionary<string, object> { { "processMonth", processMonth }, { "in_OrchestratorQueueName", in_OrchestratorQueueName }, { "in_OrchestratorQueueFolder", in_OrchestratorQueueFolder } }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/MainTestCase.xaml
        /// </summary>
        /// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void MainTestCase(System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\MainTestCase.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/Process.xaml
        /// </summary>
        /// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Process(System.Data.DataRow in_TransactionItem, System.Collections.Generic.Dictionary<string, object> in_Config, System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\Process.xaml", new Dictionary<string, object> { { "in_TransactionItem", in_TransactionItem }, { "in_Config", in_Config } }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/ProcessTestCase.xaml
        /// </summary>
        /// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void ProcessTestCase(System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\ProcessTestCase.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/RetryCurrentTransaction.xaml
        /// </summary>
        /// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (int io_RetryNumber, int io_TransactionNumber) RetryCurrentTransaction(System.Collections.Generic.Dictionary<string, object> in_Config, System.Exception in_SystemException, bool in_QueueRetry, int io_RetryNumber, int io_TransactionNumber, System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\RetryCurrentTransaction.xaml", new Dictionary<string, object> { { "in_Config", in_Config }, { "in_SystemException", in_SystemException }, { "in_QueueRetry", in_QueueRetry }, { "io_RetryNumber", io_RetryNumber }, { "io_TransactionNumber", io_TransactionNumber } }, default, isolated, default, GetAssemblyName());
            return ((int)result["io_RetryNumber"], (int)result["io_TransactionNumber"]);
        }

        /// <summary>
        /// Invokes the Framework/SetTransactionStatus.xaml
        /// </summary>
        /// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (int io_RetryNumber, int io_TransactionNumber, int io_ConsecutiveSystemExceptions) SetTransactionStatus(UiPath.Core.BusinessRuleException in_BusinessException, string in_TransactionField1, string in_TransactionField2, string in_TransactionID, System.Exception in_SystemException, System.Collections.Generic.Dictionary<string, object> in_Config, UiPath.Core.QueueItem in_TransactionItem, int io_RetryNumber, int io_TransactionNumber, int io_ConsecutiveSystemExceptions, System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\SetTransactionStatus.xaml", new Dictionary<string, object> { { "in_BusinessException", in_BusinessException }, { "in_TransactionField1", in_TransactionField1 }, { "in_TransactionField2", in_TransactionField2 }, { "in_TransactionID", in_TransactionID }, { "in_SystemException", in_SystemException }, { "in_Config", in_Config }, { "in_TransactionItem", in_TransactionItem }, { "io_RetryNumber", io_RetryNumber }, { "io_TransactionNumber", io_TransactionNumber }, { "io_ConsecutiveSystemExceptions", io_ConsecutiveSystemExceptions } }, default, isolated, default, GetAssemblyName());
            return ((int)result["io_RetryNumber"], (int)result["io_TransactionNumber"], (int)result["io_ConsecutiveSystemExceptions"]);
        }

        /// <summary>
        /// Invokes the Framework/TakeScreenshot.xaml
        /// </summary>
        /// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public string TakeScreenshot(string in_Folder, string io_FilePath, System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\TakeScreenshot.xaml", new Dictionary<string, object> { { "in_Folder", in_Folder }, { "io_FilePath", io_FilePath } }, default, isolated, default, GetAssemblyName());
            return (string)result["io_FilePath"];
        }

        /// <summary>
        /// Invokes the Tests/WorkflowTestCaseTemplate.xaml
        /// </summary>
        /// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void WorkflowTestCaseTemplate(System.Boolean isolated = false)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\WorkflowTestCaseTemplate.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        private string GetAssemblyName()
        {
            var assemblyProvider = _services.Container.Resolve<ILibraryAssemblyProvider>();
            return assemblyProvider.GetLibraryAssemblyName(GetType().Assembly);
        }
    }
}