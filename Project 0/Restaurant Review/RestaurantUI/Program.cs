global using Serilog;
using RestaurantUI;
using RestaurantDL;
using RestaurantBL;


string connectionStringFilePath = "../../../../sensitive.txt";
string connectionString = File.ReadAllText(connectionStringFilePath);

//create and configure our logger
Log.Logger = new LoggerConfiguration()
    //.WriteTo.Console().MinimumLevel.Debug()
    .WriteTo.File("./Logs/user.txt").MinimumLevel.Debug().MinimumLevel.Information()// we want to save the logs in this file
    .CreateLogger();

IRepository repository = new SqlRepository(connectionString);
IRestaurant logic = new Restaurant(repository);
//PokemonOperations operations = new(repository);

bool repeat = true;
UIMenus menu = new LoginMenu();


while (repeat)
{
    menu.Display();
    string ans = menu.UserChoice();

    switch (ans)
    {

        case "MainMenu":
            Log.Debug("Displaying Main menu to the user");
            Log.Information("Displaying Main menu to the user");
            menu = new RestaurantMainMenu();
            break;
        case "AdminView":
            Log.Debug("Displaying Admin menu to the user");
            Log.Information("Displaying Admin menu to the user");
            menu = new AdminView();
            break;
        case "UserView":
            Log.Debug("Displaying UserView menu to the user");
            Log.Information("Displaying UserView menu to the user");
            menu = new UserView();
            break;
        case "LoginMenu":
            Log.Debug("Displaying LoginMenu menu to the user");
            Log.Information("Displaying LoginMenu menu to the user");
            menu = new LoginMenu();
            break;
        case "Login":
            Log.Debug("Displaying Login menu to the user");
            Log.Information("Displaying Login menu to the user");
            menu = new Login();
            break;
        case "NewUser":
            Log.Debug("Displaying NewUser menu to the user");
            Log.Information("Displaying NewUser menu to the user");
            menu = new NewUser();
            break;
        case "AddReview":
            Log.Debug("Displaying AddReview menu to the user");
            Log.Information("Displaying AddReview menu to the user");
            menu = new AddReviewView(repository);
            break;

        default:
            Console.WriteLine("View does not exist");
            Console.WriteLine("Please press <enter> to continue");
            Console.ReadLine();
            break;
    }
}
