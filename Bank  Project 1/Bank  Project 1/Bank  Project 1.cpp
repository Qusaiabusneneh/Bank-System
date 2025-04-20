#include <iostream>
#include <fstream>
#include <string>
#include <vector>
#include <iomanip>

using namespace std;

const string ClientsFileName = "Clients.txt";
const string UsersFileName = "Users.txt";

enum enMainMenueOptions
{
    eListClients = 1, eAddNewClient = 2,
    eDeleteClient = 3, eUpdateClient = 4,
    eFindClient = 5, eTransactions = 6,
    eManageUsers = 7, eLogin = 8
};

enum enTransactionMenueOption
{
    eDeposit = 1, eWithdraw = 2,
    eTotalBalance = 3, eMainMenue = 4
};

enum enManageUser
{
    eListUser = 1, eAddUser = 2, eDeleteUser = 3,
    eUpdateUser = 4, eFindUser = 5, MainMenue = 6
};

enum enMainMenuePermissions
{
    eAll = -1, pListClients = 1, pAddNewClient = 2, pDeleteClient = 4,
    pUpdateClient = 8, pFindClient = 16, pTransaction = 32, pManageUser = 64
};

void ShowMainMenue();
void TransactionMenueScreen();
void LoginScreen();
void ManageUsersMenueScreen();
bool CheckAccessPermission(enMainMenuePermissions Permission);

struct sClient
{
    string AccountNumber;
    string PinCode;
    string Name;
    string Phone;
    double AccountBalance;
    bool MarkForDelete = false;
};

struct stUser
{
    string UserName;
    string Password;
    short Permissions;
    bool MarkForDelete = false;
};

stUser CurrentUser;

vector<string> SplitString(string S1, string Delim)
{
    vector<string> vString;
    short pos = 0;
    string sWord;

  
    while ((pos = S1.find(Delim)) != std::string::npos)
    {
        sWord = S1.substr(0, pos);
        if (sWord != "")
        {
            vString.push_back(sWord);
        }

        S1.erase(0, pos + Delim.length());  
    }

    if (S1 != "")
    {
        vString.push_back(S1); 
    }

    return vString;

}

sClient ConvertLinetoRecord(string Line, string Seperator = "#//#")
{
    sClient Client;
    vector<string> vClientData;
    vClientData = SplitString(Line, Seperator);

    Client.AccountNumber = vClientData[0];
    Client.PinCode = vClientData[1];
    Client.Name = vClientData[2];
    Client.Phone = vClientData[3];
    Client.AccountBalance = stod(vClientData[4]);
    return Client;
}

string ConvertRecordToLine(sClient Client, string Seperator = "#//#")
{

    string stClientRecord = "";
    stClientRecord += Client.AccountNumber + Seperator;
    stClientRecord += Client.PinCode + Seperator;
    stClientRecord += Client.Name + Seperator;
    stClientRecord += Client.Phone + Seperator;
    stClientRecord += to_string(Client.AccountBalance);
    return stClientRecord;
}

stUser ConvertLineToRecord(string Text, string Delimiter = "#//#")
{
    stUser User;
    vector<string>vText = SplitString(Text, Delimiter);
    User.UserName = vText[0];
    User.Password = vText[1];
    User.Permissions=stoi(vText[2]);
    return User;
}

string ConvertRecordToLine(stUser User, string Delimiter = "#//#")
{
    string stUserRecord = "";
    stUserRecord+=User.UserName+Delimiter;
    stUserRecord += User.Password + Delimiter;
    stUserRecord += to_string(User.Permissions);
    return stUserRecord;
}

bool ClientExistsByAccountNumber(string AccountNumber, string FileName)
{

    vector <sClient> vClients;
    fstream MyFile;
    MyFile.open(FileName, ios::in);//read Mode

    if (MyFile.is_open())
    {
        string Line;
        sClient Client;

        while (getline(MyFile, Line))
        {
            Client = ConvertLinetoRecord(Line);
            if (Client.AccountNumber == AccountNumber)
            {
                MyFile.close();
                return true;
            }
            vClients.push_back(Client);
        }

        MyFile.close();

    }
    return false;
}

bool UserExistByUserName(string FileName, string Username)
{
    fstream MyFile;
    MyFile.open(FileName, ios::in);
    if (MyFile.is_open())
    {
        stUser User;
        string Line;
        while (getline(MyFile, Line))
        {
            User = ConvertLineToRecord(Line);
            if (User.UserName == Username)
            {
                MyFile.close();
                return true;
            }
        }
        MyFile.close();
    }
    return false;
}

