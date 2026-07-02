using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace WinFormsApp1.Entities
{

    public class Category
    {

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
    }
}