namespace OptionsExample
{
    public class MyObj
    {
        public string Name { get; set; }
    }
    public class MyOptions
    {
        public string Option1 { get; set; }
        public string[] Option2 { get; set; }
        public MyObj[] MyObj { get; set; }
    }
}