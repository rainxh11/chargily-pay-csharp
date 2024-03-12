﻿namespace Chargily.Pay.V2.Abstractions;

public interface IWebhookValidator
{
  bool Validate(string signature, string body);
  bool Validate(string signature, Stream body);
}