namespace laba2
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string poem = "Я тобі галантно не вклонюся,\n" +
                          "Комплімента зроду не зліплю,\n" +
                          "Тільки в очі ніжні задивлюся,\n" +
                          "В них свою тривогу утоплю.\n\n" +
                          "І коли химерною габою\n" +
                          "Спеленає землю довга ніч,\n" +
                          "Довго серце тужить за тобою,\n" +
                          "Довго сон мені не йде до віч.\n\n" +
                          "Довго білі таємничі крила\n" +
                          "Обвивають маревом видінь,\n" +
                          "І стоїш ти крихітна, і мила,\n" +
                          "І прозора, мов ранкова тінь.\n\n" +
                          "І палають, ніби стиглі вишні,\n" +
                          "Владно підкоряючи собі,\n" +
                          "Губи неціловані і грішні,\n" +
                          "Очі божевільно голубі.";

            try
            {
                StrOperations text = new StrOperations(poem);
                Console.WriteLine($"Результат: {text.FilterLetters()}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

