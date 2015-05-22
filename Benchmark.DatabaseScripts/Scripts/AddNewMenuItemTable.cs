using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts.Scripts
{
    public class AddNewMenuItemTable : Script
    {
        public string GetScript()
        {
            return @"IF OBJECT_ID('menu_item') IS NULL
                    CREATE TABLE menu_item(
	                    id int IDENTITY(1,1) NOT NULL,
	                    text varchar(20) NULL,
	                    href varchar(50) NULL,
	                    role varchar(10) NULL,
	                    data_toggle varchar(50) NULL,
	                    is_header bit NULL,
	                    translation_key varchar(20) NULL,
                     CONSTRAINT PK_menu_item PRIMARY KEY CLUSTERED 
                    (
	                    [id] ASC
                    )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                    ) ON [PRIMARY]
                    ";

        }
    }
}