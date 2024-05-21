using System;

namespace RefactoringGuru.DesignPatterns.Command.Conceptual
{
    // Creamos una interface de comando
    public interface Order
    {
        void execute();
    }

    // Clase de pedido0
    public class Stock(String name, int cantidad)
    {
        private String name = name;
        private int quantity = cantidad;

        public void buy()
        {
            Console.WriteLine("Orden de compra --> [ Nombre: " + name + ", Cantidad: " + quantity + " ] ");
        }
        public void sell()
        {
            Console.WriteLine("Orden de venta --> [ Nombre: " + name + ", Cantidad: " + quantity + " ] ");
        }
    }

    // Creamos las clases concretas que implementen a la interface
    public class BuyStock : Order
    {
        private Stock abcStock;

        public BuyStock(Stock abcStock)
        {
            this.abcStock = abcStock;
        }

        public void execute()
        {
            abcStock.buy();
        }
    }
    public class SellStock : Order
    {
        private Stock abcStock;

        public SellStock(Stock abcStock)
        {
            this.abcStock = abcStock;
        }

        public void execute()
        {
            abcStock.sell();
        }
    }

    // Creamos un invoker que funciona como Broker
    public class Broker
    {
        private List<Order> orderList = new List<Order>();

        public void takeOrder(Order order)
        {
            orderList.Add(order);
        }

        public void placeOrders()
        {
            foreach (Order order in orderList)
            {
                order.execute();
            }
            orderList.Clear();
        }
    }

    // Ejecucion de los comandos a travez de broker (ejecutando los comandos)
    public class CommandPatternDemo
    {
        public static void Main(String[] args)
        {
            Stock Stock = new Stock("Coca", 10);
            Stock Stock2 = new Stock("Pepsi", 20);

            BuyStock buyStockOrder = new BuyStock(Stock);
            SellStock sellStockOrder = new SellStock(Stock2);

            Broker broker = new Broker();
            broker.takeOrder(buyStockOrder);
            broker.takeOrder(sellStockOrder);

            broker.placeOrders();
        }
    }
}