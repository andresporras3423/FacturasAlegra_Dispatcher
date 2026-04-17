using System;
using System.Activities;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Utils;
using System.Runtime;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using FacturasAlegra_Dispatcher.ObjectRepository;
using UiPath.Activities.System.Jobs.Coded;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Excel;
using UiPath.Excel.Activities;
using UiPath.Excel.Activities.API;
using UiPath.Excel.Activities.API.Models;
using UiPath.GSuite.Activities.Api;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.Api.Models;
using UiPath.Testing.Activities.Models;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;
using FacturasAlegra_Dispatcher;

namespace FacturasAlegra_Dispatcher
{
    [System.ComponentModel.Browsable(false)]
    public class DataRowToDictionaryActivity : System.Activities.Activity
    {
        public InArgument<System.Data.DataRow> row { get; set; }

        public DataRowToDictionaryActivity()
        {
            this.Implementation = () =>
            {
                return new DataRowToDictionaryActivityChild()
                {
                    row = (this.row == null ? (InArgument<System.Data.DataRow>)Argument.CreateReference((Argument)new InArgument<System.Data.DataRow>(), "row") : (InArgument<System.Data.DataRow>)Argument.CreateReference((Argument)this.row, "row")),
                };
            };
        }
    }

    internal class DataRowToDictionaryActivityChild : UiPath.CodedWorkflows.AsyncTaskCodedWorkflowActivity
    {
        public InArgument<System.Data.DataRow> row { get; set; }
        public System.Collections.Generic.IDictionary<string, object> newResult { get; set; }

        public DataRowToDictionaryActivityChild()
        {
            DisplayName = "DataRowToDictionary";
        }

        protected override async System.Threading.Tasks.Task<Action<AsyncCodeActivityContext>> ExecuteAsync(AsyncCodeActivityContext context, System.Threading.CancellationToken cancellationToken)
        {
            var var_row = row.Get(context);
            var codedWorkflow = new global::FacturasAlegra_Dispatcher.DataRowToDictionary();
            CodedWorkflowHelper.Initialize(codedWorkflow, new UiPath.CodedWorkflows.Utils.CodedWorkflowsFeatureChecker(new System.Collections.Generic.List<string>() { UiPath.CodedWorkflows.Utils.CodedWorkflowsFeatures.AsyncEntrypoints }), context);
            await System.Threading.Tasks.Task.Run(() => CodedWorkflowHelper.RunWithExceptionHandlingAsync(() =>
            {
                if (codedWorkflow is IBeforeAfterRun codedWorkflowWithBeforeAfter)
                {
                    codedWorkflowWithBeforeAfter.Before(new BeforeRunContext() { RelativeFilePath = "DataRowToDictionary.cs" });
                }

                return System.Threading.Tasks.Task.CompletedTask;
            }, () =>
            {
                CodedExecutionHelper.Run(() =>
                {
                    {
                        codedWorkflow.Execute(var_row);
                        newResult = new System.Collections.Generic.Dictionary<string, object>
                        {
                        };
                    }
                }, cancellationToken);
                return System.Threading.Tasks.Task.FromResult(newResult);
            }, (exception, outArgs) =>
            {
                if (codedWorkflow is IBeforeAfterRun codedWorkflowWithBeforeAfter)
                {
                    codedWorkflowWithBeforeAfter.After(new AfterRunContext() { RelativeFilePath = "DataRowToDictionary.cs", Exception = exception });
                }

                return System.Threading.Tasks.Task.CompletedTask;
            }), cancellationToken);
            return endContext =>
            {
            };
        }
    }
}