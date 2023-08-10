using OpenAI_API;
using OpenAI_API.Completions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenAiAPIConsumerApp
{
    public class OpenAiAPIConsumer
    {
        const string ApiKey = "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";
        //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
        //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
        public OpenAiAPIConsumer() { }

        //Instanciar a API e consumir passando a key.

        //Retornar a respota da api
        public async Task<string> AskAquestionAsync(string question)
        {
            var openAi = new OpenAIAPI(ApiKey);

            //Completion request com definição do modelo usado
            var completionRequest = new CompletionRequest()
            {
                Model = "text-davinci-003",
                Prompt = question,
                MaxTokens = 10,
            };

            //CreateCompletionAsync() - Método para retornar a conclusão (reposta)
            var completions = await openAi.Completions.CreateCompletionAsync(completionRequest);

            return completions.Completions[0].Text;
        }
    }
}
