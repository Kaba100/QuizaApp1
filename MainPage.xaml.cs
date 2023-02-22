namespace MyFirstApp;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }


    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        string labelText = "";

        Frame tappedFrame = (Frame)sender;

        var frameContent = tappedFrame.Content;
        Label myLabel = new Label();

        var label = frameContent.GetType();
        if (label == typeof(Label))
        {
           myLabel  = (Label)frameContent;
            labelText = myLabel.Text;
        }


        if (labelText == "Question 1")
        {
            //   var respnse = await DisplayActionSheet("1. Which of these food do you like?", "Cancel", 
            //"Close", "(A). Jollof Rice", "(B). Yam & Egg", "(C). Bread and Bean",
            //"(D). Amala and Ewedu");
            string respnse = await DisplayActionSheet("1. Who discover America", "Cancel",
                         "Close", "(A). Christopher Columbus", "(B).Nikola Tesla", "(C). Muhammadu Buhari",
                         "(D). Abraham Lincoln");

            if (respnse == "(A). Christopher Columbus")
            {
                await DisplayAlert("You are correct", "The answer is A", "close");
                tappedFrame.BackgroundColor = Colors.Green;
                myLabel.TextColor = Colors.White;
            }
            else
            {
                await DisplayAlert("Incorrect Option", "Sorry that is wrong", "close");
                tappedFrame.BackgroundColor = Colors.Red;
                myLabel.TextColor = Colors.White;
            }
            tappedFrame.IsEnabled = false;
        }

        //  await DisplayAlert("You picked", respnse, "Alright");


        //	await DisplayAlert("You picked", respnse, "Alright");
        //if(respnse == )

        if (labelText == "Question 2")
        {

            string respnse = await DisplayActionSheet("2. Who was the First America President ", "Cancel",
               "Close", "(A). George Washington", "(B). Abraham Lincoln", "(C). George Bush",
               "(D). Bill Cliton");
            // await DisplayAlert("You picked", respnse, "Alright");
            if (respnse == "(A). George Washington")
            {
                await DisplayAlert("You are correct", "The answer is A", "close");
                tappedFrame.BackgroundColor = Colors.Green;
                myLabel.TextColor = Colors.White;
            }
            else
            {
                await DisplayAlert("Incorrect Option", "Sorry that is wrong", "close");
                tappedFrame.BackgroundColor = Colors.Red;
                myLabel.TextColor = Colors.White;
            }
            tappedFrame.IsEnabled = false;
        }

        if (labelText == "Question 3")
        {
            string respnse = await DisplayActionSheet("3. The most rampant element in Earth", "Cancel",
                   "Close", "(A). Sodium", "(B).Calcium", "(C).Hydrogen",
                   "(D). Aluminium");
            // await DisplayAlert("You picked", respnse, "Alright");
            if (respnse == "(C).Hydrogen")
            {
                await DisplayAlert("You are correct", "The answer is C", "close");
                tappedFrame.BackgroundColor = Colors.Green;
                myLabel.TextColor = Colors.White;
            }
            else
            {
                await DisplayAlert("Incorrect Option", "Sorry that is wrong", "close");
                tappedFrame.BackgroundColor = Colors.Red;
                myLabel.TextColor = Colors.White;
            }
            tappedFrame.IsEnabled = false;
        }

        if (labelText == "Question 4")
        {
            string respnse = await DisplayActionSheet("4. Which year did Nigeria gain her Independence", "Cancel",
                            "Close", "(A). 1st of October 1957", "(B).1st of October 1960", "(C). 1st of October 1963",
                            "(D). 1st of October 1973");
            //  await DisplayAlert("You picked", respnse, "Alright");
            if (respnse == "(B).1st of October 1960")
            {
                await DisplayAlert("You are correct", "The answer is B", "close");
                tappedFrame.BackgroundColor = Colors.Green;
                myLabel.TextColor = Colors.White;
            }
            else
            {
                await DisplayAlert("Incorrect Option", "Sorry that is wrong", "close");
                tappedFrame.BackgroundColor = Colors.Red;
                myLabel.TextColor = Colors.White;
            }
            tappedFrame.IsEnabled = false;
        }
        if (labelText == "Question 5")
        {
            string respnse = await DisplayActionSheet("5. Which year did the amalgation of Nigeria takes place", "Cancel",
                           "Close", "(A). 1945", "(B). 1963", "(C). 1941",
                           "(D).1914");
            //  await DisplayAlert("You picked", respnse, "Alright");
            if (respnse == "(D).1914")
            {
                await DisplayAlert("You are correct", "The answer is D", "close");
                tappedFrame.BackgroundColor = Colors.Green;
                myLabel.TextColor = Colors.White;
            }
            else
            {
                await DisplayAlert("Incorrect Option", "Sorry that is wrong", "close");
                tappedFrame.BackgroundColor = Colors.Red;
                myLabel.TextColor = Colors.White;
            }
            tappedFrame.IsEnabled = false;
        }

        if(labelText == "Question 6")
        {
           string respnse = await DisplayActionSheet("7. Who among these people has two Nobel price", "Cancel",
                  "Close", "(A). Galileo Galilei", "(B).Nikola Tesla", "(C). Marie Curie",
                 "(D). Albert Einstein");
            await DisplayAlert("You picked", respnse, "Alright");
            if (respnse == "(C). Marie Curie")
            {
                await DisplayAlert("You are correct", "The answer is C", "close");
                tappedFrame.BackgroundColor = Colors.Green;
                myLabel.TextColor = Colors.White;
            }
            else
            {
                await DisplayAlert("Incorrect Option", "Sorry that is wrong", "close");
                tappedFrame.BackgroundColor = Colors.Red;
                myLabel.TextColor = Colors.White;
            }
            tappedFrame.IsEnabled = false;
        }
        
        if(labelText == "Question 7")
        {
          string  respnse = await DisplayActionSheet("8. Which of was Co-Founder of Apple Company", "Cancel",
                 "Close", "(A). Steve Jobs", "(B). Bill Gates", "(C). Elon Musk",
                  "(D). Phillip Emeagwuali");
            await DisplayAlert("You picked", respnse, "Alright");
            if (respnse == "(A). Steve Jobs")
            {
                await DisplayAlert("You are correct", "The answer is A", "close");
                tappedFrame.BackgroundColor = Colors.Green;
                myLabel.TextColor = Colors.White;
            }
            else
            {
                await DisplayAlert("Incorrect Option", "Sorry that is wrong", "close");
                tappedFrame.BackgroundColor = Colors.Red;
                myLabel.TextColor = Colors.White;
            }
            tappedFrame.IsEnabled = false;
        }

        if(labelText =="Question 8")
        {
          string  respnse = await DisplayActionSheet("9. What happened on 9/11", "Cancel",
                  "Close", "(A). They were distruction in Tokyo", "(B). They were distruction in New Jersey", "(C). They were distruction in New York City",
                  "(D). They were distruction in Texas");
            await DisplayAlert("You picked", respnse, "Alright");
            if (respnse == "(C). They were distruction in New York City")
            {
                await DisplayAlert("You are correct", "The answer is C", "close");
                tappedFrame.BackgroundColor = Colors.Green;
                myLabel.TextColor = Colors.White;
            }
            else
            {
                await DisplayAlert("Incorrect Option", "Sorry that is wrong", "close");
                tappedFrame.BackgroundColor = Colors.Red;
                myLabel.TextColor = Colors.White;
            }
            tappedFrame.IsEnabled = false;
        }
        if(labelText == "Question 9")
        {
         string   respnse = await DisplayActionSheet("10. Who is the Last Messenger of Allah", "Cancel",
                 "Close", "(A).Prophet Ibrahim (AS)", "(B). Prophet Musa (AS)", "(C). Prophet Iesa (AS)",
                "(D). Prophet Muhammod (SAW)");
            await DisplayAlert("You picked", respnse, "Alright");
            if (respnse == "(D). Prophet Muhammod (SAW)")
            {
                await DisplayAlert("You are correct", "The answer is D", "close");
                tappedFrame.BackgroundColor = Colors.Green;
                myLabel.TextColor = Colors.White;
            }
            else
            {
                await DisplayAlert("Incorrect Option", "Sorry that is wrong", "close");
                tappedFrame.BackgroundColor = Colors.Red;
                myLabel.TextColor = Colors.White;
            }
            tappedFrame.IsEnabled = false;
        }

       
          
        

    }
}


