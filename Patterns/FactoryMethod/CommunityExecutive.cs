namespace FactoryMethod
{
    /// <summary>
    /// Исполнительный директор
    /// </summary>
    public class CommunityExecutive : IInterviewer
    {
        /// <summary>
        /// Задает вопрос
        /// </summary>
        /// <returns>Вопрос</returns>
        public string AskQuestions()
        {
            return "Спросить об общественном строительстве";
        }
    }
}
