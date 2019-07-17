using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceApp
{
    public class User
    {
        protected string userName;//поле которое хранит имя пользователя
        protected double userWeight;
        protected double userHeight;
        protected int userAge;
        protected string userGender;
        protected double userCcalIndex;
        protected int score;

        public User(string uName, double uWeight, double uHeight, int uAge, string uGender)
        {
            UserName = uName;
            UserWeight = uWeight;
            UserHeight = uHeight;
            UserAge = uAge;
            UserGender = uGender;
            userCcalIndex = GetUserCCalIndex();

        }

        public double GetUserCCalIndex()
        {
            if (UserGender == "female")
                return UserWeight * 9.99 + UserHeight * 6.25 - UserAge * 4.92 - 161;
            return UserWeight * 9.99 + UserHeight * 6.25 - UserAge * 4.92 + 5;
        }

        
        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                string s = Convert.ToString(value);
                if (CheckUserName(s))//проверка имени пользователя на валидность
                    userName = s;
                else
                    throw new ArgumentException();
            }
        }
        public double UserWeight
        {
            get
            {
                return userWeight;
            }
            set
            {
                userWeight = value;
            }
        }
        public double UserHeight
        {
            get
            {
                return userHeight;
            }
            set
            {
                userHeight = value;
            }
        }
        public int UserAge
        {
            get
            {
                return userAge;
            }
            set
            {
                userAge = value;
            }
        }
        public string UserGender
        {
            get
            {
                return userGender;
            }
            set
            {
                userGender = value;
            }
        }
        public double UserCcalIndex
        {
            get
            {
                return userCcalIndex;
            }
            set
            {
                userCcalIndex = value;
            }
        }
        public bool CheckUserName(string usnm)//метод проверки имени пользователя на валидность
        {
            if(usnm == null || usnm.Length > 20)
            {
                return false;
            }
            return true;
        }
        

    }
}
