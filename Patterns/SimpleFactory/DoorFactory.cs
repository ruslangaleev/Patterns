namespace SimpleFactory
{
    /// <summary>
    /// Фабрика дверей
    /// </summary>
    public class DoorFactory
    {
        /// <summary>
        /// Создает дверь
        /// </summary>
        /// <param name="width">Ширина двери</param>
        /// <param name="height">Высота двери</param>
        /// <returns>Дверь</returns>
        public static IDoor CreateDoor(float width, float height)
        {
            return new WoodenDoor(width, height);
        }
    }
}
