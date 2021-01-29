using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NudelnDudeln.Models;
using NudelnDudeln.Data;
using System.Reflection;

namespace NudelnDudeln.Data
{
    public static class UpdateDb
    {

        public static void SaveUpdate (Object anObj)
        {
            if (anObj == null)
            {
                throw new NullReferenceException();
            }

            // Type type = typeof(anObj);
            Type type = anObj.GetType();
            // PropertyInfo[] props = type.GetProperties();
            var modelName = type.Name;

            var table = typeof(AppDbContext).GetProperty(modelName);
            table.SetValue(table, anObj);

            try
            {
                
            }
            catch
            {
                throw;
            }
        }

    }
}
