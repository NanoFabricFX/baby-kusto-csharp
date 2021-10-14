﻿using System;
using System.Collections.Generic;

namespace KustoExecutionEngine.Core.DataSource
{
    public class TableSchema
    {
        public static readonly TableSchema Empty = new TableSchema(new List<ColumnDefinition>());

        private readonly Dictionary<string, int> _columnMap;

        public TableSchema(List<ColumnDefinition> columnDefinitions)
        {
            ColumnDefinitions = columnDefinitions;

            _columnMap = new(StringComparer.Ordinal);
            for (int i = 0; i < columnDefinitions.Count; i++)
            {
                _columnMap.Add(columnDefinitions[i].ColumnName, i);
            }
        }

        public List<ColumnDefinition> ColumnDefinitions { get; }

        public int GetColumnIndex(string columnName)
        {
            return _columnMap[columnName];
        }
    }
}