sClient ReadNewClient()
{
    sClient Client;
    cout << "Enter Account Number? ";
    getline(cin >> ws, Client.AccountNumber);

    while (ClientExistsByAccountNumber(Client.AccountNumber, ClientsFileName))
    {
        cout << "\nClient with [" << Client.AccountNumber << "] already exists, Enter another Account Number? ";
        getline(cin >> ws, Client.AccountNumber);
    }

    cout << "Enter PinCode? ";
    getline(cin, Client.PinCode);

    cout << "Enter Name? ";
    getline(cin, Client.Name);

    cout << "Enter Phone? ";
    getline(cin, Client.Phone);

    cout << "Enter AccountBalance? ";
    cin >> Client.AccountBalance;

    return Client;
}

int ReadPermissionsToSet()
{
    int Permissions = 0;
    char Answer = 'Y';

    cout << "\ndo you want to give full access? y/n ?";
    cin >> Answer;
    if (toupper(Answer) == 'Y')
    {
        return -1;
    }
    cout << "\nDo you want ti give access to : \n";

    cout << "\nShow Client List? y/n?";
    cin >> Answer;
    if (toupper(Answer) == 'Y')
        Permissions += enMainMenuePermissions::pListClients;
    
    cout << "\nAdd New Client? y/n/";
    cin >> Answer;
    if (toupper(Answer) == 'Y')
        Permissions += enMainMenuePermissions::pAddNewClient;

    cout << "\nDelete Client? y/n?";
    cin >> Answer;
    if (toupper(Answer) == 'Y')
        Permissions += enMainMenuePermissions::pDeleteClient;

    cout << "\nUpdate Client? y/n?";
    cin >> Answer;
    if (toupper(Answer) == 'Y')
        Permissions += enMainMenuePermissions::pUpdateClient;

    cout << "\nFind Client? y/n?";
    cin >> Answer;
    if (toupper(Answer) == 'Y')
        Permissions += enMainMenuePermissions::pFindClient;

    cout << "\nTransactions? y/n?";
    cin >> Answer;
    if (toupper(Answer) == 'Y')
        Permissions += enMainMenuePermissions::pTransaction;

    cout << "\nManage User? y/n?";
    cin >> Answer;
    if (toupper(Answer) == 'Y')
        Permissions += enMainMenuePermissions::pManageUser;

    return Permissions;
    
}

stUser ReadNewUser()
{
    stUser User;
    cout << "Enter Username ?";
    getline(cin >> ws, User.UserName);

    while (UserExistByUserName(UsersFileName, User.UserName))
    {
        cout << "\nUser with ["<<User.UserName<<"] already exists , Enter another Usernmae?" << endl;
        getline(cin >> ws, User.UserName);
    }

    cout << "\nEnter Password ?";
    getline(cin >> ws, User.Password);

    User.Permissions = ReadPermissionsToSet();

    return User;
}

vector <sClient> LoadCleintsDataFromFile(string FileName)
{
    vector <sClient> vClients;
    fstream MyFile;
    MyFile.open(FileName, ios::in);//read Mode

    if (MyFile.is_open())
    {
        string Line;
        sClient Client;

        while (getline(MyFile, Line))
        {
            Client = ConvertLinetoRecord(Line);
            vClients.push_back(Client);
        }
        MyFile.close();
    }
    return vClients;
}

vector<stUser>LoadUserDataFromFile(string FileName)
{
    vector<stUser>vUser;
    fstream MyFile;
    MyFile.open(FileName, ios::in);
    if (MyFile.is_open())
    {
        string Line;
        stUser User;
        while (getline(MyFile, Line))
        {
            User = ConvertLineToRecord(Line);
            vUser.push_back(User);
        }
        MyFile.close();
    }
    return vUser;
}

void PrintClientRecordLine(sClient Client)
{
    cout << "| " << setw(15) << left << Client.AccountNumber;
    cout << "| " << setw(10) << left << Client.PinCode;
    cout << "| " << setw(40) << left << Client.Name;
    cout << "| " << setw(12) << left << Client.Phone;
    cout << "| " << setw(12) << left << Client.AccountBalance;
}

void PrintUserRecordLine(stUser User)
{
    cout << "| " << setw(15) << left << User.UserName;
    cout << "| " << setw(40) << left << User.Password;
    cout << "| " << setw(12) << left << User.Permissions;
}

