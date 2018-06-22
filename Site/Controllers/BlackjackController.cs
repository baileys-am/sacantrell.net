using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sacantrell_site.Blackjack;

namespace sacantrell_site.Controllers
{
    [Route("api/[controller]")]
    public class BlackjackController : Controller
    {
        private readonly IBlackjack _blackjack;

        public BlackjackController(IBlackjack blackjack)
        {
            this._blackjack = blackjack ?? throw new ArgumentNullException(nameof(blackjack));
        }
    }
}