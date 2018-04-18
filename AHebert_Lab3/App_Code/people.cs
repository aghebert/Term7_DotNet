using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace lab_3
{
    class Person
    {

        //objects
        public const string connstring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Aaron.accdb;Persist Security Info=False;";
        private string firstName;
        private string middleName;
        private string lastName;
        private string street1;
        private string street2;
        private string city;
        private string state;
        private string zip;
        private string phone;
        private string email;
        private string cell;
        private string facebookURL;

        private int personV2_ID;

        protected string feedback; //used to initiate feedback if data entered is not correct

        //Allows us to share feedback with the main program
        public string Feedback
        {
            get { return feedback; }
        }

        //get; set; accessors and mutators to change the priveleges of the variable
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                //check for bad words

                if (!Validator.BadWords(value) && !Validator.LengthNull(value) == true)
                {
                    firstName = value; //store value if it does not contain bad words
                }
                else
                {
                    feedback += "\nERROR: First Name is unnacceptable. Enter proper name."; //leave error message if it contains a bad words
                }
            }
        }
        public string MiddleName
        {
            get
            {
                return middleName;
            }
            set
            {
                if (!Validator.BadWords(value))
                {
                    middleName = value; //store value if it does not contain bad words
                }
                else
                {
                    feedback += "\nERROR: Middle Name is unnacceptable. Enter proper name."; //leave error message if it contains a bad words
                }
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (!Validator.BadWords(value) && !Validator.LengthNull(value) == true)
                {
                    lastName = value; //store value if it does not contain bad words
                }
                else
                {
                    feedback += "\nERROR: Last Name is unnacceptable. Enter proper name."; //leave error message if it contains a bad words
                }
            }
        }
        public string Street1
        {
            get
            {
                return street1;
            }
            set
            {
                if (!Validator.BadWords(value) && !Validator.LengthNull(value) == true)
                {
                    street1 = value; //store value if it does not contain bad words
                }
                else
                {
                    feedback += "\nERROR: Street 1 is unnacceptable. Enter proper name."; //leave error message if it contains a bad words
                }
            }
        }
        public string Street2
        {
            get
            {
                return street2;
            }
            set
            {
                if (!Validator.BadWords(value))
                {
                    street2 = value; //store value if it does not contain bad words
                }
                else
                {
                    feedback += "\nERROR: Street 2 is unnacceptable. Enter proper name."; //leave error message if it contains a bad words
                }
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                if (!Validator.BadWords(value) && !Validator.LengthNull(value) == true)
                {
                    city = value; //store value if it does not contain bad words
                }
                else
                {
                    feedback += "\nERROR: City Name is unnacceptable. Enter proper name."; //leave error message if it contains a bad words
                }
            }
        }
        public string State
        {
            get
            {
                return state;
            }
            set
            {
                if (!Validator.BadWords(value) && Validator.StateCorrect(value) == true)
                {
                    state = value; //store value if it does not contain bad words
                }
                else
                {
                    feedback += "\nERROR: State Name is unnacceptable. Enter proper name."; //leave error message if it contains a bad words
                }
            }
        }
        public string Zip
        {
            get
            {
                return zip;
            }
            set
            {
                if (!Validator.BadWords(value) && Validator.ZipCorrect(value) == true)
                {
                    zip = value; //store value if it does not contain bad words
                }
                else
                {
                    feedback += "\nERROR: Zip is unnacceptable. Enter proper number."; //leave error message if it contains a bad words
                }
            }
        }
        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                if (!Validator.BadWords(value) && Validator.PhoneCorrect(value) == true)
                {
                    phone = value; //store value if it does not contain bad words
                }
                else
                {
                    feedback += "\nERROR: Phone Number is unnacceptable. Enter proper number."; //leave error message if it contains a bad words
                }
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (!Validator.BadWords(value) && Validator.EmailCorrect(value) == true)
                {
                    email = value; //store value if it does not contain bad words
                }
                else
                {
                    feedback += "\nERROR: Email is unnacceptable. Enter proper email."; //leave error message if it contains a bad words
                }
            }
        }

        public string Cell
        {
            get
            {
                return cell;
            }
            set
            {
                if (!Validator.BadWords(value) && Validator.PhoneCorrect(value) == true)
                {
                    cell = value; //store value if it does not contain bad words
                }
                else
                {
                    feedback += "\nERROR: Cell Number is unnacceptable. Enter proper number."; //leave error message if it contains a bad words
                }
            }
        }

        public string FacebookURL
        {
            get
            {
                return facebookURL;
            }
            set
            {
                //check for bad words

                if (!Validator.BadWords(value) && !Validator.LengthNull(value) == true)
                {
                    facebookURL = value; //store value if it does not contain bad words
                }
                else
                {
                    feedback += "\nERROR: Facebook URL is unnacceptable. Enter proper name."; //leave error message if it contains a bad words
                }
            }
        }

        public Int32 PersonV2_ID
        {
            get
            {
                return personV2_ID;
            }
            set
            {
                if (value >= 0)
                {
                    personV2_ID = value;
                }
                else
                {
                    feedback += "\nERROR: Bad ID.";
                }
            }
        }

        public string AddRecord() // Connect to DB and add data
        {
            //Initialize string Variable
            string strResult = "";

            //Make a connection object
            SqlConnection Conn = new SqlConnection();

            //initialize its properties
            Conn.ConnectionString = ConnectDB();

            string strSQL = "INSERT INTO PersonV2 (FirstName, MiddleName, LastName, Street1, Street2, City, State, Zip, Phone, Email, Cell, FacebookURL) VALUES (@FirstName, @MiddleName, @LastName, @Street1, @Street2, @City, @State, @Zip, @Phone, @Email, @Cell, @FacebookURL)";
            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL;
            comm.Connection = Conn;

            //fill in parameters
            comm.Parameters.AddWithValue("@FirstName", FirstName);
            comm.Parameters.AddWithValue("@MiddleName", MiddleName);
            comm.Parameters.AddWithValue("@LastName", LastName);
            comm.Parameters.AddWithValue("@Street1", Street1);
            comm.Parameters.AddWithValue("@Street2", Street2);
            comm.Parameters.AddWithValue("@City", City);
            comm.Parameters.AddWithValue("@State", State);
            comm.Parameters.AddWithValue("@Zip", Zip);
            comm.Parameters.AddWithValue("@Phone", Phone);
            comm.Parameters.AddWithValue("@Email", Email);
            comm.Parameters.AddWithValue("@Cell", Cell);
            comm.Parameters.AddWithValue("@FacebookURL", FacebookURL);



            //Attempt to connect to server

            if (!Feedback.Contains("ERROR:"))
            {
                try
                {
                    Conn.Open(); //Connect to database
                    int intRecs = comm.ExecuteNonQuery();
                    strResult = $"SUCCESS: Inserted {intRecs} records.";
                    Conn.Close();                                       //close connection
                }
                catch (Exception err)                                   //if there is an error connecting, we output the error message
                {
                    strResult = "ERROR:" + err.Message;                //Set feedback to state there was an error & error info
                }
                finally
                {

                }
            }
            //return string 
            return strResult;
        }

        //Search the DB
        public DataSet SearchRecords(String strFName, String strLName)
        {
            //create a dataset to return 
            DataSet ds = new DataSet();

            //create a command for sql statement
            SqlCommand comm = new SqlCommand();

            //write a sql statement to search the database
            String strSQL = "SELECT PersonV2_ID, FirstName, MiddleName, LastName, Street1, Street2, City, State, Zip, Phone, Email, Cell, FacebookURL FROM PersonV2 WHERE 0=0";

            //Narrow down search criteria
            if (strFName.Length > 0)
            {
                strSQL += " AND FirstName LIKE @FirstName";
                comm.Parameters.AddWithValue("@FirstName", "%" + strFName + "%");
            }
            if (strLName.Length > 0)
            {
                strSQL += " AND LastName LIKE @LastName";
                comm.Parameters.AddWithValue("@LastName", "%" + strLName + "%");
            }




            //create database tools and configure them
            SqlConnection conn = new SqlConnection();
            string strConn = ConnectDB();
            conn.ConnectionString = strConn;

            //basic info
            comm.Connection = conn;     //tells it what connection to use
            comm.CommandText = strSQL;  //tell it what command to use

            //create data adapter
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;

            //Get data
            conn.Open();                //Open the connection
            da.Fill(ds, "PersonV2_person1");     //Fill the dataset with results from database
            conn.Close();               //Close the connection

            //Return the data
            return ds;
        }

        //return data found in DB
        public SqlDataReader FindRecord(int intPersonV2_ID)
        {
            //make tools
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();

            string strConn = ConnectDB();

            //get persons data
            string sqlString = "SELECT * FROM PersonV2 WHERE PersonV2_ID = @PersonV2_ID;";

            conn.ConnectionString = strConn;

            //give the comm the info it needs
            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@PersonV2_ID", intPersonV2_ID);

            conn.Open();

            //Return the dataset
            return comm.ExecuteReader();
        }

        //Delete a record
        public string DeleteRecord(int intPersonV2_ID)
        {
            Int32 intRecords = 0;
            string strResult = "";

            //initialize tools
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();

            //connect to DB
            string strConn = ConnectDB();

            //get record data
            string sqlString = "DELETE FROM PersonV2 WHERE PersonV2_ID = @PersonV2_ID;";

            //connection settings
            conn.ConnectionString = strConn;

            //give the command object info it needs
            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("PersonV2_ID", intPersonV2_ID);

            try
            {
                //open the connection
                conn.Open();

                //Run the delete and store the number of records effected
                intRecords = comm.ExecuteNonQuery();
                strResult = intRecords.ToString() + " Records Deleted.";
            }

            catch (Exception err)
            {
                strResult = "ERROR: " + err.Message; // if there is a connection failure, you'll know

            }

            finally
            {

                //close the connection
                conn.Close();
            }
            return strResult;

        }



        public string UpdateRecord()
        {
            Int32 intRecords = 0;
            string strResult = "";

            //create command string
            string strSQL = "UPDATE PersonV2 SET FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName, Street1 = @Street1, Street2 = @Street2, City = @City, State = @State, Zip = @Zip, Phone = @Phone, Email = @Email, Cell = @Cell, FacebookURL = @FacebookURL WHERE PersonV2_ID = @PersonV2_ID;";

            //create connection to db
            SqlConnection conn = new SqlConnection();

            //what where and who of the db
            string strConn = ConnectDB();
            conn.ConnectionString = strConn;

            //give command
            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL;
            comm.Connection = conn;

            //Fill in parameters
            comm.Parameters.AddWithValue("@FirstName", FirstName);
            comm.Parameters.AddWithValue("@MiddleName", MiddleName);
            comm.Parameters.AddWithValue("@LastName", LastName);
            comm.Parameters.AddWithValue("@Street1", Street1);
            comm.Parameters.AddWithValue("@Street2", Street2);
            comm.Parameters.AddWithValue("@City", City);
            comm.Parameters.AddWithValue("@State", State);
            comm.Parameters.AddWithValue("@Zip", Zip);
            comm.Parameters.AddWithValue("@Phone", Phone);
            comm.Parameters.AddWithValue("@Email", Email);
            comm.Parameters.AddWithValue("@Cell", Cell);
            comm.Parameters.AddWithValue("@FacebookURL", FacebookURL);
            comm.Parameters.AddWithValue("@PersonV2_ID", PersonV2_ID);

            try
            {
                //open connection
                conn.Open();

                //run the update
                intRecords = comm.ExecuteNonQuery();
                strResult = intRecords.ToString() + " Records Updated.";
            }
            catch (Exception err)
            {
                strResult = "ERROR: " + err.Message;
            }
            finally
            {
                //close connection
                conn.Close();
            }
            return strResult;
        }

        //Database and login information
        private string ConnectDB()
        {
            return "Server=sql.neit.edu,4500;Database=SE245_AHebert;User Id=SE245_AHebert;Password=001360214;";
        }


        //constructor for class
        public Person()
        {
            //initialize the properties
            firstName = "";
            middleName = "";
            lastName = "";
            street1 = "";
            street2 = "";
            city = "";
            state = "";
            zip = "";
            phone = "";
            email = "";
            feedback = "";
            cell = "";
            facebookURL = "";

        }
    }
}
