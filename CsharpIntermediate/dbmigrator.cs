using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpIntermediate
{
   public class DBMigrator
    {
        private readonly Logger _logger;

        public DBMigrator(Logger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.Log("We are migrating ...");
        }
    
            //var dbMigrator = new DBMigrator(new Logger());

            //var logger = new Logger();

            //var installer = new Installer(logger);

            //dbMigrator.Migrate();
            //installer.Install();
    }
}
