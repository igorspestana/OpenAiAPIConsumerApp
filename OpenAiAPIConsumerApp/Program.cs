using OpenAiAPIConsumerApp;

async Task ConsumingAiAPI()
{
    OpenAiAPIConsumer consuming = new OpenAiAPIConsumer();

    string question = Console.ReadLine();

    Console.WriteLine(await consuming.AskAquestionAsync(question));
}

await ConsumingAiAPI();