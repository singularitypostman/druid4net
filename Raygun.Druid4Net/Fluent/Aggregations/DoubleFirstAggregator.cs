﻿namespace Raygun.Druid4Net
{
  public class DoubleFirstAggregator : BaseAggregator
  {
    public override string Type => "doubleFirst";

    public DoubleFirstAggregator(string name, string fieldName) 
      : base (name, fieldName)
    {
    }
  }
}