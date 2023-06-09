using MLApp;

// init loop
bool retry = true;

while (retry)
{
    // Clear the Console
    Console.Clear();

    // Get input data
    Console.WriteLine("How are you feeling? Enter a message for me:");
    string? message;
    do
    {
        message = Console.ReadLine();
    } while (message == null);

    // Add input data
    var sampleData = new SentimentModel.ModelInput()
    {
        Col0 = message
    };

    // Load model and predict output of sample data
    var result = SentimentModel.Predict(sampleData);

    // If Prediction is 1, then sentiment is "Positive", else it is "Negative"
    var sentiment = result.PredictedLabel == 1 ? "Positive" : "Negative";
    Console.WriteLine($"Text: {sampleData.Col0}\nSentiment: {sentiment}");

    Console.WriteLine("Would you like to go again? yes(y)/no(n)");
    string? answer = Console.ReadLine();
    retry = answer != null
        && answer.Length > 0
        && (answer.ToLower().Contains("yes") || answer.ToLower() == "y");
}
