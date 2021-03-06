﻿using System;

namespace Welo.Bot.ViewModels
{
    [Serializable]
    public class StandardCommandViewModel
    {
        public string Trigger { get; set; }
        public bool IsRandomResponse { get; set; }
        public bool IsVisibleOnMenu { get; set; }
        public CommandTypeViewModel CommandType { get; set; }
        public string TableName { get; set; }
        public string[] QuotesResponses { get; set; }
    }
}