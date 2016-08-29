// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Insights.Models;

namespace Microsoft.Azure.Insights.Models
{
    /// <summary>
    /// A metric value set represents a set of metric values in a time period.
    /// </summary>
    public partial class Metric
    {
        private LocalizableString _dimensionName;
        
        /// <summary>
        /// Optional. Gets or sets the name of the dimension.
        /// </summary>
        public LocalizableString DimensionName
        {
            get { return this._dimensionName; }
            set { this._dimensionName = value; }
        }
        
        private LocalizableString _dimensionValue;
        
        /// <summary>
        /// Optional. Gets or sets the value of the dimension.
        /// </summary>
        public LocalizableString DimensionValue
        {
            get { return this._dimensionValue; }
            set { this._dimensionValue = value; }
        }
        
        private DateTime _endTime;
        
        /// <summary>
        /// Optional. Gets or sets the end time.
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }
        
        private IList<MetricValue> _metricValues;
        
        /// <summary>
        /// Optional. Gets or sets the collection of actual metric values.
        /// </summary>
        public IList<MetricValue> MetricValues
        {
            get { return this._metricValues; }
            set { this._metricValues = value; }
        }
        
        private LocalizableString _name;
        
        /// <summary>
        /// Optional. Gets or sets the name and the display name of the metric.
        /// </summary>
        public LocalizableString Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private IDictionary<string, string> _properties;
        
        /// <summary>
        /// Optional. Gets or sets the collection of extended properties.
        /// </summary>
        public IDictionary<string, string> Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }
        
        private string _resourceId;
        
        /// <summary>
        /// Optional. Gets or sets the resource ID of the resource that has
        /// emitted the metric.
        /// </summary>
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }
        
        private DateTime _startTime;
        
        /// <summary>
        /// Optional. Gets or sets the start time.
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }
        
        private TimeSpan _timeGrain;
        
        /// <summary>
        /// Optional. Gets or sets the time grain of the metric. Also known as
        /// the aggregation interval or frequency.
        /// </summary>
        public TimeSpan TimeGrain
        {
            get { return this._timeGrain; }
            set { this._timeGrain = value; }
        }
        
        private Unit _unit;
        
        /// <summary>
        /// Optional. Gets or sets the unit of the metric.
        /// </summary>
        public Unit Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Metric class.
        /// </summary>
        public Metric()
        {
            this.MetricValues = new LazyList<MetricValue>();
            this.Properties = new LazyDictionary<string, string>();
        }
    }
}