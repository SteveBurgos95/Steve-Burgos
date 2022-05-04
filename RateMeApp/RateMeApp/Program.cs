using DL;

const string connectionStringFilePath = "../../../../connections.txt";
string connectionString = File.ReadAllText(connectionStringFilePath);




//months.ForEach(p => Console.WriteLine(p));

List<Object> myTable = SQLDataLogic.GetTable(connectionString, "Users");

for (int i = 0; i < myTable.Count; i++)
{
    Console.WriteLine(myTable[i]);
}