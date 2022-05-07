global using Serilog;
using DL;
using UI;
using System.ComponentModel;

const string connectionStringFilePath = "../../../../connections.txt";
string connectionString = File.ReadAllText(connectionStringFilePath);


//create and configure our logger
Log.Logger = new LoggerConfiguration()
    //.WriteTo.Console().MinimumLevel.Debug()
    .WriteTo.File("./Logs/user.txt").MinimumLevel.Debug().MinimumLevel.Information()// we want to save the logs in this file
    .CreateLogger();


//months.ForEach(p => Console.WriteLine(p));
//SQLDataLogic.SearchTable( connectionString, "Users", "first name", "admin");

/*for (int i = 0; i < myTable.Count; i++)
{
    Object item = myTable[i];

}
*/

bool repeat = true;
UIMenus menu = new MainMenu();

while (repeat)
{
    menu.Display();
    string ans = menu.UserChoice();

    switch (ans)
    {

        case "MainMenu":
           // Log.Debug("Displaying Main menu to the user");
          //  Log.Information("Displaying Main menu to the user");
            menu = new MainMenu();
            break;
        case "AdminView":
           // Log.Debug("Displaying Admin menu to the user");
           // Log.Information("Displaying Admin menu to the user");
            menu = new AdminView();
            break;
        case "UserView":
          //  Log.Debug("Displaying UserView menu to the user");
          //  Log.Information("Displaying UserView menu to the user");
            menu = new UserMenu();
            break;
        case "LoginMenu":
          //  Log.Debug("Displaying LoginMenu menu to the user");
           // Log.Information("Displaying LoginMenu menu to the user");
            menu = new Login();
            break;
        case "Login":
          //  Log.Debug("Displaying Login menu to the user");
          //  Log.Information("Displaying Login menu to the user");
            menu = new Login();
            break;
        case "AddUser":
          //  Log.Debug("Displaying NewUser menu to the user");
          //  Log.Information("Displaying NewUser menu to the user");
            menu = new AddUser();
            break;

        default:
            Console.WriteLine("View does not exist");
            Console.WriteLine("Please press <enter> to continue");
            Console.ReadLine();
            break;
    }
}