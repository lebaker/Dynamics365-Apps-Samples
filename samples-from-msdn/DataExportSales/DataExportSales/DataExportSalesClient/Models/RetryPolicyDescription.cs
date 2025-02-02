﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace DataExportSales.Models
{
    public partial class RetryPolicyDescription
    {
        private string _backoff;
        
        /// <summary>
        /// Optional. Retry backoff type
        /// </summary>
        public string Backoff
        {
            get { return this._backoff; }
            set { this._backoff = value; }
        }
        
        private int? _intervalInSeconds;
        
        /// <summary>
        /// Optional. Interval in seconds between each retry
        /// </summary>
        public int? IntervalInSeconds
        {
            get { return this._intervalInSeconds; }
            set { this._intervalInSeconds = value; }
        }
        
        private int? _maxRetryCount;
        
        /// <summary>
        /// Optional. Maximum retry count
        /// </summary>
        public int? MaxRetryCount
        {
            get { return this._maxRetryCount; }
            set { this._maxRetryCount = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the RetryPolicyDescription class.
        /// </summary>
        public RetryPolicyDescription()
        {
        }
        
        /// <summary>
        /// Serialize the object
        /// </summary>
        /// <returns>
        /// Returns the json model for the type RetryPolicyDescription
        /// </returns>
        public virtual JToken SerializeJson(JToken outputObject)
        {
            if (outputObject == null)
            {
                outputObject = new JObject();
            }
            if (this.Backoff != null)
            {
                outputObject["Backoff"] = this.Backoff;
            }
            if (this.IntervalInSeconds != null)
            {
                outputObject["IntervalInSeconds"] = this.IntervalInSeconds.Value;
            }
            if (this.MaxRetryCount != null)
            {
                outputObject["MaxRetryCount"] = this.MaxRetryCount.Value;
            }
            return outputObject;
        }
        
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                JToken backoffValue = inputObject["Backoff"];
                if (backoffValue != null && backoffValue.Type != JTokenType.Null)
                {
                    this.Backoff = ((string)backoffValue);
                }
                JToken intervalInSecondsValue = inputObject["IntervalInSeconds"];
                if (intervalInSecondsValue != null && intervalInSecondsValue.Type != JTokenType.Null)
                {
                    this.IntervalInSeconds = ((int)intervalInSecondsValue);
                }
                JToken maxRetryCountValue = inputObject["MaxRetryCount"];
                if (maxRetryCountValue != null && maxRetryCountValue.Type != JTokenType.Null)
                {
                    this.MaxRetryCount = ((int)maxRetryCountValue);
                }
            }
        }
    }
}
