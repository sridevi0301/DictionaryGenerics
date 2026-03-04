class DictionaryManager<TKey, TValue>
{
    private readonly Dictionary<TKey,TValue> _dictionary;
    public DictionaryManager()
    {
        _dictionary=new Dictionary<TKey,TValue>();
    }
    public void AddItem(TKey key, TValue value)
    {
        _dictionary.Add(key, value);
    }
    public TValue GetItem(TKey key)
    {
        return _dictionary[key];
    }
    public void RemoveItem(TKey key)
    {
        _dictionary.Remove(key);
    }
    public void DisplayAllItems()
    {
        foreach(var kvp in _dictionary)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        DictionaryManager<string, int> products=new DictionaryManager<string, int>();
        products.AddItem("Laptop", 120);
        products.AddItem("Smartphone", 80);
        products.AddItem("Tablet", 50);
        Console.WriteLine("All Products:");
        products.DisplayAllItems();
        products.RemoveItem("Smartphone");
        Console.WriteLine("\nAfter Removing Smartphone:");
        products.DisplayAllItems();

    }
}
