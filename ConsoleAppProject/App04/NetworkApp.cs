using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App04
{
    public class NetworkApp
    {

        private NewsFeed news = new NewsFeed();
        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading("   Louis's News Feed");

            string[] choices = new string[]
            {
                "Post Message", "Post Image", "Remove Posts",
                "Display All Posts", "Displays Posts by Author",
                "Display Posts by Date", "Add Comment", "Like Posts",
                "Quit"
            };

            bool wantToQuit = false;

            do
            {
                int choice = ConsoleHelper.SelectChoice(choices);

                switch (choice)
                {
                    case 1: PostMessage(); break;
                    case 2: PostImage(); break;
                    case 3: RemovePost(); break;
                    case 4: DisplayAll(); break;
                    case 5: DisplayByAuthor(); break;
                    case 6: DisplayByDate(); break;
                    case 7: AddComment(); break;
                    case 8: LikePosts(); break;
                    case 9: wantToQuit = true; break;
                }

            } while (!wantToQuit);
        }

        private void PostMessage()
        {
            ConsoleHelper.OutputTitle(" Post a Message");
            string author = InputName();

            Console.Write("\tPlease Enter your message >");
            string message = Console.ReadLine();

            MessagePost post = new MessagePost(author, message);
            news.AddMessagePost(post);

            ConsoleHelper.OutputTitle(" Posted!");
            post.Display();
        }

        private void LikePosts()
        {
            throw new NotImplementedException();
        }

        private void AddComment()
        {
            throw new NotImplementedException();
        }

        private void DisplayByDate()
        {
            throw new NotImplementedException();
        }

        private void DisplayByAuthor()
        {
            throw new NotImplementedException();
        }

        private void RemovePost()
        {
            ConsoleHelper.OutputTitle($"Removing a Post");

            int id = (int)ConsoleHelper.InputNumber(" Please enter the post id >",
                                                    1, Post.GetNumberOfPosts());
            news.RemovePost(id);
        }

        private void DisplayAll()
        {
            news.Display();
        }

        private void PostImage()
        {
            ConsoleHelper.OutputTitle("Posting an Image/Photo");

            string author = InputName();

            Console.Write(" Please enter your image filename >");
            string filename = Console.ReadLine();

            Console.Write(" Please enter your image caption >");
            string caption = Console.ReadLine();

            PhotoPost post = new PhotoPost(author, filename, caption);
            Console.WriteLine(" Posted!");
            post.Display();
        }

        private string InputName()
        {
            Console.Write(" PLease enter your name >");
            string author = Console.ReadLine();

            return author;
        }
       
    }
}
