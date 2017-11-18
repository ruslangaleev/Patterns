namespace FactoryMethod
{
    /// <summary>
    /// Кадровичка
    /// </summary>
    public abstract class HiringManager
    {
        /// <summary>
        /// Абстрактный метод
        /// </summary>
        /// <returns></returns>
        protected abstract IInterviewer MakeInterviewer();

        /// <summary>
        /// Взять интервью
        /// </summary>
        public string TakeInterview()
        {
            var interviewer = MakeInterviewer();
            return interviewer.AskQuestions();
        }
    }
}