void ShowAccessDeniedMessage()
{
    cout << "\n_______________________________________________________\n";
    cout << "Access Denied, \nYou dont Have Permission To Do this, \nPlease Conact Your Admin.";
    cout << "\n_______________________________________________________\n";
}

void ShowAllClientsScreen()
{
    if (!CheckAccessPermission(enMainMenuePermissions::pListClients))
    {
        ShowAccessDeniedMessage();
        return;
    }

    vector <sClient> vClients = LoadCleintsDataFromFile(ClientsFileName);

    cout << "\n\t\t\t\t\tClient List (" << vClients.size() << ") Client(s).";
    cout << "\n_______________________________________________________";
    cout << "_________________________________________\n" << endl;

    cout << "| " << left << setw(15) << "Accout Number";
    cout << "| " << left << setw(10) << "Pin Code";
    cout << "| " << left << setw(40) << "Client Name";
    cout << "| " << left << setw(12) << "Phone";
    cout << "| " << left << setw(12) << "Balance";
    cout << "\n_______________________________________________________";
    cout << "_________________________________________\n" << endl;

    if (vClients.size() == 0)
        cout << "\t\t\t\tNo Clients Available In the System!";
    else

        for (sClient Client : vClients)
        {

            PrintClientRecordLine(Client);
            cout << endl;
        }

    cout << "\n_______________________________________________________";
    cout << "_________________________________________\n" << endl;
}

void ShowAllUsersScreen()
{
    vector<stUser>vUser = LoadUserDataFromFile(UsersFileName);
    cout << "\n\t\t\t\t\tClient List (" << vUser.size() << ") Client(s).";
    cout << "\n_______________________________________________________";
    cout << "_________________________________________\n" << endl;
    cout << "| " << left << setw(15) << "Username";
    cout << "| " << left << setw(40) << "Password";
    cout << "| " << left << setw(12) << "Permission";
    cout << "\n_______________________________________________________";
    cout << "_________________________________________\n" << endl;
    if (vUser.size() == 0)
        cout << "\t\t\t\tNo Users Available In the System!";
    else
    {
        for (stUser counter : vUser)
        {
            PrintUserRecordLine(counter);
            cout << endl;
        }
    }
    cout << "\n_______________________________________________________";
    cout << "_________________________________________\n" << endl;
}

void PrintClientCard(sClient Client)
{
    cout << "\nThe following are the client details:\n";
    cout << "-----------------------------------";
    cout << "\nAccout Number: " << Client.AccountNumber;
    cout << "\nPin Code     : " << Client.PinCode;
    cout << "\nName         : " << Client.Name;
    cout << "\nPhone        : " << Client.Phone;
    cout << "\nAccount Balance: "<<Client.AccountBalance;
    cout << "\n-----------------------------------\n";
}

void PrintUserCard(stUser User)
{
    cout << "\nThe following are the user details:\n";
    cout << "-----------------------------------";
    cout << "\nUsername    :" << User.UserName;
    cout << "\nPassword    :" << User.Password << endl;
    cout << "Permission    :" << User.Permissions << endl;
    cout << "\n-----------------------------------\n";
}

bool FindClientByAccountNumber(string AccountNumber, vector <sClient> vClients, sClient& Client)
{
    for (sClient C : vClients)
    {

        if (C.AccountNumber == AccountNumber)
        {
            Client = C;
            return true;
        }

    }
    return false;
}

bool FindUserByUsername(string Username, vector<stUser>vUser, stUser& User)
{
    for (stUser counter : vUser)
    {
        if (counter.UserName == Username)
        {
            User = counter;
            return true;
        }

    }
    return false;
}

bool FindUserByUsernameAndPassword( string Username,string Password, stUser& User)
{
    vector<stUser>vUser = LoadUserDataFromFile(UsersFileName);

    for (stUser counter : vUser)
    {
        if (counter.UserName == Username && counter.Password == Password)
        {
            User = counter;
            return true;
        }
    }
    return false;
}

sClient ChangeClientRecord(string AccountNumber)
{
    sClient Client;

    Client.AccountNumber = AccountNumber;

    cout << "\n\nEnter PinCode? ";
    getline(cin >> ws, Client.PinCode);

    cout << "Enter Name? ";
    getline(cin, Client.Name);

    cout << "Enter Phone? ";
    getline(cin, Client.Phone);

    cout << "Enter AccountBalance? ";
    cin >> Client.AccountBalance;
    return Client;
}

