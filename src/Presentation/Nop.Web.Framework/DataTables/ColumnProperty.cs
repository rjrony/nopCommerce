﻿namespace Nop.Web.Framework.DataTables
{
    /// <summary>
    /// Represent DataTables column property
    /// </summary>
    public partial class ColumnProperty
    {
        #region Properties

        /// <summary>
        /// Set the data source for the column from the rows data object / array.
        /// See also "https://datatables.net/reference/option/columns.data"
        /// </summary>
        public string Data { get; set; }

        /// <summary>
        /// Set the column title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Render (process) the data for use in the table. This property will modify the data that is used by DataTables for various operations.
        /// </summary>
        public Render Render { get; set; }

        /// <summary>
        /// Column width assignment. This parameter can be used to define the width of a column, and may take any CSS value (3em, 20px etc).
        /// </summary>
        public string Width { get; set; }

        /// <summary>
        /// Column autowidth assignment. This can be disabled as an optimisation (it takes a finite amount of time to calculate the widths) if the tables widths are passed in using "width".
        /// </summary>
        public bool AutoWidth { get; set; }

        /// <summary>
        /// Indicate whether the column is master check box
        /// </summary>
        public bool IsMasterCheckBox { get; set; }

        #endregion
    }
}