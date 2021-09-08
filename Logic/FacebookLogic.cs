using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace Logic
{
    public static class FacebookLogic
    {
        public static bool IsUserAGoodMatch(User i_Friend, int i_MinAge, int i_MaxAge, bool i_ToFilterByGender, User.eGender i_GenderOfMatch)
        {
            bool isGoodMatch = checkRelationshipStatus(i_Friend);
            if (isGoodMatch)
            {
                int userAge = generateUserAge(i_Friend.Birthday);
                if (userAge < i_MinAge || userAge > i_MaxAge)
                {
                    isGoodMatch = false;
                }
            }

            if (isGoodMatch && i_ToFilterByGender)
            {
                if (i_Friend.Gender != i_GenderOfMatch)
                {
                    isGoodMatch = false;
                }
            }

            return isGoodMatch;
        }

        private static int generateUserAge(string i_FriendBirthday)
        {
            string[] birthDay = i_FriendBirthday.Split('/');
            int birthYear = int.Parse(birthDay.Last());

            if (birthYear < DateTime.Today.Year - 100 || birthYear > DateTime.Today.Year)
            {
                birthYear = DateTime.Today.Year; // facebook doesn't always show birthyear, so we give them 0
            }

            return DateTime.Today.Year - birthYear;
        }

        private static bool checkRelationshipStatus(User i_Friend)
        {
            //// returns true if available for relationship, false otherwise
            bool isAvailable = true;
            if (i_Friend.RelationshipStatus == User.eRelationshipStatus.Married
                || i_Friend.RelationshipStatus == User.eRelationshipStatus.Enagaged
                || i_Friend.RelationshipStatus == User.eRelationshipStatus.InARelationship)
            {
                isAvailable = false;
            }

            return isAvailable;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i_User"></param>
        /// <returns>name, email, gender, birthday, location</returns>
        public static List<string> FromUserToUserInfoStringCollection(User i_User)
        {
            List<string> listOfString = new List<string>();
            listOfString.Add(i_User.FirstName + i_User.LastName);
            listOfString.Add(i_User.Email);
            listOfString.Add(i_User.Gender.ToString());
            listOfString.Add(i_User.Birthday);
            listOfString.Add(i_User.Location.Name);

            return listOfString;
        }



        public static int AmountOfSimilarities(User i_Friend)
        {
            int result = 0;
            Promoter promoter = new Promoter(new PagesComparer());
            
            result += promoter.Promote(i_Friend.LikedPages);
            promoter.Comparer = new GroupsComparer();
            result += promoter.Promote(i_Friend.Groups);

            return result;
        }


        public static void DeleteUserData(ref AppSettings i_AppSettings)
        {
            i_AppSettings.LastAccessToken = null;
        }

        public static bool CheckIfUserLoggedIn(ref AppSettings i_AppSettings)
        {
            bool isUserExists = false;
            i_AppSettings = AppSettings.LoadFromFile();
            if (!string.IsNullOrEmpty(i_AppSettings.LastAccessToken))
            {
                isUserExists = true;
                if (SingletonUser.FacebookUser == null)
                {
                    SingletonUser.FacebookUser = FacebookService.Connect(i_AppSettings.LastAccessToken).LoggedInUser;
                }
            }

            return isUserExists;
        }
    }
}