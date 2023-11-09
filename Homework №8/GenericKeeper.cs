namespace Homework__8
{
    public class GenericKeeper<T>
    {
        static List<T> Items = new List<T>();
        public void AddItem(T item)
        {
            Items.Add(item);
        }
        public List<T> ShowItem()
        {
            List<T> items = new List<T>(Items);
            return items;
        }
        public string PrintItems()
        {
            string str = "";
            foreach (var _item in Items)
            {
                str += "----------------------\n";
                str += _item.ToString();
                str += "\n";
            }
            return str;
        }
    }
}
