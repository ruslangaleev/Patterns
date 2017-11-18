namespace FactoryMethod
{
    /// <summary>
    /// Разработчик
    /// </summary>
    public class Developer : IInterviewer
    {
        /// <summary>
        /// Задает вопрос
        /// </summary>
        /// <returns>Вопрос</returns>
        public string AskQuestions()
        {
            return "Спросить о шаблонах проектирования!";
        }
    }
}
