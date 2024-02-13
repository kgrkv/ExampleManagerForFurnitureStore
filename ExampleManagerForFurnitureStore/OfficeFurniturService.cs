using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleManagerForFurnitureStore
{
    internal class OfficeFurniturService
    {
        private string _path = "Furnitur.json";
        public List<Furniture> Furnitur {  get; set; }

        public OfficeFurniturService()
        {
            if (File.Exists(_path) == false)
                File.Create(_path).Close();
            try
            {
                string jsonContent = File.ReadAllText(_path);
                Furnitur = JsonConvert.DeserializeObject<List<Furniture>>(jsonContent);
                if (Furnitur == null) 
                {
                    Furnitur = new List<Furniture>(); 
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка чтения документа");  
            }

        }
    }
}
