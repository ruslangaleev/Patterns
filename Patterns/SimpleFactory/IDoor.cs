namespace SimpleFactory
{
    /// <summary>
    /// Дверь
    /// </summary>
    public interface IDoor
    {
        /// <summary>
        /// Возвращает ширину двери
        /// </summary>
        float GetWidth();

        /// <summary>
        /// Возвращает высоту двери
        /// </summary>
        float GetHeight();
    }

    public class WoodenDoor : IDoor
    {
        #region Конструктор и инициализация полей

        /// <summary>
        /// Ширина двери
        /// </summary>
        protected float _width;

        /// <summary>
        /// Высота двери
        /// </summary>
        protected float _height; 
        
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="width">Ширина двери</param>
        /// <param name="height">Высота двери</param>
        public WoodenDoor(float width, float height)
        {
            _width = width;
            _height = height;
        }

        #endregion

        #region Методы

        /// <summary>
        /// Возвращает высоту двери
        /// </summary>
        public float GetHeight()
        {
            return _height;
        }

        /// <summary>
        /// Возвращает ширину двери
        /// </summary>
        public float GetWidth()
        {
            return _width;
        } 

        #endregion
    }
}