stUser ChangeUserRecord(string Username)
{
    stUser User;
    User.UserName = Username;

    cout << "Enter Password?";
    getline(cin >> ws, User.Password);

    User.Permissions=ReadPermissionsToSet();

    return User;
}

bool MarkClientForDeleteByAccountNumber(string AccountNumber, vector <sClient>& vClients)
{

    for (sClient& C : vClients)
    {

        if (C.AccountNumber == AccountNumber)
        {
            C.MarkForDelete = true;
            return true;
        }

    }

    return false;
}

bool MarkUserForDeleteByUserName(string Username, vector<stUser>&vUser)
{
    for (stUser& counter : vUser)
    {
        if (counter.UserName == Username)
        {
            counter.MarkForDelete = true;
            return true;
        }
    }
    return false;
}

vector <sClient> SaveCleintsDataToFile(string FileName, vector <sClient> vClients)
{
    fstream MyFile;
    MyFile.open(FileName, ios::out);//overwrite

    string DataLine;

    if (MyFile.is_open())
    {
        for (sClient C : vClients)
        {
            if (C.MarkForDelete == false)
            {
                DataLine = ConvertRecordToLine(C);
                MyFile << DataLine << endl;
            }

        }

        MyFile.close();
    }

    return vClients;
}

vector<stUser>SaveUsersDataToFile(string FileName, vector<stUser>vUser)
{
    fstream MyFile;
    MyFile.open(FileName, ios::out);
    string DataLine;
    if (MyFile.is_open())
    {
        for (stUser counter : vUser)
        {
            if (counter.MarkForDelete == false)
            {
                DataLine = ConvertRecordToLine(counter);
                MyFile << DataLine << endl;
            }
        }
        MyFile.close();
    }
    return vUser;
}

void AddDataLineToFile(string FileName, string  stDataLine)
{
    fstream MyFile;
    MyFile.open(FileName, ios::out | ios::app);

    if (MyFile.is_open())
    {
        MyFile << stDataLine << endl;
        MyFile.close();
    }
}

void AddNewClient()
{
    sClient Client;
    Client = ReadNewClient();
    AddDataLineToFile(ClientsFileName, ConvertRecordToLine(Client));
}

void AddNewUser()
{
    stUser User;
    User = ReadNewUser();
    AddDataLineToFile(UsersFileName, ConvertRecordToLine(User));
}

void AddNewUsers()
{
    stUser User;
    char AddMore = 'Y';
    do
    {
        cout << "Adding New User: \n\n";
        AddNewUser();
        cout << "\nUser Added Successfully, do you want to add more ?Y/N?";
        cin >> AddMore;
    } while (toupper(AddMore) == 'Y');
}

void AddNewClients()
{
    char AddMore = 'Y';
    do
    {
        cout << "Adding New Client:\n\n";

        AddNewClient();
        cout << "\nClient Added Successfully, do you want to add more clients? Y/N? ";
        cin >> AddMore;

    } while (toupper(AddMore) == 'Y');

}

bool DeleteClientByAccountNumber(string AccountNumber, vector <sClient>& vClients)
{
    sClient Client;
    char Answer = 'n';

    if (FindClientByAccountNumber(AccountNumber, vClients, Client))
    {

        PrintClientCard(Client);

        cout << "\n\nAre you sure you want delete this client? y/n ? ";
        cin >> Answer;
        if (Answer == 'y' || Answer == 'Y')
        {
            MarkClientForDeleteByAccountNumber(AccountNumber, vClients);
            SaveCleintsDataToFile(ClientsFileName, vClients);

            //Refresh Clients 
            vClients = LoadCleintsDataFromFile(ClientsFileName);

            cout << "\n\nClient Deleted Successfully.";
            return true;
        }

    }
    else
    {
        cout << "\nClient with Account Number (" << AccountNumber << ") is Not Found!";
        return false;
    }
}

bool DeleteUserByUsername(string Username, vector<stUser>& vUser)
{
    if (Username == "Admin")
    {
        cout << "\n\nYou can't Delete This User.";
        return false;
    }

    stUser User;
    char Answer = 'Y';
    if (FindUserByUsername(Username,vUser,User))
    {
        PrintUserCard(User);
        cout << "\n\nAre you sure want to delete this User?y/n ?";
        cin >> Answer;
        if (toupper(Answer) == 'Y')
        {
            MarkUserForDeleteByUserName(Username,vUser);
            SaveUsersDataToFile(UsersFileName, vUser);

            vUser = LoadUserDataFromFile(UsersFileName);

            cout << "\n\nUser Deleted Successfully.";
            return true;
        }
    }
    else
    {
        cout << "\nUser with Username (" << Username << ")is NOT Found!";
        return false;
    }
}

