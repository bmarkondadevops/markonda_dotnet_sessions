﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace BankClassLibrary.Models
{
    public interface IDbConnectionProvider
    {
        SqlConnection GetConnection();
    }
}
