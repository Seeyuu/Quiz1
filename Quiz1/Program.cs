using System;

public class Program {
    public static Info NewInfo(string Uniname, string Libraryname, string Adress, string Tel){
        return new Info(Uniname,Libraryname,Adress,Tel);
    }

    public static Agents NewAgent(string UniName1, string AName, string ASName, string AID){
        return new Agents(UniName1,AName,ASName,AID);
    }

    public static void Main(string[] args){
        Info Chula = NewInfo("Chulalongkorn University",
        "Rak Dee",
        "254 Phayathai Rd. Wangmai Patumwan Bangkok 10330, Thailand",
        "0 2215 3555");

        Info Mahidol = NewInfo("Mahidol University",
        "Rak Lok",
        "Phutthamonthon 4 Rd. 999, 73170 Nakhon Pathom, Thailand,",
        "02 849 6000");

        Info KMITL = NewInfo("King Mongkut's Institute of technology Ladkrabang",
        "Ke Ki",
        "1 Soi Chalongkrung 1, Ladkrabang, Bangkok 10520 Thailand",
        "02 329 8397");

        Info KhonGaen = NewInfo("Khon Kaen University",
        "Wut Tha Na",
        "Khon Kaen University 123 Moo 16 Mittraphap Rd., Nai-Muang, Muang District, Khon Kaen 40002,Thailand",
        "043 009 700");

        Info KMUTT = NewInfo("King Mongkut's University of Technology Thonburi",
        "Ar Thorn",
        "126 Pracha Uthit Rd., Bang Mod, Thung Khru, Bangkok 10140, Thailand",
        "0 2470 8000");

        Agents Chulaa = NewAgent("Chulalongkorn University","Chaidee","Rakdee","153-698-4561237");
        Agents Mahidoll = NewAgent("Mahidol University","Norndee","jaidee","742-112-5687412");
        Agents KMITLL = NewAgent("King Mongkut's Institute of technology Ladkrabang","Arpaidee","Reandee","541-772-3215689");
        Agents KhonGaenn = NewAgent("Khon Kean University","Tumdee","Ngarndee","777-772-4578923");
        Agents KMUTTT = NewAgent("King Mongkut's University of Technology Thonburi","Norndee","Riubdee","003-852-4752000");

        Console.WriteLine("******************************");
        Console.WriteLine("What do you want to do?");
        Console.WriteLine(" ");
        Console.WriteLine("Press 1 for each University Information.");
        Console.WriteLine("Press 2 for each University Agents.");
        Console.WriteLine("Press 3 to see which University have lowest FT.");
        Console.WriteLine(" ");
        Console.WriteLine("******************************");

        int choice;
        Console.Write("Please Input number : ");
        choice = int.Parse(Console.ReadLine());

        switch (choice){
            case 1:
            PrintInformation(Chula);
            PrintInformation(Mahidol);
            PrintInformation(KMITL);
            PrintInformation(KhonGaen);
            PrintInformation(KMUTT);
        break;
            case 2:
            PrintAgents(Chulaa);
            PrintAgents(Mahidoll);
            PrintAgents(KMITLL);
            PrintAgents(KhonGaenn);
            PrintAgents(KMUTTT);
        break;
        default:
        Console.WriteLine("Error"); break;
        }       
    }

    

    static void PrintInformation(Info info){

        Console.WriteLine(" ");
        Console.WriteLine("University Name : {0}.",info.Uniname);
        Console.WriteLine("Library Name : {0}.",info.Libraryname);
        Console.WriteLine("Adress : {0}.",info.Adress);
        Console.WriteLine("Telephon Number : {0}",info.Tel);
        Console.WriteLine(" ");
        Console.WriteLine("******************************");
    }

    static void PrintAgents(Agents agent){
        Console.WriteLine(" ");
        Console.WriteLine("University Name : {0}.",agent.UniName1);
        Console.WriteLine("Agent Name : {0}.",agent.AName);
        Console.WriteLine("Agent Surname : {0}.",agent.ASName);
        Console.WriteLine("Agent ID : {0}.",agent.AID);
        Console.WriteLine(" ");
        Console.WriteLine("******************************");
    }
    
}
