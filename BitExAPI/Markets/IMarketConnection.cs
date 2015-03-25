﻿using BitExAPI.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitExAPI.Markets
{
    //public delegate void TradesUpdatedEvent(TradesResponse trades, string APIName);

    public interface IMarketConnection
    {
        event EventHandler<TradesEventArgs> OnTrades;   //Recieved new trades message

        /// <summary>
        /// Start a thread to begin receiving data from the exchange.
        ///     As data is recieved, the market events will be triggered.
        /// </summary>
        void Start();

        //---------------------------------------------------------------------
        // Manual Commands
        //---------------------------------------------------------------------

        Response RequestTrades();
    }
}
