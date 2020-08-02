using System;
using Telegram.Bot;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using Telegram.Bot.Types.InputFiles;
using Telegram.Bot.Types.Enums;


namespace Bot
{
    class Program
    {
        private static TelegramBotClient botClient = new TelegramBotClient("1321285425:AAGCINlDpaiEwmMGbW0hMj9vf7rEMrz7hYw");

        static void Main(string[] args)
        {
            botClient.OnMessage += BotClient_OnMessage;

            botClient.StartReceiving();
            Thread.Sleep(Timeout.Infinite);
            botClient.StopReceiving();
        }

        private static void BotClient_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            Console.WriteLine(e.Message.Text);

            if (e.Message.Text.ToUpper() == "OI")
            {
                botClient.SendTextMessageAsync(
                    e.Message.Chat.Id,
                    $"Olá! {e.Message.From.FirstName}, Seja bem vindo ao atendimento virtual do Banco Carrefour! " +
                    "                                                                                            " +
                    "Escolha uma opção abaixo:                                                                   " +
                    " 0 - Novidades                                                                              " +
                    " 1 - Baixe o App do Cartão Carrefour                                                        " +
                    " 2 - Parcele Fácil                                                                          " +
                    " 3 - Crédito Pessoal                                                                        " +
                    " 4 - Pag Contas                                                                             " +
                    " 5 - Saque rápido                                                                           " +
                    " 6 - SMS Controle Total                                                                     " +
                    " 7 - Extravio                                                                               " +
                    " 8 - Blog - Educação Financeira                                                             " +
                    " 9 - Tarifas e Serviços                                                                     " +
                    " 10 - Benefícios e Dúvidas                                                                  " +
                    " 11 - Dicas de Segurança                                                                    " +
                    " X- Para sair                                                                              ");

            }

            if (e.Message.Text.ToUpper() == "0")
            {
                FileStream fs = File.OpenRead(@"C:\Users\THYAGO VIDOVIX\bot2\bot2\Cartão Carrefour.jpg");
                InputOnlineFile myPhoto = new InputOnlineFile(fs, "Cartão Carrefour.jpg");

                botClient.SendPhotoAsync(e.Message.Chat.Id, myPhoto, "Para seguir em outras opções do Menu é só digitar o número específico.");

            }

            if (e.Message.Text.ToUpper() == "1")
            {
                botClient.SendTextMessageAsync(
                            chatId: e.Message.Chat.Id,
                            text: $"<a href =\"https://www.carrefoursolucoes.com.br/app\" >Clique aqui</a>" +
                                                                                          "Para seguir em outras opções do Menu é só digitar o número específico.",
                            parseMode: ParseMode.Html
                            );

            }

            if (e.Message.Text.ToUpper() == "2")
            {
                botClient.SendTextMessageAsync(
                            chatId: e.Message.Chat.Id,
                            text: $"<a href =\"https://www.youtube.com/watch?time_continue=6&v=KCtubRKDf_M&feature=emb_title\">Clique aqui</a>" +
                            "Para seguir em outras opções do Menu é só digitar o número específico.",
                            parseMode: ParseMode.Html
                            );

            }

            if (e.Message.Text.ToUpper() == "3")
            {
                FileStream fs = File.OpenRead(@"C:\Users\THYAGO VIDOVIX\bot2\bot2\Crédito Pessoal.jpg");
                InputOnlineFile myPhoto = new InputOnlineFile(fs, "Crédito Pessoal.jpg");

                botClient.SendPhotoAsync(e.Message.Chat.Id, myPhoto, "Para seguir em outras opções do Menu é só digitar o número específico.");
            }

            if (e.Message.Text.ToUpper() == "4")
            {
                FileStream fs = File.OpenRead(@"C:\Users\THYAGO VIDOVIX\bot2\bot2\Pag Contas.jpg");
                InputOnlineFile myPhoto = new InputOnlineFile(fs, "Pag Contas.jpg");

                botClient.SendPhotoAsync(e.Message.Chat.Id, myPhoto, "Para seguir em outras opções do Menu é só digitar o número específico.");
            }

            if (e.Message.Text.ToUpper() == "5")
            {
                FileStream fs = File.OpenRead(@"C:\Users\THYAGO VIDOVIX\bot2\bot2\Saque rápido.jpg");
                InputOnlineFile myPhoto = new InputOnlineFile(fs, "Saque rápido.jpg");

                botClient.SendPhotoAsync(e.Message.Chat.Id, myPhoto, "Para seguir em outras opções do Menu é só digitar o número específico.");
            }

            if (e.Message.Text.ToUpper() == "6")
            {
                FileStream fs = File.OpenRead(@"C:\Users\THYAGO VIDOVIX\bot2\bot2\SMS Controle Total.jpg");
                InputOnlineFile myPhoto = new InputOnlineFile(fs, "SMS Controle Total.jpg");

                botClient.SendPhotoAsync(e.Message.Chat.Id, myPhoto, "Para seguir em outras opções do Menu é só digitar o número específico.");
            }

            if (e.Message.Text.ToUpper() == "7")
            {
                botClient.SendTextMessageAsync(
                    e.Message.Chat.Id, "A notificação de extravio, já foi enviada para o suporte." +
                    "Para seguir em outras opções do Menu é só digitar o número específico.");
            }

            if (e.Message.Text.ToUpper() == "8")
            {
                botClient.SendTextMessageAsync(
                            chatId: e.Message.Chat.Id,
                            text: $"<a href =\"https://www.carrefoursolucoes.com.br/blog\">Clique aqui</a>" +
                            "Visite nosso Blog! Aprenda a comandar suas contas",
                            parseMode: ParseMode.Html
                            );
            }

            if (e.Message.Text.ToUpper() == "9")
            {
                botClient.SendTextMessageAsync(
                            chatId: e.Message.Chat.Id,
                            text: $"<a href =\"http://abre.ai/tabelabankfour\">Clique aqui</a>" +
                            "Baixe aqui a tabela de Tarifas e Serviços!                                                                                                       " +
                            "Para seguir em outras opções do Menu é só digitar o número específico.",
                            parseMode: ParseMode.Html
                            );
            }

            if (e.Message.Text.ToUpper() == "10")
            {
                botClient.SendTextMessageAsync(
                            chatId: e.Message.Chat.Id,
                            text: $"<a href =\"https://www.carrefoursolucoes.com.br/cartao/beneficios\">Clique aqui</a>" +
                            "Para seguir em outras opções do Menu é só digitar o número específico.",
                            parseMode: ParseMode.Html
                            );

            }

            if (e.Message.Text.ToUpper() == "11")
            {
                botClient.SendTextMessageAsync(
                          chatId: e.Message.Chat.Id,
                          text: $"<a href =\"https://www.carrefoursolucoes.com.br/dicas-de-seguranca\">Clique aqui</a>                                                          " +
                          "Para seguir em outras opções do Menu é só digitar o número específico. Lembrando! Se quiser sair é só digitar o X",
                          parseMode: ParseMode.Html
                          );
            }

            if (e.Message.Text.ToUpper() == "X")
            {
                botClient.SendTextMessageAsync(
                    e.Message.Chat.Id, "Lembrando que seu cartão pode ser usado em qualquer lugar!" +
                    "Protocolo do atendimento: Exemplo - 4987562421");
            }

        }

    }
}