bool UpdateClientByAccountNumber(string AccountNumber, vector <sClient>& vClients)
{

    sClient Client;
    char Answer = 'n';

    if (FindClientByAccountNumber(AccountNumber, vClients, Client))
    {

        PrintClientCard(Client);
        cout << "\n\nAre you sure you want update this client? y/n ? ";
        cin >> Answer;
        if (Answer == 'y' || Answer == 'Y')
        {
            for (sClient& C : vClients)
            {
                if (C.AccountNumber == AccountNumber)
                {
                    C = ChangeClientRecord(AccountNumber);
                    break;
                }
            }

            SaveCleintsDataToFile(ClientsFileName, vClients);

            cout << "\n\nClient Updated Successfully.";
            return true;
        }

    }
    else
    {
        cout << "\nClient with Account Number (" << AccountNumber << ") is Not Found!";
        return false;
    }
}

bool UpdateUserByUserName(string Username, vector<stUser>& vUser)
{
    stUser User;
    char Answer = 'Y';
    if (FindUserByUsername(Username,vUser, User))
    {
        PrintUserCard(User);
        cout << "\n\nAre you sure ypu want update this User? y/n ?";
        cin >> Answer;
        if (toupper(Answer) == 'Y')
        {
            for (stUser& counter : vUser)
            {
                if (counter.UserName == Username)
                {
                    counter = ChangeUserRecord(Username);
                    break;
                }
            }
            SaveUsersDataToFile(UsersFileName, vUser);
            cout << "\n\nUser Updated Successfully.";
            return true;
        }
    }
    else
    {
        cout << "\nUser with Username(" << Username << ") is NOT found!";
        return false;
    }
}

string ReadClientAccountNumber()
{
    string AccountNumber = "";

    cout << "\nPlease enter AccountNumber? ";
    cin >> AccountNumber;
    return AccountNumber;

}

string ReadUsername()
{
    string Username = "";
    cout << "Please Enter Username?" << endl;
    cin >> Username;
    return Username;
}

void ShowDeleteClientScreen()
{

    if (!CheckAccessPermission(enMainMenuePermissions::pDeleteClient))
    {
        ShowAccessDeniedMessage();
        return;
    }
    cout << "\n-----------------------------------\n";
    cout << "\tDelete Client Screen";
    cout << "\n-----------------------------------\n";

    vector <sClient> vClients = LoadCleintsDataFromFile(ClientsFileName);
    string AccountNumber = ReadClientAccountNumber();
    DeleteClientByAccountNumber(AccountNumber, vClients);
}

void ShowDeleteUserScreen()
{
    cout << "\n-----------------------------------\n";
    cout << "\tDelete User Screen";
    cout << "\n-----------------------------------\n";

    vector<stUser>vUser = LoadUserDataFromFile(UsersFileName);
    string Username = ReadUsername();
    DeleteUserByUsername(Username,vUser);
}

void ShowUpdateClientScreen()
{
    if (!CheckAccessPermission(enMainMenuePermissions::pUpdateClient))
    {
        ShowAccessDeniedMessage();
        return;
    }

    cout << "\n-----------------------------------\n";
    cout << "\tUpdate Client Info Screen";
    cout << "\n-----------------------------------\n";

    vector <sClient> vClients = LoadCleintsDataFromFile(ClientsFileName);
    string AccountNumber = ReadClientAccountNumber();
    UpdateClientByAccountNumber(AccountNumber, vClients);

}

void ShowUpdateUserScreen()
{
    cout << "\n-----------------------------------\n";
    cout << "\tUpdate User Info Screen";
    cout << "\n-----------------------------------\n";
    vector<stUser>vUser = LoadUserDataFromFile(UsersFileName);
    string Username = ReadUsername();
    UpdateUserByUserName(Username,vUser);
}

void ShowAddNewClientsScreen()
{
    if (!CheckAccessPermission(enMainMenuePermissions::pAddNewClient))
    {
        ShowAccessDeniedMessage();
        return;
    }

    cout << "\n-----------------------------------\n";
    cout << "\tAdd New Clients Screen";
    cout << "\n-----------------------------------\n";

    AddNewClients();
}

