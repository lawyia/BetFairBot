using System;
using System.Collections.Generic;
using System.Text;

namespace BetFairInterface
    {
    public class BetFairFacade
        {
        

        //public static BFBot.Account Account()
        //    {
        //    return null;
        //    }

        public static string GetMarkets()
            {
            return null;
            }

        public static string GetMarket()
            {
            return "5082333";
            }

        public static string UpdateMarket(string id)
            {
            string testMarket = @"5082333~GBP~ACTIVE~0~1~NR\: (RSA) <br>8. Fan Mail (0%,11\:07), 6(2.5%,11\:08)~true~5.0~1162835723938~6. Earlswood,9.08,2.5;8. Fan Mail,9.07,2.4;:1058616~0~6.04~8.4~~11.9~false|1.15~15.0~L~1~|1.01~5.0~B~1~:670160~1~6.18~17.5~~4.2~false|1.15~15.0~L~1~|1.01~5.0~B~1~:1132008~2~9.78~5.2~~20.4~false|1.15~15.0~L~1~|1.01~5.0~B~1~:894820~3~140.02~4.6~~20.4~false|1.15~15.0~L~1~|1.01~5.0~B~1~:1414415~4~8.2~6.2~~16.0~false|1.15~15.0~L~1~|1.01~5.0~B~1~:575636~5~5.54~11.5~~8.6~false|1.15~15.0~L~1~|1.01~5.0~B~1~:1433455~6~0.0~~~0.4~false|1.15~15.0~L~1~|1.01~5.0~B~1~:1433456~7~0.0~~~0.9~false|1.15~15.0~L~1~|1.01~5.0~B~1~:746753~8~5.54~11.5~~5.2~false|1.15~15.0~L~1~|1.01~5.0~B~1~:1433457~9~0.0~~~4.2~false|1.15~15.0~L~1~|1.01~5.0~B~1~:1147548~10~0.0~~~2.6~false|1.15~15.0~L~1~|1.01~5.0~B~1~:1433458~11~62.46~2.0~~3.5~false|1.15~15.0~L~1~|1.01~5.0~B~1~:1433459~12~0.0~~~0.9~false|1.15~15.0~L~1~|1.01~5.0~B~1~:1433460~13~0.0~~~0.9~false|1.15~15.0~L~1~1.25~15.0~L~1~1.5~15.0~L~1|1.01~5.0~B~1~1.1~25.0~B~1~1.11~15.0~B~1~";
            return testMarket;
            }

        public static bool TransferTo(double amount)
            {
            return false;
            }

        public static bool Login(string username, string password)
            {
            return false;
            }

        public static double GetBalance()
            {
            return 0.0;
            }
        }
    }
