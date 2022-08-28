namespace RJPCustomers.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using RJPCustomers.Models;
    using RJPCustomers.Services;
    using System;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly UserServices userServices;
        private readonly AccountServices accountServices;
        private readonly TransactionServices transactionServices;

        public HomeController(UserServices userServices, AccountServices accountServices, TransactionServices transactionServices)
        {
            this.userServices = userServices ?? throw new ArgumentNullException(nameof(userServices));
            this.accountServices = accountServices ?? throw new ArgumentNullException(nameof(accountServices));
            this.transactionServices = transactionServices ?? throw new ArgumentNullException(nameof(transactionServices));
        }

        [HttpPost("user/{customerId}/createaccount/{initialCredit}")]
        public async Task CreateAccount([FromBody] Guid customerId, int initialCredit)
        {
            await accountServices.CreateAccount(customerId, initialCredit);
        }

        [HttpGet("user/{customerId}/info")]
        public async Task<User> GetUserInfo(Guid customerId)
        {
            return await userServices.GetUser(customerId);
        }
    }
}