void ShowAddNewUsersScreen()
{
    cout << "\n-----------------------------------\n";
    cout << "\tAdd New Users Screen";
    cout << "\n-----------------------------------\n";
    AddNewUsers();
}

void ShowFindClientScreen()
{
    if (!CheckAccessPermission(enMainMenuePermissions::pFindClient))
    {
        ShowAccessDeniedMessage();
        return;
    }

    cout << "\n-----------------------------------\n";
    cout << "\tFind Client Screen";
    cout << "\n-----------------------------------\n";

    vector <sClient> vClients = LoadCleintsDataFromFile(ClientsFileName);
    sClient Client;
    string AccountNumber = ReadClientAccountNumber();
    if (FindClientByAccountNumber(AccountNumber, vClients, Client))
        PrintClientCard(Client);
    else
        cout << "\nClient with Account Number[" << AccountNumber << "] is not found!";
}

void ShowFindUserScreen()
{
    cout << "\n-----------------------------------\n";
    cout << "\tFind User Screen";
    cout << "\n-----------------------------------\n";

    vector<stUser>vUser = LoadUserDataFromFile(UsersFileName);
    stUser User;
    string Username = ReadUsername();
    if (FindUserByUsername(Username,vUser,User))
        PrintUserCard(User);
    else
        cout << "\nUser with Username[" << Username << "] is NOT Found!";
}

bool CheckAccessPermission(enMainMenuePermissions Permission)
{
    if (CurrentUser.Permissions == enMainMenuePermissions::eAll)
        return true;
    if ((Permission & CurrentUser.Permissions) == Permission)
        return true;
    else
        return false;
}

void GoBackToMainMenue()
{
    cout << "\n\nPress any key to go back to Main Menue...";
    system("pause>0");
    ShowMainMenue();

}

short ReadMainMenueOption()
{
    short Choice = 0;
    do
    {
        cout << "Choose what do you want to do? [1 to 8]? ";
        cin >> Choice;
    } while (Choice < 1 || Choice>8);

    return Choice;
}

double ReadDepositAmount(string Message)
{
    double DepositAmount;
    cout << Message;
    cin >> DepositAmount;
    return DepositAmount;
}

bool DepositBalanceToClientByAccountNumber(vector<sClient>& vClinet,double Amount,string stAccountNumber)
{
    char Letter;
    cout << "\n\nAre you sure you want perform this transaction? y/n ?";
    cin >> Letter;
    if (toupper(Letter) == 'Y')
    {
        for (sClient& counter : vClinet)
        {
            if (counter.AccountNumber == stAccountNumber)
            {
                counter.AccountBalance += Amount;
                SaveCleintsDataToFile(ClientsFileName, vClinet);
                cout << "\n\nDone Successfully,New balance is : "<<counter.AccountBalance << endl;
                return true;
            }
        }
    }
    return false;
}

void ShowDepositScreen()
{
    cout << "---------------------------------------" << endl;
    cout << "\tDeposit Screen" << endl;
    cout << "---------------------------------------" << endl;
    sClient Client;
    vector<sClient>vClient = LoadCleintsDataFromFile(ClientsFileName);

    string stAccountNumber = ReadClientAccountNumber();

    while (!FindClientByAccountNumber(stAccountNumber, vClient, Client))
    {
        cout << "\nClient with [" << stAccountNumber << "] does not exist.\n";
        stAccountNumber = ReadClientAccountNumber();
    }

    PrintClientCard(Client);

    double Amount = ReadDepositAmount("Please Enter Amount Deposit ?");

    DepositBalanceToClientByAccountNumber(vClient, Amount, stAccountNumber);
}

void ShowTotalBalance()
{
    double Sum = 0;
    vector <sClient> vClients = LoadCleintsDataFromFile(ClientsFileName);

    cout << "\n\t\t\t\t\tClient List (" << vClients.size() << ") Client(s).";
    cout << "\n_______________________________________________________";
    cout << "_________________________________________\n" << endl;

    cout << "| " << left << setw(15) << "Accout Number";
    cout << "| " << left << setw(40) << "Client Name";
    cout << "| " << left << setw(12) << "Balance";
    cout << "\n_______________________________________________________";
    cout << "_________________________________________\n" << endl;
    for (sClient counter: vClients)
    {
        Sum += counter.AccountBalance;
    }
    if (vClients.size() == 0)
        cout << "\t\t\t\tNo Clients Available In the System!";
    else

        for (sClient Client : vClients)
        {

            PrintClientRecordLine(Client);
            cout << endl;
        }

    cout << "\n_______________________________________________________";
    cout << "_________________________________________\n" << endl;
    cout << "\n\t\t\t\t\tTotal Balance = " << Sum << endl;
}

