﻿
using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts.Scripts
{
    class LinkUserRolesDropdownToOfficeAdmin : Script
    {
        public string GetScript()
        {
            return @"
                INSERT INTO [dbo].[user_type_menu_item]
                   ([user_type_id]
                   ,[menu_item_id])
                VALUES
                   (3
                   ,4)
            ";
        }
    }
}
