using System;
using TweetSharp;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace TS


    {
    public partial class Search : System.Web.UI.Page
        {

        protected void Page_Load(object sender, EventArgs e)
            {

            }


        public static string _consumerKey = "xEIgdSWP0eU6oxMzuzIbsabjV";
        public static string _consumerSecret = "PtYCNcpUykYgeKbDuSEtOa1LPcxj32WTzw3abevL8WOdo1ArRe";
        public static string _accessToken = "125733162-Qxl4hWD06GHjukpEAYsPulpSlOcXE8xcV8sgsJfw";  
        public static string _accessTokenSecret = "hrbPRnjDYbfscPkgwga5V6ljeT5ONIaXdCM7EaKIwLUZC";

        protected void Button1_Click(object sender, EventArgs e)
            {

            if (txtSearch.Text.Trim().Length < 1)
                lblMessage.Text = "Please enter some search criteria!";
            else
                
                {
                lblMessage.Text = "";
                TwitterService twitterService = new TwitterService(_consumerKey, _consumerSecret);
                twitterService.AuthenticateWith(_accessToken, _accessTokenSecret);
                int tweetcount = 1;
                int count = 100;
                var tweets_search = twitterService.Search(new SearchOptions { Q = txtSearch.Text, Count = count, Resulttype = TwitterSearchResultType.Popular });
                List<TwitterStatus> resultList = new List<TwitterStatus>(tweets_search.Statuses);
                foreach (var tweet in tweets_search.Statuses)
                    {
                    try
                        {

                        Label lblCount = new Label();
                        lblCount.Text = tweetcount.ToString() + ") <br />";

                        System.Web.UI.WebControls.Image Profile = new System.Web.UI.WebControls.Image();
                        Profile.ImageUrl = tweet.User.ProfileImageUrl;

                        //Label lblAuthor = new Label();
                        //lblAuthor.Text = "<br />" + tweet.User.Name + "<br />";
                        Label lblScreenName = new Label();
                        lblScreenName.Text = "<br />" + tweet.User.ScreenName + "<br />";

                        Label lblTime = new Label();
                        lblTime.Text = tweet.CreatedDate.ToLocalTime().ToString() + "<br />";

                        HyperLink lnkTweet = new HyperLink();
                        lnkTweet.NavigateUrl = "https://twitter.com/" + tweet.User.ScreenName + "/status/" + tweet.Id;
                        lnkTweet.Text = "https://twitter.com/" + tweet.User.ScreenName + "/status/" + tweet.Id + "<br />";                     
                        lnkTweet.Target = "_blank";

                        Label lbltweet = new Label();
                        lbltweet.Text = tweet.TextAsHtml + "<br />";

                        Label lblretweet = new Label();
                        lblretweet.Text = "Retweets:" + tweet.RetweetCount + "<br />";

                        Label lblFavorites = new Label();
                        string strRawSource = tweet.RawSource.Remove(0, tweet.RawSource.IndexOf("favorite_count", 0));
                        strRawSource = strRawSource.Remove(0, strRawSource.IndexOf("favorite_count", 2));
                        strRawSource = strRawSource.Substring(17, strRawSource.IndexOf(",") - 17);
                        lblFavorites.Text = "Favorites:" + strRawSource + "<br />" + "<br />";

                        //pnlTweets.Controls.Add(lblCount);
                        pnlTweets.Controls.Add(Profile);
                        //pnlTweets.Controls.Add(lblAuthor);
                        pnlTweets.Controls.Add(lblScreenName);
                        pnlTweets.Controls.Add(lblTime);
                        pnlTweets.Controls.Add(lbltweet);
                        pnlTweets.Controls.Add(lnkTweet);
                        pnlTweets.Controls.Add(lblretweet);
                        pnlTweets.Controls.Add(lblFavorites);
                        
                        tweetcount++;
                        }
                    catch { }
                    }
                
                }
            }
        protected void DisplayTweet()
            {



            }

        }
    }