double ReadWithdrawAmount(string Message)
{
    double WithAmount = 0;
        cout << Message << endl;
        cin >> WithAmount;
    return WithAmount;
}

bool WithdrawBalanceToClientByAccountNumber(vector<sClient>&vClient,string stAccountNumber,double Amount)
{
    char Letter;
    cout << "\n\nAre you sure you want perform this transaction? y/n ?";
    cin >> Letter;
    if (toupper(Letter) == 'Y')
    {
        for (sClient& counter : vClient)
        {
            if (counter.AccountNumber == stAccountNumber)
            {
                counter.AccountBalance += Amount;
                SaveCleintsDataToFile(ClientsFileName, vClient);
                return true;
            }
        }
    }
    return false;
}

void ShowWithdrawScreen()
{
    cout << "---------------------------------------" << endl;
    cout << "\tWithdraw Screen" << endl;
    cout << "---------------------------------------" << endl;

    sClient Client;

    string stAccountNumber = ReadClientAccountNumber();

    vector<sClient>vClient = LoadCleintsDataFromFile(ClientsFileName);

    while (!FindClientByAccountNumber(stAccountNumber, vClient, Client))
    {
        cout << "\nClient with [" << stAccountNumber << "] does not exist.\n";
        stAccountNumber = ReadClientAccountNumber();
    }

    PrintClientCard(Client);

    double Amount = ReadWithdrawAmount("Please Enter Withdraw Amount ? ");

    while (Amount > Client.AccountBalance)
    {
        cout << "\nAmount Exceed the Balance , you can withdraw up to : " << Client.AccountBalance << endl;
        Amount = ReadWithdrawAmount("Please Enter Withdraw Amount ?");
    }
      
    WithdrawBalanceToClientByAccountNumber(vClient, stAccountNumber, Amount * -1);
}

void GoBackToTransactionMenue()
{
    cout << "\n\nPress any key to go back to Main Menue...";
    system("pause>0");
    TransactionMenueScreen();
}

void GoBackToManageUsers()
{
    cout << "\n\nPress any key to go back to Main Menue...";
    system("pause>0");
    ManageUsersMenueScreen();
}

void PerformTransactionOption(enTransactionMenueOption TransactionMenueOption)
{
    switch (TransactionMenueOption)
    {
    case enTransactionMenueOption::eDeposit:
    {
        system("cls");
        ShowDepositScreen();
        GoBackToTransactionMenue();
        break;
    }

    case enTransactionMenueOption::eWithdraw:
    {
        system("cls");
        ShowWithdrawScreen();
        GoBackToTransactionMenue();
        break;
    }
    case enTransactionMenueOption::eTotalBalance:
    {
        system("cls");
        ShowTotalBalance();
        GoBackToTransactionMenue();
        break;
    }
    case enTransactionMenueOption::eMainMenue:
    {
        ShowMainMenue();
    }
    
    }
}

void PerformManageUsersOption(enManageUser ManageUser)
{
    switch (ManageUser)
    {
    case enManageUser::eListUser:
    {
        system("cls");
        ShowAllUsersScreen();
        GoBackToManageUsers();
        break;
    }
    case enManageUser::eAddUser:
    {
        system("cls");
        ShowAddNewUsersScreen();
        GoBackToManageUsers();
        break;
    }
    case enManageUser::eDeleteUser:
    {
        system("cls");
        ShowDeleteUserScreen();
        GoBackToManageUsers();
        break;
    }
    case enManageUser::eUpdateUser:
    {
        system("cls");
        ShowUpdateUserScreen();
        GoBackToManageUsers();
        break;
    }
    case enManageUser::eFindUser:
    {
        system("cls");
        ShowFindUserScreen();
        GoBackToManageUsers();
        break;
    }
    case enManageUser::MainMenue:
    {
        GoBackToMainMenue();
    }
    }
}

short ReadTransactionMenueOption()
{
    int TransactionMenue = 0;
    do
    {
        cout << "Choose What do you want to do? [1 to 4]?";
        cin >> TransactionMenue;
    } while (TransactionMenue > 4);
    return TransactionMenue;
}

