global using Serilog;
using RestaurantUI;




//create and configure our logger
Log.Logger = new LoggerConfiguration()
    .WriteTo.Console().MinimumLevel.Debug()
    .WriteTo.File("./Logs/user.txt").MinimumLevel.Debug().MinimumLevel.Information()// we want to save the ;ogs in this file
    .CreateLogger();


bool repeat = true;
UIMenus menu = new RestaurantMainMenu();


while (repeat)
{
    menu.Display();
    string ans = menu.UserChoice();

    switch (ans)
    {

        case "MainMenu":
            Log.Debug("Displaying Main menu to the user");
            menu = new RestaurantMainMenu();
            break;
        case "AdminView":
            Log.Debug("Displaying Main menu to the user");
            menu = new AdminView();
            break;
        case "UserView":
            Log.Debug("Displaying Main menu to the user");
            menu = new RestaurantMainMenu();
            break;

        default:
            Console.WriteLine("View does not exist");
            Console.WriteLine("Please press <enter> to continue");
            Console.ReadLine();
            break;
    }
}
