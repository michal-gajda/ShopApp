namespace ShopApp.Controllers
{
    using System;
    using System.Net;
    using System.Net.Mail;
    using System.Text;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Models;

    [Authorize]
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart;
        private readonly IConfiguration _configuration;

        public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart, IConfiguration configuration)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
            _configuration = configuration;
        }

        // GET: /<controller>/
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Twój koszyk jest pusty. Dodaj pierwszy produkt");
            }

            if (ModelState.IsValid)
            {
                _orderRepository.CreateOrder(order);
                SendEmail(order);
                _shoppingCart.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }
            return View(order);
        }

        private void SendEmail(Order order)
        {
            if (string.IsNullOrWhiteSpace(_configuration.GetSection("Emails").GetValue<string>("UserName"))
            || string.IsNullOrWhiteSpace(_configuration.GetSection("Emails").GetValue<string>("Password"))
            || string.IsNullOrWhiteSpace(_configuration.GetSection("Emails").GetValue<string>("FromEmail")))
            {
                return;
            }

            var smtpClient = new SmtpClient(_configuration.GetSection("Emails").GetValue<string>("SmtpServer"))
            {
                Port = _configuration.GetSection("Emails").GetValue<int>("Port"),
                Credentials = new NetworkCredential(
                    _configuration.GetSection("Emails").GetValue<string>("UserName"),
                    _configuration.GetSection("Emails").GetValue<string>("Password")),
                EnableSsl = _configuration.GetSection("Emails").GetValue<bool>("EnableSsl"),
            };

            smtpClient.Send(
                _configuration.GetSection("Emails").GetValue<string>("FromEmail"),
                _configuration.GetSection("Emails").GetValue<string>("FromEmail"),
                $"Nowe Zamówienie nr #{order.OrderId}",
                CreateEmailBody(order));
        }

        private static string CreateEmailBody(Order order)
        {
            var stringBuilder = new StringBuilder($"Nowe Zamówienie nr #{order.OrderId}{Environment.NewLine + Environment.NewLine}");
            foreach (var orderDetail in order.OrderDetails)
            {
                stringBuilder.Append($"-> {orderDetail.Product.Name}: {orderDetail.Amount}x{orderDetail.Product.Price:#.##}{Environment.NewLine}");
            }

            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append($"SUMA: {order.OrderTotal:#.##}");
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append($"Zamawiający:");
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append($"{order.FirstName} {order.LastName}");
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append(order.Email);
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append(order.PhoneNumber);
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append(order.AddressLine1);
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append(order.AddressLine2);
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append($"{order.ZipCode} {order.City}");
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append(order.Country);
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append(order.State);

            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append(Environment.NewLine);
            return stringBuilder.ToString();
        }

        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Dziękujemy za zamówienie";
            return View();
        }
    }
}