short ReadManageUserMenueOption()
{
    short ManageUserMenue = 0;
    do
    {
        cout << "Chosse Whar do you want to do? [1 to 6]?";
        cin >> ManageUserMenue;
    } while (ManageUserMenue > 6);
    return ManageUserMenue;
}

void TransactionMenueScreen()
{
    if (!CheckAccessPermission(enMainMenuePermissions::pTransaction))
    {
        ShowAccessDeniedMessage();
        GoBackToMainMenue();
        return;
    }

    system("cls");
    cout << "===========================================\n";
    cout << "\t\tTransaction Menue Screen\n";
    cout << "===========================================\n";
    cout << "\t[1] Deposit.\n";
    cout << "\t[2] Withdraw.\n";
    cout << "\t[3] Total Balance.\n";
    cout << "\t[4] Main Menue.\n";
    cout << "===========================================\n";
    PerformTransactionOption((enTransactionMenueOption)ReadTransactionMenueOption());
}

void ManageUsersMenueScreen()
{
    if (!CheckAccessPermission(enMainMenuePermissions::pManageUser))
    {
        ShowAccessDeniedMessage();
        GoBackToMainMenue();
        return;
    }

    system("cls");
    cout << "===========================================\n";
    cout << "\t\tManage Users Menue Screen\n";
    cout << "===========================================\n";
    cout << "\t[1] List Users.\n";
    cout << "\t[2] Add New User.\n";
    cout << "\t[3] Delete User.\n";
    cout << "\t[4] Update User.\n";
    cout << "\t[5] Find User.\n";
    cout << "\t[6] Main Menue.\n";
    cout << "===========================================\n";
    PerformManageUsersOption((enManageUser)ReadManageUserMenueOption());
}

void PerfromMainMenueOption(enMainMenueOptions MainMenueOption)
{
    switch (MainMenueOption)
    {
    case enMainMenueOptions::eListClients:
    {
        system("cls");
        ShowAllClientsScreen();
        GoBackToMainMenue();
        break;
    }
    case enMainMenueOptions::eAddNewClient:
    {
        system("cls");
        ShowAddNewClientsScreen();
        GoBackToMainMenue();
        break;
    }
    case enMainMenueOptions::eDeleteClient:
    {
        system("cls");
        ShowDeleteClientScreen();
        GoBackToMainMenue();
        break;
    }
    case enMainMenueOptions::eUpdateClient:
    {
        system("cls");
        ShowUpdateClientScreen();
        GoBackToMainMenue();
        break;
    }
    case enMainMenueOptions::eFindClient:
    {
        system("cls");
        ShowFindClientScreen();
        GoBackToMainMenue();
        break;
    }
    case enMainMenueOptions::eTransactions:
    {
        system("cls");
        TransactionMenueScreen();
        break;
    }
    case enMainMenueOptions::eManageUsers:
    {
        system("cls");
        ManageUsersMenueScreen();
        break;
    }
    case enMainMenueOptions::eLogin:
    {
        system("cls");
        LoginScreen();
        break;
    }
    }
}

void ShowMainMenue()
{
    system("cls");
    cout << "===========================================\n";
    cout << "\t\tMain Menue Screen\n";
    cout << "===========================================\n";
    cout << "\t[1] Show Client List.\n";
    cout << "\t[2] Add New Client.\n";
    cout << "\t[3] Delete Client.\n";
    cout << "\t[4] Update Client Info.\n";
    cout << "\t[5] Find Client.\n";
    cout << "\t[6] Transactions. \n";
    cout << "\t[7] Manage Users.\n";
    cout << "\t[8] Logout.\n";
    cout << "===========================================\n";
    PerfromMainMenueOption((enMainMenueOptions)ReadMainMenueOption());
}

bool LoadUserInfo(string Username, string Password)
{
    if (FindUserByUsernameAndPassword(Username, Password, CurrentUser))
        return true;
    else
        return false;
}

void LoginScreen()
{

    bool LoginFaild = false;

    string Username, Password;
    do
    {
        system("cls");

        cout << "\n-----------------------------------\n";
        cout << "\tLogin Screen";
        cout << "\n-----------------------------------\n";
        if (LoginFaild)
        {
            cout << "Invalid Username/Password!" << endl;
        }
        cout << "Enter Username? ";
        cin >> Username;
        cout << "Enter Password? ";
        cin >> Password;
        LoginFaild = !LoadUserInfo(Username, Password);
    } while (LoginFaild);

    ShowMainMenue();
}

int main()
{
    LoginScreen();
    system("pause>0");
    return 0;
}