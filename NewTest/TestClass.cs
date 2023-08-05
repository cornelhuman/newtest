using System;
using Newtonsoft.Json;

namespace NewTest
{
    public partial class TestClass
    {
        [JsonProperty("Categories")]
        public List<Category> Categories { get; set; }


        public TestClass()
        {
            Categories = new();
            Categories.Add(new Category()
            {
                Name = "Fruit",
                Items = new List<Item>()
            {
                new Item() {  Id=1,ImageUrl = $"https://static.wikia.nocookie.net/pixar/images/a/aa/Nemo-FN.png/revision/latest/smart/width/250/height/250?cb=20160710221104" , Text = "test" },
                new Item() { Id=2, ImageUrl = $"https://static.wikia.nocookie.net/pixar/images/1/1f/Dory-white.jpg/revision/latest/scale-to-width-down/350?cb=20110924203518", Text = "I am ready for a test"},
            }
            });

            Categories.Add(new Category()
            {
                Name = "Travel",
                Items = new List<Item>()
            {
                new Item() { Id=3, ImageUrl = $"https://static.wikia.nocookie.net/pixar/images/e/e3/Bruce-render.png/revision/latest/scale-to-width-down/350?cb=20181210152244", Text = "test2" },
                new Item() { Id=4, ImageUrl = $"https://static.wikia.nocookie.net/pixar/images/7/72/Gill.png/revision/latest/scale-to-width-down/350?cb=20210322233843", Text = "Look at the test"}

            }
            });
        }
    }

    public partial class Category
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Items")]
        public List<Item> Items { get; set; }
    }

    public partial class Item
    {

        [JsonProperty("Id")]
        public long Id { get; set; }

        [JsonProperty("ImageId")]
        public string ImageUrl { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
        
    }
    
}

