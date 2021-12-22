using System.Data.SqlClient;

//using SqlCommand cmd = new(cmdTxt, Connection);
//using SqlDataReader reader = cmd.ExecuteReader();

//if (reader.Read())
//{
//    Console.WriteLine( reader.GetInt32(0));
//}


namespace SnackStore

{
   class Program
    {


        public static void Main(string[] args)
        {

     
            // a connection string is a somewhat standardized format to represent all credentials and options
            // needed to open a connection to some remote data source. (in the case of SQL, it will definitely
            // have a server URL, user, password, and database name at least)
            // to build from scratch, look at: either the ADO.NET documentation on SQL Server,
            // or the SQL Server documentation on ADO.NET, or... https://www.connectionstrings.com/

            // let's NOT put our connection strings on github
            string connectionString = File.ReadAllText("C:/Users/riohi/Revature/TextFile2.txt");
            // instead... some reasonable possibilities: command-line args, environment variables
            // easier for now - either a gitignored file in the project directory
            // or a file somewhere outside the git repo entirely

            using SqlConnection connection = new(connectionString);
            connection.Open();

            using (connection)
            {
                SqlCommand command = new SqlCommand(
                  "SELECT * FROM Customer; ",
                  connection);


                
                connection.Close();
                connection.Open();
                
                



                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("{0}\t{1}", reader.GetInt32(0),
                            reader.GetString(1));
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                    connection.Close();
                }
                reader.Close();
                






                Orders makingOrders = new Orders();
                int orders;
                string? names = null;
                

                Console.WriteLine("Welcome to the Classic Snack Shop");
                while (names != null)
                {



                    Console.WriteLine("Who do I have the pleasure of assisting, your name please?");
                    names = Console.ReadLine();
                }

                Console.WriteLine($" Nice to meet you {names} and which snack store will you be ordering from  1. Atlanta 2. Las Vegas  3.Williamsburg  4.Dallas");
                string?
                                // makingOrders.customerOrders();
                                StoreLocation = Console.ReadLine();

                //Console.WriteLine(" How many orders will you be placing today?");

                //use a try catch, or try parse
                bool isInt = int.TryParse(Console.ReadLine(), out orders);



                // if (!isInt || orders < 0 || orders > 500)
                if (!isInt || orders < 0 || orders > 500)


                {
                    Console.WriteLine(" please input a valid number of orders ");
                }




                Console.WriteLine("alright, please select the snack option number 1. Snickers   2. Whatchamacallits   3. Butterfingers   4.  Skittles");
                int menuSelection = Convert.ToInt32(Console.ReadLine());
                if (menuSelection == 0)
                {
                    Console.WriteLine("invalid response");
                }
                else if (menuSelection != 0)
                {


                        if (menuSelection == 1)
                    {
                        Console.WriteLine("you have selected snickers");

                        Console.WriteLine($"Thank you {names} for your {orders} orders of snickers ");
                    }
                    else if (menuSelection == 2)
                    {
                        Console.WriteLine("you have selected Whatchamacallits");
                        Console.WriteLine($"Thank you {names} for your {orders} orders of whatchamacallits ");
                    }

                    else if (menuSelection == 3)
                    {
                        Console.WriteLine("you have selected Butterfingers");
                        Console.WriteLine($"Thank you {names} for your {orders} orders of butterfingers ");
                    }

                    else if (menuSelection == 4)
                    {
                        Console.WriteLine("you have selected Skittles");
                        Console.WriteLine($"Thank you {names} for your {orders} orders of skittles ");
                    }

                    connection.Close();



                }
            }
        }
    }
}





