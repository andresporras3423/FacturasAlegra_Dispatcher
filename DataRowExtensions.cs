using System;
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

namespace FacturasAlegra_Dispatcher
{
    public static class DataRowExtensions
    {
        public static Dictionary<string, object> ToDictionary(this DataRow row)
        {
            if (row == null) throw new ArgumentNullException(nameof(row));
            if (row.Table == null) throw new InvalidOperationException("The DataRow is not associated with a DataTable.");

            return row.Table.Columns
                .Cast<DataColumn>()
                .ToDictionary(
                    col => col.ColumnName,
                    col => row[col] == DBNull.Value ? string.Empty : row[col] ?? string.Empty
                );
        }
    }
}