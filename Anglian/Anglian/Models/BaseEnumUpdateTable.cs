﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Anglian.Models
{
    class cBaseEnumUpdateTable
    {
        [PrimaryKey, AutoIncrement]
        public int IDKey { get; set; }

        /// <summary>
        /// Table Name
        /// </summary>
        [Indexed, MaxLength(60)]
        public string TableName { get; set; }

        /// <summary>
        /// Field Name
        /// </summary>
        [Indexed, MaxLength(60)]
        public string FieldName { get; set; }

        /// <summary>
        /// Last update time base enum was updated on server.
        /// </summary>        
        public DateTime LastUpdate { get; set; }
    }
}
