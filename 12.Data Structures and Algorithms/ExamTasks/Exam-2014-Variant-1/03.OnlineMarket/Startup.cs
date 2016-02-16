namespace OnlineMarket
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Startup
    {
        public static void Main()
        {
            var onlineMarket = new OnlineMarket();
            var finalResult = new StringBuilder();

            string line = Console.ReadLine();
            while (line != "end")
            {
                var command = Command.Parse(line);
                switch (command.Name)
                {
                    case "add":
                        var product = Product.Parse(command.Arguments);
                        var result = onlineMarket.Add(product);
                        finalResult.AppendLine(result);
                        break;

                    case "filter":
                        switch (command.Arguments[1])
                        {
                            case "type":
                                var type = command.Arguments[2];
                                var filteredByType = onlineMarket.FilterByType(type);
                                if (!filteredByType.Any())
                                {
                                    finalResult.AppendLine(string.Format("Error: Type {0} does not exists", type));
                                }
                                else
                                {
                                    finalResult.AppendLine(string.Format("Ok: {0}", string.Join(", ", filteredByType)));
                                }

                                break;

                            case "price":
                                var minPrice = 0.0;
                                var maxPrice = double.MaxValue;
                                if (command.Arguments.Count > 4)
                                {
                                    minPrice = double.Parse(command.Arguments[3]);
                                    maxPrice = double.Parse(command.Arguments[5]);
                                }
                                else if (command.Arguments[2] == "to")
                                {
                                    maxPrice = double.Parse(command.Arguments[3]);
                                }
                                else
                                {
                                    minPrice = double.Parse(command.Arguments[3]);
                                }

                                var filteredByPrice = onlineMarket.FilterByPrice(minPrice, maxPrice);
                                finalResult.AppendLine(string.Format("Ok: {0}", string.Join(", ", filteredByPrice)));
                                break;

                            default:
                                throw new InvalidOperationException();
                        }

                        break;

                    default:
                        throw new InvalidOperationException();
                }

                line = Console.ReadLine();
            }

            Console.WriteLine(finalResult.ToString().Trim());
        }
    }

    public class Product : IComparable<Product>
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public double Price { get; set; }

        public static Product Parse(IList<string> productParts)
        {
            return new Product
            {
                Name = productParts[0],
                Price = double.Parse(productParts[1]),
                Type = productParts[2]
            };
        }

        public int CompareTo(Product other)
        {
            var result = this.Price.CompareTo(other.Price);
            if (result == 0)
            {
                result = this.Name.CompareTo(other.Name);
                if (result == 0)
                {
                    result = this.Type.CompareTo(other.Type);
                }
            }

            return result;
        }

        public override string ToString()
        {
            return string.Format("{0}({1})", this.Name, this.Price);
        }
    }

    public class Command
    {
        public string Name { get; set; }

        public IList<string> Arguments { get; set; }

        public static Command Parse(string commandAsString)
        {
            var commandParts = commandAsString.Split(' ');
            string name = commandParts[0];

            var newListOfStrings = new List<string>();
            for (int i = 1; i < commandParts.Length; i++)
            {
                newListOfStrings.Add(commandParts[i]);
            }

            return new Command
            {
                Name = name,
                Arguments = newListOfStrings
            };
        }
    }

    public class OnlineMarket
    {
        private IDictionary<string, SortedSet<Product>> productsByType;
        private IDictionary<double, SortedSet<Product>> productsByPrice;
        private ISet<string> productNames;
        private SortedSet<double> allPrices;

        public OnlineMarket()
        {
            this.productsByType = new Dictionary<string, SortedSet<Product>>();
            this.productsByPrice = new SortedDictionary<double, SortedSet<Product>>();
            this.productNames = new HashSet<string>();
            this.allPrices = new SortedSet<double>();
        }

        public string Add(Product product)
        {
            if (productNames.Contains(product.Name))
            {
                return string.Format("Error: Product {0} already exists", product.Name);
            }

            this.productNames.Add(product.Name);

            if (!productsByType.ContainsKey(product.Type))
            {
                productsByType[product.Type] = new SortedSet<Product>();
            }

            this.productsByType[product.Type].Add(product);

            this.allPrices.Add(product.Price);
            if (!this.productsByPrice.ContainsKey(product.Price))
            {
                this.productsByPrice[product.Price] = new SortedSet<Product>();
            }

            this.productsByPrice[product.Price].Add(product);

            return string.Format("Ok: Product {0} added successfully", product.Name);
        }

        public IEnumerable<Product> FilterByType(string type)
        {
            if (!this.productsByType.ContainsKey(type))
            {
                return Enumerable.Empty<Product>();
            }

            return this.productsByType[type].Take(10);
        }

        public IEnumerable<Product> FilterByPrice(double minPrice, double maxPrice)
        {
            var prices = this.allPrices.GetViewBetween(minPrice, maxPrice);

            var filteredProducts = new SortedSet<Product>();

            int taken = 0;            
            foreach (var price in prices)
            {
                foreach (var product in this.productsByPrice[price])
                {
                    if (taken == 10)
                    {
                        return filteredProducts;
                    }

                    filteredProducts.Add(product);
                    taken++;
                }
            }

            return filteredProducts;
        }
    }
}